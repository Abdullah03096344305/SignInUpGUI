using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignInUpWeek99.BL
{
    class Deals
    {
        private string dealName;
        private int dealPrice;
        public Deals(string dealName, int dealPrice)
        {
            this.dealName = dealName;
            this.dealPrice = dealPrice;
        }
        public string GetDealName()
        {
            return dealName;
        }
        public int GetDealPrice()
        {
            return dealPrice;
        }
       
    }
}
