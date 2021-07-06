using System;
using System.Collections.Generic;
using System.Text;

namespace Invertapp 
{
    class Submenu : MENUSS
    {
        public void Menus()
        {
            try {
                MenuPrincipal Menu = new MenuPrincipal();
                servicioCategory serviCat = new servicioCategory();
                Console.Clear();
                Console.WriteLine("1-Agregar categoría\n2-Editar categoría\n3-Eliminar categoría\n4-Listar categorías\n5-Volver atrás");
                Console.WriteLine("Seleccione una opcion: ");
                int SM1 = Convert.ToInt32(Console.ReadLine());
                switch (SM1)
                {
                    case (int)OpcionesMantenimiento.AGREGAR:
                        Console.Clear();
                        serviCat.AddCat();
                        break;
                    case (int)OpcionesMantenimiento.EDITAR:
                        Console.Clear();
                        serviCat.editCat();
                        break;
                    case (int)OpcionesMantenimiento.ELIMINAR:
                        Console.Clear();
                        serviCat.deleteCat();
                        break;
                    case (int)OpcionesMantenimiento.LISTAR:
                        Console.Clear();
                        serviCat.listCat();
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
