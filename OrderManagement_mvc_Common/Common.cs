using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderManagement_mvc_Common
{
    public class Common
    {
        public enum OrderStatus
        {
            pending,
            approved,
            active,
            ordered,
            intransit,
            delivered

        }
    }
}