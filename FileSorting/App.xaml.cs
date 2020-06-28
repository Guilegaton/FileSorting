using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace FileSorting
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Call with Startup property in App.xaml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AppStartupMainMAGI(object sender, StartupEventArgs e)
        {
            String[] arguments = Environment.GetCommandLineArgs();

            if (arguments.GetLength(0) > 1)
            {
                if (arguments[1].EndsWith(".magi"))
                {
                    string filePathFormMainArgs = arguments[1];
                }
            }
        }
    }
}
