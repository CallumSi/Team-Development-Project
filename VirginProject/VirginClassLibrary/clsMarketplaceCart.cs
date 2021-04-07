﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirginClassLibrary
{
    public class clsMarketplaceCart
    {

        List<clsMarketplaceCartItem> mProducts = new List<clsMarketplaceCartItem>();

        private Int32 mUserNo;
        public Int32 UserNo
        {
            get
            {
                return mUserNo;
            }
            set
            {
                mUserNo = value;
            }
        }

        private string mCardNo;
        public string CardNo
        {
            get
            {
                return mCardNo;
            }
            set
            {
                mCardNo = value;
            }
        }

        public List<clsMarketplaceCartItem> Products
        {
            get
            {
                return mProducts;
            }
        }

        public void Checkout()
        {
            //create an instance of the order class
            clsMarketplaceOrder Order = new clsMarketplaceOrder();
            //invoke the ProcessCart method
            Order.ProcessCart(this);
        }


    }
}
