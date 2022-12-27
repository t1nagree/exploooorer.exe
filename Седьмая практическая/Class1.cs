using PracticalWorkVII;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace fileexplorer
{
    internal class Explorer
    {
        public static DriveInfo[] _drives = DriveInfo.GetDrives();
        public static List<string> DirList = new List<string>();
        public static string path = " ";
        public static DirectoryInfo[] dirs;
        public static FileInfo[] files;

        public static void Drives()
        {
            foreach (DriveInfo drive in _drives)
            {
                DirList.Add(drive.Name);
                Console.Write("   ");
                Console.Write(drive.Name);
                Console.WriteLine($" {drive.TotalFreeSpace / 1073741824} ГБ свободно из {drive.TotalSize / 1073741824} ГБ ");
            }

            Strelka strelka = new Strelka(3, DriveInfo.GetDrives().Length);
            strelka.ChangePositionDrives(3, DriveInfo.GetDrives().Length + 2);
        }

        public static void Catalogs(string path)
        {
            int i = 3;
            var directory = new DirectoryInfo(path);
            dirs = directory.GetDirectories();
            files = directory.GetFiles();
            int totalLength = dirs.Length + files.Length;
            Console.Clear();
            Program.Greetings();
            Console.SetCursorPosition(10, 2);
            Console.WriteLine("Название");
            Console.SetCursorPosition(55, 2);
            Console.Write("  Дата создания");
            Console.SetCursorPosition(78, 2);
            Console.WriteLine("Тип");

            foreach (DirectoryInfo dir in dirs)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("   ");
                Console.WriteLine(dir.Name);
                Console.SetCursorPosition(55, i);
                Console.WriteLine(dir.CreationTime);
                i++;

            }

            foreach (FileInfo file in files)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("   ");
                Console.WriteLine(file.Name);
                Console.SetCursorPosition(55, i);
                Console.WriteLine(file.CreationTime);
                Console.SetCursorPosition(78, i);
                Console.Write(file.Extension);
                i++;
            }

            if (path.Length > 2)
            {
                Strelka strelka = new Strelka(3, totalLength);
                strelka.ChangePositionDir(3, totalLength + 2);
            }
        }
    }
}