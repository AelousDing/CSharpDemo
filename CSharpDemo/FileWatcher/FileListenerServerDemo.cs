using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.FileWatcher
{
    public class FileListenerServerDemo
    {
        public static void Run()
        {

            FileListenerServer fileListenerServer = new FileListenerServer(@"C:\Users\aelous\Desktop\FileWatcher");

            fileListenerServer.Start();
        }
    }
}
