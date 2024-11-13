using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    public class Player : IComparable
        {
            private int runs;
            private string name;
            public Player(int runs, string name)
            {
                this.runs = runs;
                this.name = name;
            }
            public int Runs
            {
                get { return runs; }
            }
            public int CompareTo(object obj) // obj = virat
            {
                // runs of virat is in the obj object, need typecasting to get data
                Player p1 = (Player)obj; // virat's object assign to p1
                                         // this points to current object ie. object of rohit
                if (this.runs > p1.runs)
                {
                    return 1;
                }
                else if (this.runs < p1.runs)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }

            public override string ToString()
            {
                return $" Name={name} , Runs= {runs}";
            }
    }
    public class Team : IEnumerable
        {
            Player[] player;
            public Team()
            {
                player = new Player[3];
                player[0] = new Player(70, "Rohit");
                player[1] = new Player(50, "Virat");
                player[2] = new Player(35, "Dhoni");
            }

            public IEnumerator GetEnumerator()
            {
                return player.GetEnumerator();
            }
    }
    public class CheckRuns : IComparer
    {
        public int Compare(object x, object y)
        {
            Player p1 = (Player)x;
            Player p2 = (Player)y;
            if (p1.Runs > p2.Runs)
            {
                return 1;
            }
            else if (p1.Runs < p2.Runs)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
    public class Product:IComparable 
    { 
        private string name;
        private double price;

        public double Price
        {
            get { return price; }

        }

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public int CompareTo(object obj)
        {
            Product p = (Product)obj;
            if (this.price > p.price)
            {
                return 1;
            }
            else if (this.price < p.price)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        public override string ToString()
        {
            return name+","+Price;
        }
    }
    public class ProductList : IEnumerable
    {
        private Product[] p;

        public ProductList(Product[] p) { 
            this.p = p;
        }
        public IEnumerator GetEnumerator()
        {
            return p.GetEnumerator();
        }
    }
    public class CheckPrice : IComparer
    {
        public int Compare(object x, object y)
        {
            Product p1 = (Product)x;
            Product p2 = (Product)y;
            if (p1.Price > p2.Price)
            {
                return 1;
            }
            else if (p1.Price < p2.Price)
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }
    }
    //public class DemoMain
    //{
    //    static void Main(string[] args)
    //    {
    //        Product p1 = new Product("laptop", 80000);
    //        Product p2 = new Product("PC", 50000);

    //        Product[] p = new Product[] { p1, p2 };
    //        ProductList pl = new ProductList(p);
    //        foreach (Product pr in pl)
    //        {
    //            Console.WriteLine(pr);
    //        }


    //        Console.WriteLine("using IComparable "+p1.CompareTo(p2));

    //        CheckPrice cp = new CheckPrice();
    //        Console.WriteLine("using IComparer "+cp.Compare(p1,p2));

    //    }
    //}
}