using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class EntityBasvuruForm
    {
        private int basid;
        private int basdersid;
        private int basogrid;

        public int BASID
        {
            get
            {
                return basid;
            }

            set
            {
                basid = value;
            }
        }

        public int BASDERSID
        {
            get
            {
                return basdersid;
            }

            set
            {
                basdersid = value;
            }
        }

        public int BASOGRID
        {
            get
            {
                return basogrid;
            }

            set
            {
                basogrid = value;
            }
        }
    }
}
