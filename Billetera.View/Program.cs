using AutoMapper;
using Billetera.Models.Mapper;

namespace Billetera.View
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmLogin());
        }
    }
}