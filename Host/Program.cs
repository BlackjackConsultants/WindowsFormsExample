using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Configuration;
using System.Configuration;
using System.ServiceModel.Description;

namespace Host {
    partial class Program {
        static void Main(string[] args) {
            if (args.Length > 0 && args[0] == "useFluentConfig") {
                // use fluent coniguration
                var applicationSettings = (ServicesSection)ConfigurationManager.GetSection("system.serviceModel/services");
                if (applicationSettings.Services.Count > 1) {
                    throw new Exception("You need to uncomment the the system.serviceModel section of the app.config file so we can test .config type configuation.");
                }
                var p = new Program();
                p.Run();
                var test = applicationSettings.ToString();
            } else {
                // use app.config coniguration
                using (ServiceHost host = new ServiceHost(typeof(SimpleService.SimpleService))) {
                    host.Open();
                    Console.WriteLine("Host started @ " + DateTime.Now.ToString());
                    Console.ReadLine();
                }
            }
        }


        private void Run() {
            // First procedure:
            // create a WSHttpBinding that uses Windows credentials and message security
            WSHttpBinding myBinding = new WSHttpBinding();
            myBinding.Security.Mode = SecurityMode.Message;
            myBinding.Security.Message.ClientCredentialType = MessageCredentialType.Windows;

            // 2nd Procedure:
            // Use the binding in a service
            // Create the Type instances for later use and the URI for
            // the base address.
            Type contractType = typeof(ICalculator);
            Type serviceType = typeof(Calculator);
            Uri baseAddress = new Uri("http://localhost:8080/");

            // Create the ServiceHost and add an endpoint, then start
            // the service.
            ServiceHost myServiceHost = new ServiceHost(serviceType, baseAddress);
            myServiceHost.AddServiceEndpoint(contractType, myBinding, "secureCalculator");

            //enable metadata
            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            myServiceHost.Description.Behaviors.Add(smb);

            myServiceHost.Open();
            Console.WriteLine("Listening");
            Console.WriteLine("Press Enter to close the service");
            Console.ReadLine();
            myServiceHost.Close();
        }

    }

}