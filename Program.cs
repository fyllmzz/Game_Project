using System;

namespace Game_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamermanager = new GamerManager(new UserValidationManager());
            gamermanager.Add(new Gamer { Id=1, FirstName="Feyza", LastName="Yılmaz",BirthYear=1998,IdentyNumber=12});

            gamermanager.Add(new Gamer { Id = 1, FirstName = "Feyza", LastName = "yıldız", BirthYear = 1998, IdentyNumber = 12 });



            GamerManager gamerManager2 = new GamerManager(new UserValidationManager());
            gamerManager2.Add(new Gamer { Id = 1, FirstName = "Feyza", LastName = "Yılmaz", BirthYear = 1998, IdentyNumber = 12 });

            gamerManager2.Add(new Gamer { Id = 1, FirstName = "Feyza", LastName = "yıldız", BirthYear = 1998, IdentyNumber = 12 });

            CampaignManager campaign = new CampaignManager();
            campaign.Add(new Campaign { Id = 1, CampaignName = "black friday" });

            OrderManager orderManager = new OrderManager(new CampaignManager());
            orderManager.Add(new Order { Id = 1, OrderName = "satış" });







        }
    }
}
