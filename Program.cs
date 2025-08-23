using StatsTracker.Controller;
using StatsTracker.Utils;

namespace StatsTracker;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        LogSystem.ClearLog();
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        LogSystem.Log(MessageType.Log, "Application Startup");
        MatchController controller = new MatchController();
        
        Application.Run(controller.GetView().GetForm());
    }
}