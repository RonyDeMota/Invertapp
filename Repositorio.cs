using System;
using System.Collections.Generic;
using System.Text;

namespace Invertapp
{
   public sealed class Repositorio
    {

        public static Repositorio Instancia { get; } = new Repositorio();

       public List<categoria> ListCategories { get; set; } = new List<categoria>();

        public List<productos> ListProducts { get; set; } = new List<productos>();

        private Repositorio()
        {

        }

    }
}
