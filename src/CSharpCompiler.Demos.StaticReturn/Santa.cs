using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCompiler.Demos.OpenGeneric
{
    public static class Santa { }

    public interface IChristmas
    {
        Santa GetSanta();
    }

    //public class Christmas
    //{
    //    public Santa GetSanta()
    //    {
    //        return null;
    //    }
    //}
}
