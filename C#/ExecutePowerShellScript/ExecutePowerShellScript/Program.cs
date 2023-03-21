using System;
using System.Diagnostics;

namespace ExecutePowerShellScript
{
    class Program
    {
        public static void Main(string[] args)
        {
            InstallViaPowerShell();
        }

        public static void InstallViaPowerShell()
        {

            var ps1File = @"C:\Users\muss\Desktop\My GitHub Repos\Object-Oriented-Programming\C#\ScreenMirroringConnection\ScreenMirroringConnection\bin\Debug\net6.0-windows\final.ps1";

            var startInfo = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy ByPass -File \"{ps1File}\"",
                UseShellExecute = false
            };
            Process.Start(startInfo);

        }
    }
}