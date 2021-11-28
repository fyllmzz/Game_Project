using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Project
{
    class OrderManager : IOrderService
    {
        ICampaignService campaignService;

        public OrderManager(ICampaignService campaignService)
        {
            this.campaignService = campaignService;
        }

        public void Add(Order order)
        {
       
                Console.WriteLine("başarılı");
         
        }

       
    }
}
