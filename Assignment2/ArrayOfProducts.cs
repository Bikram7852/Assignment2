using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class ArrayOfProducts
    {
        static void Main(string[] args)
        {
            products[] p = new products[5];
            p[0] = new products();
            //p[0].productid = 1;
            p[0].productname = "Mobile";
            p[0].price = 10000;
            p[0].UnitOfMeasurement = "pieces";
            p[0].quantity = 100;

            Console.WriteLine("Product 1:");
            Console.WriteLine(p[0].productid);
            Console.WriteLine(p[0].productname);
            Console.WriteLine(p[0].price);
            Console.WriteLine(p[0].UnitOfMeasurement);
            Console.WriteLine(p[0].quantity);
            Console.WriteLine("---------");

            p[1] = new products();
            //p[1].productid = 2;
            p[1].productname = "Laptop";
            p[1].price = 70000;
            p[1].UnitOfMeasurement = "pieces";
            p[1].quantity = 200;

            Console.WriteLine("Product 2:");
            Console.WriteLine(p[1].productid);
            Console.WriteLine(p[1].productname);
            Console.WriteLine(p[1].price);
            Console.WriteLine(p[1].UnitOfMeasurement);
            Console.WriteLine(p[1].quantity);
            Console.WriteLine("---------");

            p[2] = new products();
            //p[2].productid = 3;
            p[2].productname = "Charger";
            p[2].price = 500;
            p[2].UnitOfMeasurement = "pieces";
            p[2].quantity = 50;

            Console.WriteLine("Product 3:");
            Console.WriteLine(p[2].productid);
            Console.WriteLine(p[2].productname);
            Console.WriteLine(p[2].price);
            Console.WriteLine(p[2].UnitOfMeasurement);
            Console.WriteLine(p[2].quantity);
            Console.WriteLine("---------");

            p[3] = new products();
            //p[3].productid = 4;
            p[3].productname = "Mobile Cover";
            p[3].price = 200;
            p[3].UnitOfMeasurement = "pieces";
            p[3].quantity = 100;

            Console.WriteLine("Product 4:");
            Console.WriteLine(p[3].productid);
            Console.WriteLine(p[3].productname);
            Console.WriteLine(p[3].price);
            Console.WriteLine(p[3].UnitOfMeasurement);
            Console.WriteLine(p[3].quantity);
            Console.WriteLine("---------");

            p[4] = new products();
            //p[4].productid = 5;
            p[4].productname = "Keyboard";
            p[4].price = 500;
            p[4].UnitOfMeasurement = "pieces";
            p[4].quantity = 150;

            Console.WriteLine("Product 5:");
            Console.WriteLine(p[4].productid);
            Console.WriteLine(p[4].productname);
            Console.WriteLine(p[4].price);
            Console.WriteLine(p[4].UnitOfMeasurement);
            Console.WriteLine(p[4].quantity);
            Console.WriteLine("---------");

            Console.ReadLine();
        }
    }
}
