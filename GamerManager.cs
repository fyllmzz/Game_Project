using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Project
{
    class GamerManager : IGamerService
    {
        //bir manager sınıfı içinde başka bir manager sınıfı kullanacaksan onu new leme.//
        // constructor oluştur....

        IUserValidationService _userValidationService; //ampulden generic constructor de.

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt Oldu.");
            }
            else { Console.WriteLine("doğrulama başarısız."); }
           
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi..");
        }
    }
}
