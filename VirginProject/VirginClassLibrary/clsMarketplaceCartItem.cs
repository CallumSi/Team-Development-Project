﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirginClassLibrary
{
    public class clsMarketplaceCartItem
    {

  
        public clsMarketplaceCartItem()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        //getters/ setters for the class

        private Int32 mProductID;
        public Int32 ProductID
        {
            get
            {
                return mProductID;
            }

            set
            {
                mProductID = value;
            }
        }

        private Int32 mQTY;
        public Int32 QTY
        {
            get
            {
                return mQTY;
            }

            set
            {
                mQTY = value;
            }
        }


    }
}
