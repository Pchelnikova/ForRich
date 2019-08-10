using ForRich.Models.DBModels.Types_of_Budjet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForRich.Models.DBModels
{
    public class Plan : Abstr_Budjet_Unit
    {
        public virtual Expence_Type Expance_Type { get; set; }
    }
}