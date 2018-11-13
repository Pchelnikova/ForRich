using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForRich.Models.DBModels.Types_of_Budjet
{
    public class Abstr_Type
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //EF navigation property
        public virtual ICollection<Abstr_Budjet_Unit> Budjet_Units { get; set; }
    }
}