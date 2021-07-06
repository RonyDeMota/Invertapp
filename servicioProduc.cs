using System;
using System.Collections.Generic;
using System.Text;

namespace Invertapp  
{
    class servicioProduc
    {
        public void AddProd()
        {
            Console.WriteLine("Cual es el nombre del producto: ");
            string nombrePro = Convert.ToString(Console.ReadLine());
                

                    Console.WriteLine("Cual es el precio del producto: ");
                    double precioPro = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Cual sera su categoria: ");
                    servicioCategory setCat = new servicioCategory();
            setCat.listCat();

           
                    int NumCat = Convert.ToInt32(Console.ReadLine());
                    string categ = Repositorio.Instancia.ListCategories[NumCat - 1].CatN;

            if (Repositorio.Instancia.ListCategories.Count > 0)
            {
                productos products = new productos(nombrePro, precioPro , categ);
                Repositorio.Instancia.ListProducts.Add(products);
                Console.WriteLine("Se agrego el Producto!");
            }
            else
            {
                Console.WriteLine("Primero agregue una categoria");
            }
        }

        public void EditProd()
        {
            Console.Clear();
            ListProd();
            Console.WriteLine("Cual es el  producto que desea editar: ");
            int cual = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cual es el nuevo nombre del producto: ");
            string nombreProedt = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Cual es el vuevo precio del producto: ");
            double precioProedt = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Cual sera nueva su categoria: ");
            servicioCategory setCatedt = new servicioCategory();
            setCatedt.listCat();


            int NumCatedt = Convert.ToInt32(Console.ReadLine());
            string categ = Repositorio.Instancia.ListCategories[NumCatedt - 1].CatN;



            if (Repositorio.Instancia.ListCategories.Count > 0)
            {
               productos editar = new productos(nombreProedt, NumCatedt, categ);
            Repositorio.Instancia.ListProducts[cual - 1] = editar;
            Console.WriteLine("Se edito la categoria");
            }
            else
            {
                Console.WriteLine("Primero agregue una categoria");
                Console.ReadKey();
            }



            
        }
        public void DeletProd()
        {
            Console.Clear();
            ListProd();
            Console.WriteLine("Selecctione la categoria que quiere Borrar");
            int deleP = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Estás seguro de eliminar esa categoria: S/N?");
            string SiNo = Console.ReadLine();
            if (SiNo == "s" || SiNo == "S")
            {
                Repositorio.Instancia.ListProducts.RemoveAt(deleP - 1);
                Console.WriteLine("Se elimino una categoria");
                Console.ReadKey();
            }
            else
            {
                DeletProd();
            }

        }
        public void ListProd()
        {
            int i = 1;
            foreach (productos Product in Repositorio.Instancia.ListProducts)
            {         
                Console.WriteLine($"{i}-Producto: {Product.ProN} Precio: {Product.ProPrice}  Categoria: {Product.Cat}");
                i++;

            } 
        }
    }
}
