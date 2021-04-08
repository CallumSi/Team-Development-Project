using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirginClassLibrary
{
    class clsVMCartItem
    {
        public clsVMCartItem()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private Int32 mMovieID;
        public Int32 MovieID
        {
            get
            {
                return mMovieID;
            }

            set
            {
                mMovieID = value;
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
