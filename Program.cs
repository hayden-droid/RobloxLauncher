using System;
using System.IO;
using System.Diagnostics;

namespace robloxlauncher
{
    class Program
    {
        public static string getROBLOXDirectory()
        {
            string appName = "RobloxPlayerBeta.exe";
            string localappdata = Environment.GetEnvironmentVariable("LocalAppData");
            string appPath = localappdata + @"\ROBLOX\Versions";
            DirectoryInfo folderinfo = new DirectoryInfo(appPath);

            foreach (DirectoryInfo folder in folderinfo.GetDirectories())
            {
                string folderPath = folder.FullName;
                if (File.Exists(folderPath + "/" + appName))
                {
                    return folderPath;
                }
            }
            return null;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("ROBLOX Place Launcher v1.0");
            Console.WriteLine("Made by AetherKnight");

            string RBXPlayerLocation = getROBLOXDirectory();

            if (RBXPlayerLocation != null)
            {
                Console.WriteLine("ROBLOX Found! " + RBXPlayerLocation);
                Process p = Process.Start(RBXPlayerLocation + @"\ROBLOXPlayerBeta.exe", "--id 101449733"); // the Id of the place goes after the '--id' part.
            }
            else
            {
                Console.WriteLine("This game requires ROBLOX to be installed.");
                Console.WriteLine("You can install ROBLOX @ www.roblox.com");
                Console.ReadKey();
            }    
        }
    }
}
