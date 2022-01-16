using CSharpDemo.DesignPatterns.Create.Builder;
using CSharpDemo.DesignPatterns.Structural.Adapter;
using CSharpDemo.Encrypt;
using CSharpDemo.FileWatcher;
using System;

namespace CSharpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinqWhereLoop.Run();
            //ClassNameChildren.Run();
            //FileDemo.Run();
            //BuilderClient.Run();
            //AdapterClient.Run();
            //FunctionParamDemo.Run();
            //string s = Md5.MD5Encrypt32("123");
            //Console.WriteLine(s);

            FileListenerServerDemo.Run();
            Console.ReadLine();
        }
    }
}
