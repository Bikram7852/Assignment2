using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class products
    {
        private static int _lastProductid=0;
        private string _productname;
        private decimal _price;
        private string _UnitOfMeasurement;
        private int _quantity;

        public int productid
        {
            get;
        }

        public products()
        {
            _lastProductid++;
            productid = _lastProductid;
        }

        public string productname
        {
            get { return _productname; }

            set { _productname = value; }
        }

        public decimal price
        {
            get { return _price; }

            set { _price = value; }
        }

        public string UnitOfMeasurement
        {
            get { return _UnitOfMeasurement; }

            set { _UnitOfMeasurement = value; }
        }

        public int quantity
        {
            get { return _quantity; }

            set { _quantity = value; }
        }
    }
}
