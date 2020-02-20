using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ResourceBuilder_Test.Resources;

namespace ResourceBuilder_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ResourceManager rm = new ResourceManager("ResourceBuilder_Test.Resources.Explainations", Assembly.GetAssembly(typeof(Program)));
            //ResourceManager rm = new ResourceManager(typeof(Program));
            string message = rm.GetString("String1");

            CultureInfo frCulture = new CultureInfo("fr-FR");
            Thread.CurrentThread.CurrentUICulture = frCulture;
            //rm = new ResourceManager(typeof(Program));
            message = rm.GetString("String1");
            message = Explainations.String1;
        }
    }
}
