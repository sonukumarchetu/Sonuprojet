using Sonuprojet.Models.View_Models;
using Sonuprojet.Utils.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sonuprojet.Respository.Interface
{
    public interface IAccount
    {
        RegisterEnum register(RegisterViewModel model);
        LoginEnum login(LoginViewModel model);
            
    }
}
