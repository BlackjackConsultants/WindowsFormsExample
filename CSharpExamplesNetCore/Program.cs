using CSharpExamplesNetCore;
using CSharpExamplesNetCore.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpExamples {
    static class Program {
        private static IServiceProvider _serviceProvider;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            RegisterServices();
            var service = _serviceProvider.GetService<IContactService>();
            var contactTest = service.Load();
            var phoneTest = service.PhoneService.Load();
            System.Diagnostics.Debug.WriteLine("name: " + contactTest.Name);

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AsyncAndAwaitExample()); // replace the form you want to use
        }

        private static void RegisterServices() {
            var collection = new ServiceCollection();
            collection.AddSingleton<IContactService, ContactService>();
            collection.AddSingleton<IPhoneService, PhoneService>();
            _serviceProvider = collection.BuildServiceProvider();
        }
    }
}
