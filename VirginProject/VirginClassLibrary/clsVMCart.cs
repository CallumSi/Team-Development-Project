﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirginClassLibrary
{
    public class clsVMCart
    {
        List<clsVMCartItem> mMovies = new List<clsVMCartItem>();

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

        public List<clsVMCartItem> Movies
        {
            get
            {
                return mMovies;
            }
        }

        public void Checkout()
        {
            //create an instance of the order class
            clsVMOrder Order = new clsVMOrder();
            //invoke the ProcessCart method
            Order.ProcessCart(this);
        }
    }
}
