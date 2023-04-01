using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Service.ServiceInterface
{
    public interface IRestoranService
    {
        public void Create();

        public void Update();

        public void Delete();

        public void Get();

        public void GetAll();
    }
}
