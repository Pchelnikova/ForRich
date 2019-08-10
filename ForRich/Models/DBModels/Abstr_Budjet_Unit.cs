using ForRich.Models.DBModels.Types_of_Budjet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForRich.Models.DBModels
{
    public class Abstr_Budjet_Unit
    {
        public int Id { get; set; }
        public DateTime Date_ { get; set; }
        public decimal Sum { get; set; }
        public string Description { get; set; }
        public virtual Abstr_Type AbstrType_for_Budget { get; set; }

    }
}