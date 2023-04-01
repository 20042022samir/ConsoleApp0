using ConsoleApp.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Core.Models
{
    public sealed class Product:Base
    {
        public double Price { get; set; }

        public CategoryProduct Category { get; set; }

        private static int _counter2 = 0;

        public Product()
        {
            _counter2++;
            ID = _counter2;
        }
    }
}
