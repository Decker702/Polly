using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Polly.Models
{
    public class Purchase
    {
        public int PurchaseID { get; set; }
        public int CustomerID { get; set; }
        public int ProductID { get; set; }

        public virtual Customer Customer { get; set; }//Navagation
        public virtual Product Product { get; set; }
    }
}