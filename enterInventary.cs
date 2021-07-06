using System;
using System.Collections.Generic;
using System.Text;

namespace Invertapp
{
    class enterInventary : MENUSS
    {

        public void Menus()
        {

            int i = 1; foreach (productos Product in Repositorio.Instancia.ListProducts)
            {
                Console.WriteLine($"{i}- Nombre: {Product.ProN}   Cantidad:  {Product.CantProd}");
                i++;
            }

            Console.WriteLine("Seleccione el producto quiere entrar: ");
            int INPro = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cuanto desea añadir: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

  productos Prodc = new productos(Repositorio.Instancia.ListProducts[INPro - 1].ProN,
  Repositorio.Instancia.ListProducts[INPro - 1].ProPrice, Repositorio.Instancia.ListProducts[INPro - 1].Cat);

            Prodc.CantProd = Repositorio.Instancia.ListProducts[INPro - 1].CantProd + cantidad;

            Repositorio.Instancia.ListProducts[INPro - 1] = Prodc;
            Console.WriteLine("Se agrego correctamente");
            Console.ReadKey();
        }
    }
}
