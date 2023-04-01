using ConsoleApp.Core.InterfacesRepo;
using ConsoleApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Data.Repositeries
{
    public class RestoranRepo<restoran>:MainRepo<Restoran>,IGroupRepo<Restoran>
    {
    }
}
