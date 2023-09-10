using Azure.Core;
using Azure.Identity;
using Microsoft.Extensions.Options;
using Microsoft.Graph;
using Microsoft.Graph.Me.SendMail;
using Microsoft.Graph.Models;

namespace POC.Helper
{
    public class GraphHelper
    {

        private DeviceCodeCredential? _deviceCodeCredential;

        private GraphServiceClient? _userClient;

        private readonly ConfigSettings _settings;

        public string Messge { get; set; }

        public GraphHelper(IOptions<ConfigSettings> configSettingssAccessor)
        {
            this._settings = configSettingssAccessor.Value;

            if (_settings == null)
            {
                throw new Exception();
            }


        }

        public void InitializeGraph()
        {
            _deviceCodeCredential = new DeviceCodeCredential((info, cancel) =>
            {
                GetDeviceCodeMessage( info.Message);
                Console.WriteLine(info.Message);
                return Task.FromResult(info);
            },
                _settings.TenantId, _settings.ClientId);

            
            _userClient = new GraphServiceClient(_deviceCodeCredential, _settings.GraphUserScopes);

           
        }

        public Task<User?> GetUserAsync()
        {

            _ = _userClient ??
                throw new NullReferenceException("Graph has not been initialized for user auth");

            return _userClient.Me.GetAsync((config) =>
            {

                config.QueryParameters.Select = new[] { "displayName", "mail", "userPrincipalName" };
            });
        }

        public Task<MessageCollectionResponse?> GetInboxAsync()
        {

            _ = _userClient ??
                throw new System.NullReferenceException("Graph has not been initialized for user auth");

            return _userClient.Me
                // Only messages from Inbox folder
                .MailFolders["Inbox"]
                .Messages
                .GetAsync((config) =>
                {
                    // Only request specific properties
                    config.QueryParameters.Select = new[] { "from", "isRead", "receivedDateTime", "subject" };
                    // Get at most 25 results
                    config.QueryParameters.Top = 25;
                    // Sort by received time, newest first
                    config.QueryParameters.Orderby = new[] { "receivedDateTime DESC" };
                });
        }

        public async Task SendMailAsync(string subject, string body, string recipient)
        {

            _ = _userClient ??
                throw new System.NullReferenceException("Graph has not been initialized for user auth");


            var message = new Message
            {
                Subject = subject,
                Body = new ItemBody
                {
                    Content = body,
                    ContentType = BodyType.Text
                },
                ToRecipients = new List<Recipient>
            {
                new Recipient
                {
                    EmailAddress = new EmailAddress
                    {
                        Address = recipient
                    }
                }
            }
            };


            await _userClient.Me
                .SendMail
                .PostAsync(new SendMailPostRequestBody
                {
                    Message = message
                });
        }


        public async static Task MakeGraphCallAsync()
        {

        }
        public string GetDeviceCodeMessage(string msg)
        {
            Messge = msg;
            return  msg;
        }
    }
}
