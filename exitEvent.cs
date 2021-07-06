using System;
using System.Collections.Generic;
using System.Text;

namespace Invertapp
{
    class exitEvent : MENUSS
    {

        public void Menus()
        {
            try
            {
                int i = 1; foreach (productos Product in Repositorio.Instancia.ListProducts)
                {
                    Console.WriteLine($"{i}- Nombre: {Product.ProN}   Cantidad:  {Product.CantProd}");
                    i++;
                }

                Console.WriteLine("Seleccione el producto que quiere sacar");
                int cantidad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("ingrese la cantidad que quiere sacar");
                int ExitCant = Convert.ToInt32(Console.ReadLine());

                if (Repositorio.Instancia.ListProducts[cantidad - 1].CantProd >= ExitCant)
                {
                    productos producto = new productos(Repositorio.Instancia.ListProducts[cantidad - 1].ProN, 
                        Repositorio.Instancia.ListProducts[cantidad - 1].ProPrice, Repositorio.Instancia.ListProducts[cantidad - 1].Cat); ;
                    producto.CantProd = Repositorio.Instancia.ListProducts[cantidad - 1].CantProd - ExitCant;
                    Repositorio.Instancia.ListProducts[cantidad - 1] = producto;

                    Console.WriteLine("Se saco la cantidad deseada");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("La cantidad que quiere quitar es mas de las que hay");
                    Console.ReadKey();
                }
            }
            catch
            {
                Console.WriteLine("Ingrese un valor valido");
                Console.ReadKey();
            }
        }
    }
}
