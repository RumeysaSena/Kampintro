using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {

        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1994 && gamer.FirstName == "SENA" && gamer.LastName=="ÖZDEMİR" && gamer.IdentityNumber==12345)
            {
                return true;
            }
            else
            {
                return false; 
            }
        }
    }
}
