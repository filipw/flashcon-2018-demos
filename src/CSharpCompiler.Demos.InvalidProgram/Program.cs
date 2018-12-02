using System;

namespace CSharpCompiler.Demos.InvalidProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog();
        }
    }


    struct Animal<T>
    {
    }

    struct Dog
    {
        public Animal<Dog> Classification { get; set; }
    }
}
