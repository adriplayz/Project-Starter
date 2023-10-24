using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        string explorerPath = @"C:\FiveM\dev";
        string vsCodePath = @"C:\FiveM\dev\resources\[dev]\tm";

        ProcessStartInfo explorerStartInfo = new ProcessStartInfo
        {
            FileName = "explorer.exe",
            Arguments = explorerPath,
            UseShellExecute = true,
            CreateNoWindow = true
        };
        Process.Start(explorerStartInfo);

        ProcessStartInfo vsCodeStartInfo = new ProcessStartInfo
        {
            FileName = "code",
            Arguments = vsCodePath,
            UseShellExecute = true,
            CreateNoWindow = true
        };
        Process.Start(vsCodeStartInfo);

        // Fügen Sie hier eine Verzögerung hinzu, wenn die Anwendung nach einer bestimmten Zeit automatisch beendet werden soll.
        // System.Threading.Thread.Sleep(5000); // Warten Sie 5 Sekunden
    }
}
