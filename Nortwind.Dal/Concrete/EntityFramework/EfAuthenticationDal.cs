using Nortwind.Dal.Abstract;
using Nortwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.Dal.Concrete.EntityFramework
{
    public class EfAuthenticationDal : IAuthenticationDal
    {
        
        public User Authenticate(User user)
        {
            //Veritabanindan Alinmis Gibi Varsayiyoruz.
            if(user.Username == "Serkan" && user.Password == "1234")
            {
                return user;
            }

            return null;

        }
    }
}
