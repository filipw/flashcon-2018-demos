using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCompiler.Demos.OpenGeneric
{
    class Program
    {
        static void Main()
        {
            var normal = Enum.ToObject(typeof(Gift.Color), 0);
            var weird = Enum.ToObject(typeof(Gift<>.Color), 0);
            Console.WriteLine(normal.GetType());
            Console.WriteLine(weird.GetType());
        }
    }


    class Gift<T>
    {
        public enum Color { }
    }

    class Gift
    {
        public enum Color { }
    }
}
