using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FFPlan.Controllers
{
    public class UserController : ApiController
    {
        // GET api/user/GetAllUserNames
        public IEnumerable<string> GetAllUserNames()
        {
            return new string[] { "name1", "name2" };
        }

        // GET api/user/10
        public IEnumerable<string> GetAllUserNamesByAge(int id)
        {
            if (id > 50)
            {
                return new string[] { "name2" };
            }
            else
            {
                return new string[] { "name1" };
            }
        }
    }
}
