using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShppingCart.Models
{
    public class MobileProduct : Product
    {

        protected int id;
        protected String image;
        protected String name;
        protected String type;
        protected double price;

        public MobileProduct()
        {
          
        }

        public int ID
        {
            get

            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        
        public String Name
        {
            get
            {
                return name;
            }
            set

            {
                name = value;
            }
        }

        public String Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
            }
        }

        public String Type
        {
            get
            {
                return type;
            }
            set
            {
                type = "Mobile";
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public String GetInfo()
        {
            return "Product" +  name + "Type" + type +  "";
        }

        public String Search(string id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            string name = db.Products.Find(id).name;
            return "prouct is: " + 
                       name + " searched.";
        }

        public String PriceCoin()
        {
            return "$";
        }
    }
}