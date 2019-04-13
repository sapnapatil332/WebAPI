using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public List<Employee> Get()
        {
            List<Employee> list = new List<Employee>() {
                new Employee{EmpID=1,EmpName="Sapna",Job="Developer", Salary="30000",Address="Hyderabad" },
                new Employee{EmpID=2,EmpName="Ranjeet",Job="Developer", Salary="30000",Address="Delhi" },
                new Employee{EmpID=3,EmpName="Arti",Job="Developer", Salary="30000",Address="Hyderabad" },
                new Employee{EmpID=4,EmpName="Manoj",Job="Tester", Salary="30000",Address="Pune" },
                new Employee{EmpID=5,EmpName="Priya",Job="Accountant", Salary="450000",Address="Pune" },
                new Employee{EmpID=6,EmpName="Albert",Job="Manager", Salary="850000",Address="Canada" }
            };


            List<customer> objlist = new List<customer>() {
                new customer{custId=1,custName="sapna",custIdProduct="Fan" },
                 new customer{custId=2,custName="Arti",custIdProduct="Fan2" },
                  new customer{custId=3,custName="Ranjeet",custIdProduct="Fan3" },



            };
            return list;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
