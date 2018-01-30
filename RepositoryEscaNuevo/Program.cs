using System;
using System.Windows.Forms;
using Autofac;
using Data;
using LogicaNegocio.Core;
using LogicaNegocio.Repositorios;

namespace RepositoryEscaNuevo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var context = new ApplicationDbContext();          
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
