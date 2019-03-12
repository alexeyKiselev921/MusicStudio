using MusicStudio.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStudio.API.Interfaces
{
    interface ILoginController
    {
        void SignIn(User user);
        bool TrySignIn(User user);
        void SignUp();
        bool TrySignUp();
    }
}
