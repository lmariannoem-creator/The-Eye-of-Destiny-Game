namespace EyeOfDestinyNet8;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration
        ApplicationConfiguration.Initialize();
        Application.Run(new TheEyeofDestiny());
    }    
}