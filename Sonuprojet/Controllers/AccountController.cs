using Microsoft.AspNetCore.Mvc;
using Sonuprojet.Models.View_Models;
using Sonuprojet.Respository.Interface;
using Sonuprojet.Utils.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sonuprojet.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccount accountService;

        public AccountController(IAccount AccountService)
        {
            accountService = AccountService;
        }
        public IActionResult Iogin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Iogin(LoginViewModel model)
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = accountService.register(model);
                if (result == RegisterEnum.Success)
                {
                    return RedirectToAction("VerifyAccount");
                }
                else if (result == RegisterEnum.EmailExist)
                {
                    ModelState.AddModelError(string.Empty,"Email already register!");
                }
                else if (result == RegisterEnum.MobileExist)
                {
                    ModelState.AddModelError(string.Empty, "Mobile already register!");
                }
                else if (result == RegisterEnum.Failure)
                {
                    ModelState.AddModelError(string.Empty, "registration not done,somting went worng!");
                }
                return View();
            }
            else
            {
                return View(model);
            }
        }
       public IActionResult VaerifyAccount()
        {
            return View();
        } 
    }
}
    
       
    


    

    

