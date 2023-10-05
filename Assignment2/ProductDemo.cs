using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class ProductDemo
    {
        static void Main(string[] args)
        {
            products p1 = new products();
            //p1.productid = 1;
            p1.productname = "Mobile";
            p1.price = 10000;
            p1.UnitOfMeasurement = "pieces";
            p1.quantity = 100;

            Console.WriteLine("Product 1:");
            Console.WriteLine(p1.productid);
            Console.WriteLine(p1.productname);
            Console.WriteLine(p1.price);
            Console.WriteLine(p1.UnitOfMeasurement);
            Console.WriteLine(p1.quantity);
            Console.WriteLine("---------");

            products p2 = new products();
            //p2.productid = 2;
            p2.productname = "Laptop";
            p2.price = 70000;
            p2.UnitOfMeasurement = "pieces";
            p2.quantity = 200;

            Console.WriteLine("Product 2:");
            Console.WriteLine(p2.productid);
            Console.WriteLine(p2.productname);
            Console.WriteLine(p2.price);
            Console.WriteLine(p2.UnitOfMeasurement);
            Console.WriteLine(p2.quantity);
            Console.WriteLine("---------");

            products p3 = new products();
            //p3.productid = 3;
            p3.productname = "Charger";
            p3.price = 500;
            p3.UnitOfMeasurement = "pieces";
            p3.quantity = 50;

            Console.WriteLine("Product 3:");
            Console.WriteLine(p3.productid);
            Console.WriteLine(p3.productname);
            Console.WriteLine(p3.price);
            Console.WriteLine(p3.UnitOfMeasurement);
            Console.WriteLine(p3.quantity);
            Console.WriteLine("---------");

            products p4 = new products();
            //p4.productid = 4;
            p4.productname = "Mobile Cover";
            p4.price = 200;
            p4.UnitOfMeasurement = "pieces";
            p4.quantity = 100;

            Console.WriteLine("Product 4:");
            Console.WriteLine(p4.productid);
            Console.WriteLine(p4.productname);
            Console.WriteLine(p4.price);
            Console.WriteLine(p4.UnitOfMeasurement);
            Console.WriteLine(p4.quantity);
            Console.WriteLine("---------");

            products p5 = new products();
            //p5.productid = 5;
            p5.productname = "Keyboard";
            p5.price = 500;
            p5.UnitOfMeasurement = "pieces";
            p5.quantity = 150;

            Console.WriteLine("Product 5:");
            Console.WriteLine(p5.productid);
            Console.WriteLine(p5.productname);
            Console.WriteLine(p5.price);
            Console.WriteLine(p5.UnitOfMeasurement);
            Console.WriteLine(p5.quantity);
            Console.WriteLine("---------");

            Console.ReadLine();
        }
    }
}
