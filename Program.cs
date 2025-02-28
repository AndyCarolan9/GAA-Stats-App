using StatsTracker.Controller;
using StatsTracker.Model;
using StatsTracker.Views;

namespace StatsTracker;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        
        Match match = new Match();
        MatchController controller = new MatchController(match);
        
        Application.Run(controller.GetView().GetForm());
    }
}