using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Project
{
    class NewEStateUserValidationManager : IUserValidationService  //yeni e devlet sistemi ekledim

    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
