using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RetroShirt.Business.Abstract;
using RetroShirt.Business.Concrete;
using RetroShirtDtos.Responses;
using RetroShirtEntities;
using RetroShirtWeb.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RetroShirtWeb.Controllers
{
    public class UsersController : Controller
    {
        private IUserService userService;
        public IMailService mailService;

        public UsersController(IUserService userService,IMailService mailService)
        {
            this.userService = userService;
            this.mailService = mailService;
            
        }

        public IActionResult Index()
        {          
            return View();
        }

        public IActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        

        [HttpPost]
        public async Task<IActionResult> Login(UserModel userModel,string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = userService.GetUser(userModel.Username, userModel.Password);
                
                if (user != null)
                {
                    
                    List<Claim> claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, user.Username),
                        new Claim(ClaimTypes.Email, user.Email),
                        new Claim(ClaimTypes.Role, user.Role),
                    };

                    ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);
                    await HttpContext.SignInAsync(claimsPrincipal);
                    

                    if (Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else if (returnUrl==null)
                    {
                        return Redirect("/");
                    }
                }
                ModelState.AddModelError("Login", "Incorrect username or password.");


            }

            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }

        public IActionResult Register()
        {         
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(User user)
        {
            var IsUser= userService.UserIsExist(user.Username,user.Email);
            if (ModelState.IsValid && IsUser!=true)
            {
                
                if (user.Role=="admin" || user.Role=="editor" || user.Role=="customer")
                {
                    await userService.CreateAccount(user);
                    mailService.sendMail(user);

                    TempData["mess"] = "Account created successfully";
                    return View();
                }             
                
            }
            TempData["mess"] = "E-mail or username already exist or invalid role entered.";
            return View();
        }

        public IActionResult AccessDenied(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        //public void sendMail(User user)
        //{
        //    MailMessage mailMessage = new MailMessage();          
        //    mailMessage.To.Add("netcoremail252.41@gmail.com");
        //    mailMessage.From = new MailAddress("netcoremail252.41@gmail.com");
        //    mailMessage.Subject = "RetroShirt Registration";
        //    mailMessage.Body = $"We are pleased to see you {user.Fullname} in our website. Thanks for your registration.";
        //    mailMessage.IsBodyHtml = true;

        //    SmtpClient smtpClient = new SmtpClient();
        //    smtpClient.UseDefaultCredentials = false;
        //    smtpClient.Credentials = new NetworkCredential("netcoremail252.41@gmail.com", "Netcoremail31.31");
        //    smtpClient.Port = 587;
        //    smtpClient.Host = "smtp.gmail.com";
        //    smtpClient.EnableSsl = true;
            

        //    smtpClient.Send(mailMessage);
        //}


    }
}
