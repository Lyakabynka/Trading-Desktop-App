using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Exam.Model
{
    public class Trade
    {
        public int Id { get; set; }

        public int ItemId { get; set; }
        public Item Item { get; set; }

        public int? SellerId { get; set; }
        public User? Seller { get; set; }


        public int? BuyerId { get; set; }
        public User? Buyer { get; set; }
    }
}
