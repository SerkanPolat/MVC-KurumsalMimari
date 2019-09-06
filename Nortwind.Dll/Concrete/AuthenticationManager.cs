using Nortwind.Dal.Abstract;
using Nortwind.Entities;
using Nortwind.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.Dll.Concrete
{
    public class AuthenticationManager : IAuthenticationService
    {
        IAuthenticationDal authenticationDal;
        public AuthenticationManager(IAuthenticationDal authenticationDal)
        {
            this.authenticationDal = authenticationDal;
        }
        public User Authenticate(User user)
        {
            

            return authenticationDal.Authenticate(user); 
        }
    }
}
