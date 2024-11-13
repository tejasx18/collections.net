using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    public class Product3
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public override string ToString()
        {
            return $"{Id} , {Name} , {Price}";
        }
    }
    // Manage Product3s

    public class Product3CRUD
    {
        List<Product3> Product3s;
        public Product3CRUD()
        {
            Product3s = new List<Product3>(); // list is empty
        }

        public void AddProduct3(Product3 prod)
        {
            Product3s.Add(prod);
        }
        public void ModifyProduct3(Product3 prod)// prod obj contains new values
        {
            //1.iterate over collection, find that Product3 object & replace the values
            for (int i = 0; i < Product3s.Count; i++)
            {
                if (Product3s[i].Id == prod.Id)
                {
                    Product3s[i].Name = prod.Name;
                    Product3s[i].Price = prod.Price;
                    break;
                }
            }
        }
        public void DeleteProduct3(int id)
        {
            for (int i = 0; i < Product3s.Count; i++)
            {
                if (Product3s[i].Id == id)
                {
                    Product3s.Remove(Product3s[i]);
                    //Product3s.RemoveAt(i);
                    break;
                }
            }
        }
        public List<Product3> Product3List()
        {
            return Product3s;
        }

        public Product3 GetProduct3ById(int id)
        {
            Product3 p = new Product3();
            foreach (var item in Product3s)
            {
                if (item.Id == id)
                {
                    p.Id = item.Id;
                    p.Name = item.Name;
                    p.Price = item.Price;
                    break;
                }
            }
            return p;
        }

    }

    //public class Program
    //{

    //    static void Main(string[] args)
    //    {
    //        Product3CRUD crud = new Product3CRUD();
    //        try
    //        {
    //            int a = 1;
    //            do
    //            {
    //                Console.WriteLine("1.Product List");
    //                Console.WriteLine("2.Add Product");
    //                Console.WriteLine("3.Modify Product");
    //                Console.WriteLine("4.Delete Product");
    //                Console.WriteLine("5.Get Product By Id");
    //                Console.WriteLine("Select option from above");
    //                int op = Convert.ToInt32(Console.ReadLine());

    //                switch (op)
    //                {
    //                    case 1:
    //                        List<Product3> products = crud.Product3List();
    //                        Console.WriteLine("Id    Name    Price");
    //                        foreach (var item in products)
    //                        {
    //                            Console.WriteLine(item);
    //                        }
    //                        break;
    //                    case 2:
    //                        Product3 p1 = new Product3();
    //                        Console.WriteLine("Enter Id");
    //                        p1.Id = Convert.ToInt32(Console.ReadLine());
    //                        Console.WriteLine("Enter Name");
    //                        p1.Name = Console.ReadLine();
    //                        Console.WriteLine("Enter Price");
    //                        p1.Price = Convert.ToInt32(Console.ReadLine());
    //                        crud.AddProduct3(p1);
    //                        Console.WriteLine("Added the product");
    //                        break;
    //                    case 3:
    //                        Product3 p2 = new Product3();
    //                        Console.WriteLine("Enter existing Id");
    //                        p2.Id = Convert.ToInt32(Console.ReadLine());
    //                        Console.WriteLine("Enter new Name");
    //                        p2.Name = Console.ReadLine();
    //                        Console.WriteLine("Enter new Price");
    //                        p2.Price = Convert.ToInt32(Console.ReadLine());
    //                        crud.ModifyProduct3(p2);
    //                        Console.WriteLine("updated the product");
    //                        break;
    //                    case 4:
    //                        Console.WriteLine("Enter existing Id to delete");
    //                        int id = Convert.ToInt32(Console.ReadLine());
    //                        crud.DeleteProduct3(id);
    //                        Console.WriteLine("Deleted the product");
    //                        break;
    //                    case 5:
    //                        Console.WriteLine("Enter existing Id");
    //                        int id2 = Convert.ToInt32(Console.ReadLine());
    //                        Product3 p = crud.GetProduct3ById(id2);
    //                        Console.WriteLine(p);
    //                        break;
    //                }
    //                Console.WriteLine("Press 1 for continue or 0 to exit");
    //                a = Convert.ToInt32(Console.ReadLine());
    //            }

    //            while (a == 1);

    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine(ex.Message);
    //        }
    //    }
    //}


}
