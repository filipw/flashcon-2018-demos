using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCompiler.Demos.StaticReturn
{
    public static class Gift { }

    public interface IChristmas
    {
        Gift GetGift();
    }

    //public class Christmas
    //{
    //    public Gift GetGift()
    //    {
    //        return null;
    //    }
    //}
}
