using System;
using System.Windows.Forms;
using Ninject;
using Presenter;

namespace View
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            StandardKernel kernel = new StandardKernel(new NinjectConfiguration());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            kernel.Get<SignInPresenter>().Run();
            Application.Run(kernel.Get<ApplicationContext>());
        }
    }
}
