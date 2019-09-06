using Nortwind.Dal.Concrete.EntityFramework;
using Nortwind.Dll.Concrete;
using Nortwind.Entities;
using Nortwind.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.WCFLibrary.Concrete
{
    class AuthenticationService : IAuthenticationService
    {
        //Servislerin Kurucu Metodlari Genelde Olmaz
        //Instance Provider ile olabiliyor.
        IAuthenticationService authenticationService = new AuthenticationManager(new EfAuthenticationDal());
        public User Authenticate(User user)
        {
            return authenticationService.Authenticate(user);
        }
    }
}
