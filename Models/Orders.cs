using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace zw205715_MIS4200.Models
{
    public class Orders
    {
        public int orderID { get; set; }

        public int customerID { get; set; }
        public Customer customer { get; set; }

        public DateTime orderDate { get; set; }

    }
}