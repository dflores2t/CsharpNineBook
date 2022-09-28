using System;
using System.Linq;
using System.Reflection;

namespace Basics
{
  class Program
  {
    static void Main(string[] args)
    {
      System.Data.DataSet ds;
      System.Net.Http.HttpClient client;
      Console.WriteLine("Hello World!");
      foreach (var r in Assembly.GetEntryAssembly().GetReferencedAssemblies())
      {
        //load the assembly so we can read its details
        var a = Assembly.Load(new AssemblyName(r.FullName));
        //declare a variable to count the numbre of methods
        int methodCount = 0;
        //loo through all the types in the assembly
        foreach (var t in a.DefinedTypes)
        {
          //add up the counts of methods
          methodCount += t.GetMethods().Count();
        }
        //output the count of types and their methods
        Console.WriteLine("{0:N0} TYPES WITH {1:N0} METHODS IN {2} ASSEMBLY.", arg0: a.DefinedTypes.Count(), arg1: methodCount, arg2: r.Name);
      }
    //let the heighInMetres variable becamoe equal to the value 1.88
    double heighInMetres = 1.88;
    Console.WriteLine($"THE VARIABLE {nameof(heighInMetres)} has the value {heighInMetres}");
    }

  }
}
