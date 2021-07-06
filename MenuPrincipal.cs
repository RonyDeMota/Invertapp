using System;
using System.Collections.Generic;
using System.Text;

namespace Invertapp
{
   public class MenuPrincipal : MENUSS
    {
        public void Menus()
        {
            try
            {
                MENUSS menu;
       
                Console.Clear();
                Console.WriteLine("1-Mantenimientos de categorías\n2-Mantenimientos de productos\n3-Entrada de inventario\n4-Salida de inventario\n5-Salir");
                Console.WriteLine("Seleccione una opcion: ");
                
               int MP = Convert.ToInt32(Console.ReadLine());
                switch (MP)
                {
                    case 1:
                        menu = new Submenu();
                        menu.Menus();
                        Menus();
                        break;
                    case 2:
                       
                        menu = new Submenu2();
                        menu.Menus();
                        Menus();
                        break;
                    case 3:
                        Console.Clear();
                        menu = new enterInventary();
                        menu.Menus();
                        Menus();
                        break;
                    case 4:
                        Console.Clear();
                        menu = new exitEvent();
                        menu.Menus();
                        Menus();
                        break;
                    case 5:
                        Console.WriteLine("Gracias por usar el sistema");
                        Console.ReadKey();
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
