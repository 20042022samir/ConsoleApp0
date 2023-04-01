using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Core.Models
{
    public abstract class Base
    {
        public string Name { get; set; }

        public int ID { get; set; }

        public DateTime Createdtime { get; set; }

        public DateTime Updatedtime { get; set;}
    }
}
