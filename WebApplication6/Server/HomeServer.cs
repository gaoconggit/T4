using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace WebApplication6.Server
{
    public class HomeServer
    {
        public string Index(Student stu)
        {

            JavaScriptSerializer js = new JavaScriptSerializer();
            return js.Serialize(stu);
        }
    }
}