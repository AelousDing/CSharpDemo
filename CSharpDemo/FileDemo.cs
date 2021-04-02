using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemo
{
    public class FileUtil
    {
        public static byte[] ReadFile(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return null;
            }
            if (!File.Exists(path))
            {
                return null;
            }
            using (FileStream stream = new FileStream(path, FileMode.Open))
            {
                BinaryReader br = new BinaryReader(stream);
                return br.ReadBytes((int)stream.Length);
            }
        }
        public static void WriteFile(string path, byte[] data)
        {
            if (string.IsNullOrEmpty(path))
            {
                return;
            }
            string directoryName = Path.GetDirectoryName(path);
            if (!Directory.Exists(directoryName))
            {
                Directory.CreateDirectory(directoryName);
            }
            using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
            {
                stream.Write(data, 0, data.Length);
            }
        }
    }
    public class FileDemo
    {
        public static void Run()
        {
            string path = @"C:\Users\aelous\Desktop\11.txt";
            byte[] data = Encoding.UTF8.GetBytes("gdsfjhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhdghjjsfsgfjskhflajjjjjjjjjjjjjjjjjj");
            Task.Run(() =>
            {
                FileUtil.ReadFile(path);
            });
            Task.Run(() =>
            {

                FileUtil.WriteFile(path, data);
            });
        }
    }
}
