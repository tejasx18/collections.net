using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    public class Product2 : IComparable<Product2>
    {
        private string name;
        private double price;

        public double Price
        {
            get { return price; }

        }

        public Product2(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public int CompareTo(Product2 p)
        {
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
            return name + "," + Price;
        }
    }

    public class CheckPrice2 : IComparer<Product2>
    {
        public int Compare(Product2 p1, Product2 p2)
        {
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
    internal class genericcollection
    {
        //static void Main(string[] args)
        //{
        //    Product2 p1 = new Product2("laptop", 80000);
        //    Product2 p2 = new Product2("PC", 50000);
        //    Console.WriteLine("using IComparable " + p1.CompareTo(p2));

        //    CheckPrice2 cp = new CheckPrice2();
        //    Console.WriteLine("using IComparer "+cp.Compare(p1,p2));

        //    Console.WriteLine();
        //    Console.WriteLine();

        //    List<int> list = new List<int>();
        //    list.Add(111);
        //    list.Add(22);
        //    list.Add(31);
        //    list.Add(14);
        //    list.Add(5);
        //    list.AddRange(new int[] { 22, 1122, 33 });
        //    list.Remove(22);
        //    list.RemoveAt(list.Count-1);
        //    foreach (int i in list)
        //    {
        //        Console.Write(i+" ");
        //    }
        //    Console.WriteLine();
        //    list.Sort();
        //    foreach (int i in list)
        //    {
        //        Console.Write(i+" ");
        //    }
        //    Console.WriteLine();
        //    list.Reverse();
        //    foreach (int i in list)
        //    {
        //        Console.Write(i + " ");
        //    }
        //    Console.WriteLine();
        //    Console.WriteLine();
        //    Console.WriteLine();


        //    //Use of List<Product>  create & display

        //    List<Product> products = new List<Product>();
        //    products.Add(new Product("laptop", 10000));
        //    products.Add(new Product("mouse", 300));
        //    products.Add(new Product("keyboard", 1000));
        //    products.Add(new Product("speaker", 500));

        //    foreach(Product product in products) { Console.WriteLine(product); }
        //    Console.WriteLine();
        //    products.Sort();
        //    foreach (Product product in products) { Console.WriteLine(product); }
        //    Console.WriteLine();
        //    products.Reverse();
        //    foreach (Product product in products) { Console.WriteLine(product); }
        //    Console.WriteLine();
        //    products.RemoveAt(1);
        //    products.Remove(products[2]);
        //    foreach (Product product in products) { Console.WriteLine(product); }
        //    Console.WriteLine();
        //    Console.WriteLine();
        //    Console.WriteLine();

        //    //stack
        //    Stack<int> stack = new Stack<int>();
        //    stack.Push(1);
        //    stack.Push(2);
        //    stack.Push(3);
        //    stack.Push(4);
        //    foreach (var i in stack) { Console.Write(i+" "); }
        //    Console.WriteLine();
        //    Console.WriteLine(stack.Peek());
        //    Console.WriteLine(stack.Pop());
        //    Console.WriteLine(stack.Pop());
        //    foreach (var i in stack) { Console.Write(i + " "); }
        //    Console.WriteLine();
        //    Console.WriteLine();
        //    Console.WriteLine();

        //    //Queue
        //    Queue<int> queue = new Queue<int>();
        //    queue.Enqueue(1);
        //    queue.Enqueue(2);
        //    queue.Enqueue(3);
        //    queue.Enqueue(4);
        //    queue.Enqueue(5);
        //    foreach (var i in queue) { Console.Write(i + " "); }
        //    Console.WriteLine();
        //    Console.WriteLine(queue.Peek());
        //    Console.WriteLine(queue.Dequeue());
        //    foreach (var i in queue) { Console.Write(i + " "); }
        //    Console.WriteLine();
        //    Console.WriteLine();
        //    Console.WriteLine();

        //    // dictionary
        //    Dictionary<int,string> dict = new Dictionary<int,string>();
        //    dict.Add(1, "tejas");
        //    dict.Add(5, "omkar");
        //    dict.Add(7, "prathamesh");
        //    dict.Add(2, "suraj");
           
        //    foreach (var item in dict)
        //    {
        //        Console.WriteLine(item.Key + "  " + item.Value);
        //    }
        //    Console.WriteLine();
        //    IEnumerable ier = dict.Reverse();
        //    foreach (KeyValuePair<int, string> i in ier)
        //    {
        //        Console.WriteLine(i.Key + "  " + i.Value);
        //    }
        //    Console.WriteLine();
        //    Console.WriteLine();


        //    SortedList<int, string> slist = new SortedList<int, string>();
        //    slist.Add(1, "tejas");
        //    slist.Add(5, "omkar");
        //    slist.Add(7, "prathamesh");
        //    slist.Add(2, "suraj");
        //    foreach (var item in slist)
        //    {
        //        Console.WriteLine(item.Key + "  " + item.Value);
        //    }
        //    slist.Remove(1);
        //    Console.WriteLine(slist.ContainsKey(1));
        //    Console.WriteLine(slist.ContainsValue("omkar"));
            

        //}
    }
}
