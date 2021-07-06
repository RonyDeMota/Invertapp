using System;
using System.Collections.Generic;
using System.Text;

namespace Invertapp
{
   public class productos
    {
        public string ProN { get; set; }
        public double ProPrice { get; set; }
        public string Cat { get; set; }
        public productos(string nombrePro, double precioPro, string categ)
        {
            this.ProN = nombrePro;
            this.ProPrice = precioPro;
            this.Cat = categ;
        }
     
        public int CantProd { get; set; }

    }
}
