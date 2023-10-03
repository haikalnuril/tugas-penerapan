using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_data
{
    abstract class katalog
    {
        //protected string nama;
        protected string type;

        public abstract void desc_class();

    }

    interface Action
    {
        void daftar_pustaka()
        {

        }
    }
}
