//using System.Net.Mail;
//using System.Security.Claims;

//namespace ConsoleApp1;

//public class ClaimMistery
//{
//    static void Main(string[] args)
//    {
//        //Claim
        
       
       

//        Claim nameClaim = new Claim(ClaimTypes.Email, "Vishnu@121212");
//        Claim emailClaim = new Claim(ClaimTypes.Email, "johndoe@example.com");

//        ClaimsIdentity? claimsIdentity = new ClaimsIdentity(new[] { nameClaim, emailClaim }, "custom");


//        ClaimsPrincipal? claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

//        var x = claimsPrincipal.Claims.ToList();

//        var y = claimsPrincipal.Identity;
//    }
//}

//class Helper
//{
//    public bool ValidateEmail(string email)
//    {
//        try
//        {

//            MailAddress mailAddress = new MailAddress(email);
//            return true;
//        }
//        catch (Exception)
//        {

//            return false;
//        }
//    }
//}
