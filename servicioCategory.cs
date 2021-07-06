using System;
using System.Collections.Generic;
using System.Text;

namespace Invertapp
{
    public class servicioCategory
    {
     
       
        public void AddCat() {
            Console.WriteLine("Ingrese la Categoria");
            string NomCat = Console.ReadLine();

            categoria NewCat = new categoria(NomCat);

           Repositorio.Instancia.ListCategories.Add(NewCat);

            Console.WriteLine("Se agrego la categoria");
            Console.ReadKey();
        }


        public void editCat() {
            listCat();
            Console.WriteLine("Selecctione la categoria que quiere editar");
            int edt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la nueva Categoria");
           string editar = Console.ReadLine();

            Repositorio.Instancia.ListCategories[edt - 1].CatN = editar;
            Console.WriteLine("Se edito la categoria");
            Console.ReadKey();
        }       
        public void deleteCat() {

            listCat();

            Console.WriteLine("Selecctione la categoria que quiere Borrar");
            int dele = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Estás seguro de eliminar esa categoria: S/N ? ");
            string SiNo = Console.ReadLine();


            if (SiNo=="s"||SiNo=="S")
            {
                Repositorio.Instancia.ListCategories.RemoveAt(dele - 1);
                Console.WriteLine("Se elimino una categoria");
                Console.ReadKey();
            }
            else
            {
                deleteCat();
            }
        }
        public void listCat() {
            int con = 1;
            foreach (categoria categoria in Repositorio.Instancia.ListCategories) {
                Console.WriteLine($"{con}- {categoria.CatN}");
                con++;
            }
        }

    }
}
