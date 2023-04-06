using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class EntityDers
    {
        private string dersad;
        public string DERSAD
        {
            get
            { return DersAd; }

            set
            { DersAd = value; }
        }


        private int min;
        public int MİN
        {
            get
            {
                return min;
            }

            set
            {
                min = value;
            }
        }

        private int max;
        public int MAX
        {
            get
            {
                return max;
            }

            set
            {
                max = value;
            }
        }


        private int dersid;
        public int DERSID
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

        
    }
}
