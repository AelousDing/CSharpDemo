using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpDemo.FileWatcher
{
    public class FileListenerServer
    {
        private FileSystemWatcher watcher;
        string path;
        public FileListenerServer(string path)
        {
            this.path = path;
            watcher = new FileSystemWatcher(path);
            watcher.Created += Watcher_Created;
            watcher.Changed += Watcher_Changed;
            watcher.Deleted += Watcher_Deleted;
            watcher.Renamed += Watcher_Renamed;
        }

        private void Watcher_Renamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine($"重命名：{e.Name} {e.FullPath} {e.OldFullPath} {e.ChangeType}");
        }

        private void Watcher_Deleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"删除：{e.Name} {e.FullPath} {e.ChangeType}");
        }

        private void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"变更：{e.Name} {e.FullPath} {e.ChangeType}");
        }

        private void Watcher_Created(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"创建：{e.Name} {e.FullPath} {e.ChangeType}");
        }

        public void Start()
        {
            watcher.EnableRaisingEvents = true;
        }
        public void Stop()
        {
            watcher.EnableRaisingEvents = true;
            watcher.Dispose();
            watcher = null;
        }
    }
}
