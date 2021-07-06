using System;
using System.Collections.Generic;
using System.Text;

namespace Invertapp
{
   public class Submenu2 : MENUSS
    {
        public void Menus()
        {
            try
            {
                MenuPrincipal Menu = new MenuPrincipal();
                servicioProduc serviProd = new servicioProduc();
                Console.Clear();
                Console.WriteLine("1-Agregar producto\n2-Editar producto\n3-Eliminar producto\n4-Listar producto\n5-Volver atrás");
                Console.WriteLine("Seleccione una opcion: ");
                int SM2 = Convert.ToInt32(Console.ReadLine());
                switch (SM2)
                {
                    case (int)OpcionesMantenimiento.AGREGAR:
                        serviProd.AddProd();
                        Console.ReadKey();
                        break;
                    case (int)OpcionesMantenimiento.EDITAR:
                        serviProd.EditProd();
                        Console.ReadKey();
                        break;
                    case (int)OpcionesMantenimiento.ELIMINAR:
                        serviProd.DeletProd();
                        Console.ReadKey();
                        break;
                    case (int)OpcionesMantenimiento.LISTAR:
                        serviProd.ListProd();
                        Console.ReadKey();
                        break;
                    case (int)OpcionesMantenimiento.VOLVER: 
                        Console.ReadKey();  
                        Menu.Menus();
                        break;
                    default:
                        Console.WriteLine("Seleccione una opcion valida");
                        Console.ReadKey();
                        Menus();
                        return;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Ingrese un valor valido");
                Console.ReadKey();
                Menus();
            }

        }
    }
}
