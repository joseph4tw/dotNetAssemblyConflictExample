using System;
using AssemblyACode;
using Newtonsoft.Json;

namespace DotNetAssemblyConfictExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new AssemblyAClass();
            var simpleObject = new SimpleObject();

            simpleObject.Data = "test";
            var aJson = a.GetJson(simpleObject);

            Console.WriteLine(aJson);
        }
    }

    internal sealed class SimpleObject
    {
        public string Data { get; set; }
    }
}
