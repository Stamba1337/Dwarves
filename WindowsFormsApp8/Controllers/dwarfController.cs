using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp8.Models;

namespace WindowsFormsApp8.Controllers
{
    class dwarfController
    {
        public List<Dwarf> GetDwarves()
        {
            using (dwarvesDBEntities d = new dwarvesDBEntities())
            {
                return d.Dwarves.ToList();
            }
        }

    }
}
