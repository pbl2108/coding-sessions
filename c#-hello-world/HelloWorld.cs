using System;

namespace HelloWorldNameSpace {
public class HelloWorld
{
    //Change-2 created - test. test.
    //test push
    static void Main(string[] args)
    {
        //var s = Console.ReadKey();
        Console.WriteLine("--------:");
        if (args.Length > 0)
        {
            for (int i = 0; i < args.Length; i++)
            { 
                Console.WriteLine("args[" + i.ToString() + "]=" + args[i]);
            }
        }
        Console.WriteLine("Hello World!");

       
    }
}
}