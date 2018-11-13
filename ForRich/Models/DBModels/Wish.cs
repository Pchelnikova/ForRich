using ForRich.Models.DBModels.Types_of_Budjet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForRich.Models.DBModels
{
    public class Wish :Abstr_Budjet_Unit
    {
        //harmonization childes wishes with parents possibility and adding to Budjet_plan
        public bool Agreement { get; set; }

        //EF navigaion properties
        public virtual Event_Type Event { get; set; }
    }
}