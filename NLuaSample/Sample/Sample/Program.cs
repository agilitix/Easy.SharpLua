using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLua;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var lua = new Lua())
            {
                lua.State.Encoding = Encoding.UTF8;
                lua.LoadCLRPackage();

                lua.DoString("print ('Hello world!')");
            }

            Console.WriteLine();
            Console.Write("Exit:");
            Console.ReadKey();
        }
    }
}
