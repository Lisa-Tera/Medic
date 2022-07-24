using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Medi2.Models
{
    public class StaticVars
    {
        private static List<DrugBasic> _drugs = new List<DrugBasic>();
        public static List<DrugBasic> Drugs
        {
            get { return _drugs; }
            set { _drugs = value; }
        }
    }
}