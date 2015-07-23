using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace Handler.Handler
{
    /// <summary>
    /// Summary description for Handler
    /// </summary>
    public class Handler : IHttpHandler
    {
        private static string file = "json.json";
        public void ProcessRequest(HttpContext context)
        {
            try
            {
                var path = context.Server.MapPath(file);
                var result = System.IO.File.ReadAllText(path);
                context.Response.Write(result);
            }
            catch(Exception ex)
            {
                context.Response.Write("Invalid file");
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}