using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Project
{
    class UserValidationManager : IUserValidationService
    {
       

        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1998 && gamer.FirstName == "Feyza" && gamer.LastName == "Yılmaz" && gamer.IdentyNumber == 12)
            {
                return true;

            }
            else { return false; }

        }
    }
}
