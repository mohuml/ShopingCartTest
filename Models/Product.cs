using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShppingCart.Models
{
    public interface Product
    {
        /// <summary>
        /// Interface properities 
        /// </summary>
        int id
        {
            get;
            set;
        }

        String name
        {
            get;
            set;
        }

        String image
        {
            get;
            set;
        }

        String type
        {
            get;
            set;
        }
        double price
        {
            get;
            set;
        }

        /// <summary>
        /// Interface methods
        /// </summary>
        /// <returns></returns>
        String GetInfo();
        String Search(string id);
        String PriceCoin();
    }
}