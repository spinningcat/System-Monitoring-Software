using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Runtime.Remoting;
using System.Reflection;

namespace requestresponsereflection
{
    class Program
    {
        static void Main(string[] args)
        {
            string protocol = "http://";
            var assembly = Assembly.GetAssembly(typeof(WebRequest));
            var objInstance = Activator.CreateInstance(assembly.FullName, "System.Net.HttpWebRequest").Unwrap();
            objInstance = WebRequest.Create(protocol + "www.contoso.com/");
          ;

        }
    }
}
