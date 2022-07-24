using Drug2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Mvc;

namespace Drug2.Controllers
{
    public class DrugController : ApiController
    {

      
        // GET api/<controller>
        public IEnumerable<DrugBasic> Get()
        {
            return StaticVars.Drugs.Take(10);
        }

        public List<DrugBasic> Get(string str)
        {
            if (string.IsNullOrEmpty(str))
                return new List<DrugBasic>();

            return StaticVars.Drugs.Where(dr => dr.ITEM_NAME.Contains(str)).ToList();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>

    }
}