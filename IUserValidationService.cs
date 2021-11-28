using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Project
{
    internal interface IUserValidationService  //Doğrulama SERVİSİ
    {
        bool Validate(Gamer gamer);

    }
}
