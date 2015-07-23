using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Handler.Handler
{
    public class CustomHandler:IHttpHandler
    {
        private static string file = "json.json";
        public bool IsReusable
        {
            get { return false; }
        }

        public void ProcessRequest(HttpContext context)
        {
            try
            {
                var path = context.Server.MapPath(file);
                var result = System.IO.File.ReadAllText(path);
                context.Response.Write(result);
            }
            catch (Exception ex)
            {
                context.Response.Write("Invalid file");
            }
        }
    }
}