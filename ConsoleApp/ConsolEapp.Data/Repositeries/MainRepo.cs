using ConsoleApp.Core.InterfacesRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Data.Repositeries
{
    public class MainRepo<W> : IMainRepo<W>
    {
        public List<W> products= new List<W>();
        public void Create(W data)
        {
            products.Add(data);
        }

        public void Delete(W data)
        {
            products.Remove(data);
        }

        public W Get(Func<W, bool> expression)
        {
            W info=products.FirstOrDefault(expression);
            return info;
        }

        public List<W> GetAll()
        {
            return products;
        }
    }
}
