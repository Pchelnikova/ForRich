using ForRich.Models.DBModels.Types_of_Budjet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForRich.Models.DBModels
{
    public class Expence : Abstr_Budjet_Unit
    {
        public virtual Expence_Type Expence_Type { get; set; }
    }
}