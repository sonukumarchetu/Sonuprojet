using Sonuprojet.Models;
using Sonuprojet.Models.View_Models;
using Sonuprojet.Respository.Interface;
using Sonuprojet.Utils.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sonuprojet.Respository.Service
{
    public class AccountService:IAccount
    {
        private readonly ApplicationDbcontext dbcontext;

        public AccountService(ApplicationDbcontext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public LoginEnum login(LoginViewModel model)
        {
            var user = dbcontext.users.SingleOrDefault(e => e.Email == model.Email && e.Password == model.Password);
            if (user!= null)
            {
                if (user.Isveryfied == true)
                {
                    return LoginEnum.Success;
                }
                else
                {
                    return LoginEnum.NoteVarified;
                }
                
            }
            else
            {
                return LoginEnum.Failure;
            }
        }

        public RegisterEnum register(RegisterViewModel model)
        {
            try
            {
                if (dbcontext.users.Any(e => e.Email == model.Email))
                {
                    return RegisterEnum.EmailExist;
                }
                else if (dbcontext.users.Any(e => e.Mobile == model.Mobile))
                {
                    return RegisterEnum.MobileExist;
                }
                else
                {
                    var user = new Users()
                    {
                        Name = model.Name,
                        Email = model.Email,
                        Mobile = model.Mobile,
                        Password = model.Password
                    };
                    dbcontext.users.Add(user);
                    dbcontext.SaveChanges();
                    return RegisterEnum.Success;
                }
            }
            catch (Exception e)
            {
                return RegisterEnum.Failure;
            }


        } 
        }
    }

