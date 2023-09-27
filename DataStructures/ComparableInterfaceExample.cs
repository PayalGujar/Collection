using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Product:IComparable
    {
        private string name;
        private float price;

        public Product(string name, float price)
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
            return $"{name}={price}";
        }
    }
    public class ComparableInterfaceExample
    {
        public static void Main(string[] args)
        {


            Product p1 = new Product("Book", 2000);
            Product p2 = new Product("Pen", 200);

            int result = p2.CompareTo(p1);//p2=Pen and p1=Book
            if(result==1)
            {
                Console.WriteLine("Price is Greater");
            }else if(result==-1) 
            {
                Console.WriteLine("Price is less");
            }
            else if(result==0)
            {
                Console.WriteLine("Price is equal");
            }


        }
    }
}
