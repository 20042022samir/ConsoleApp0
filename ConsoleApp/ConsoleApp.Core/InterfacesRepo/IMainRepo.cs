using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Core.InterfacesRepo
{
    public interface IMainRepo<W>
    {
        public void Create(W data);

        public W Get(Func<W,bool> expression );

        public List<W> GetAll();

        public void Delete(W data);
    }
}
