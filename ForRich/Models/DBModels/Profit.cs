using ForRich.Models.DBModels.Types_of_Budjet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForRich.Models.DBModels
{
    public class Profit :Abstr_Budjet_Unit
    {
        public virtual Profit_Type Profit_Type { get; set; }
    }
}