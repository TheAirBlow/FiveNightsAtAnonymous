using System;
using System.Reflection;
using Serilog;
using Serilog.Core;

namespace TerraCore.Game
{
    public static class Program
    {
        /// <summary>
        /// Symlink to get FiveNightsAtAnonymous.Game version
        /// </summary>
        public static Version Version = Assembly.GetExecutingAssembly().GetName().Version;
        
        /// <summary>
        /// Public logger
        /// </summary>
        public static Logger Logger = new LoggerConfiguration()
            .WriteTo.File("terracore.log")
            .WriteTo.Console()
            .CreateLogger();
    
        /// <summary>
        /// Entry point method
        /// </summary>
        /// <param name="args">Arguments</param>
        [STAThread]
        public static void Main(string[] args)
        {
            Logger.Information("Welcome to TerraCore!");
            Logger.Information($"Game assembly {Version}");
            
            using var game = new Game1();
            game.Run();
        }
    }
}