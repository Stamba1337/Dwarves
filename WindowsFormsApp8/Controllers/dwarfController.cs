﻿using System;
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

        public void CreateDwarf(Dwarf d)
        {
            using (dwarvesDBEntities db = new dwarvesDBEntities())
            {
                var lastDwarf = db.Dwarves.ToList().LastOrDefault();
                if (lastDwarf == null)
                {
                    lastDwarf = new Dwarf();
                    lastDwarf.Id = 0;
                }

                d.Id = lastDwarf.Id + 1;
                db.Dwarves.Add(d);
                db.SaveChanges();
            }
        }
    }
}
