using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForRich.Models.DBModels.Types_of_Budjet
{
    public class Expence_Type: Abstr_Type
    {
        public virtual ICollection<Plan> Plan { get; set; }
    }
}