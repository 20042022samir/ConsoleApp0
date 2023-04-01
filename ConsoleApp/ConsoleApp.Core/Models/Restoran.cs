using ConsoleApp.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Core.Models
{
    public sealed class Restoran:Base
    {
        private static int _counter = 0;

        public CategoryRestoran category { get; set; }

        public List<Product> Menu;

        public Restoran()
        {
            _counter++;
            ID = _counter;
            Menu=new List<Product>();
        }

       
    }
}
