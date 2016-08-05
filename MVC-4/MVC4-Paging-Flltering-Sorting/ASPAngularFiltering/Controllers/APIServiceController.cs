using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPAngularFiltering.Models;

namespace ASPAngularFiltering.Controllers
{
    public class APIServiceController : Controller
    {
        //
        // GET: /APIService/

        public JsonResult SendEnployeeAsJson()
        {
            DBC _dbc =new DBC();
            IEnumerable<Employee> employees = _dbc.Employees;
            return new JsonResult { Data = employees, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

    }
}
