using CSharpExamples;
using CSharpExamples.CalculatorClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsExample;

namespace WindowsFormsExample {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args) {
			if (args.Length > 0 && args[0] == "useFluentConfig") {
                WSHttpBinding b = new WSHttpBinding(SecurityMode.Message);
                b.Security.Message.ClientCredentialType = MessageCredentialType.Windows;
                b.TransactionFlow = true;
                EndpointAddress ea = new EndpointAddress("Http://localhost:8080/secureCalculator");
                var cc = new CalculatorClient(b, ea);
                cc.Endpoint.EndpointBehaviors.Add(new SimpleEndpointBehavior());
                cc.Open();

                // Now call the service and display the results
                // Call the Add service operation.
                double value1 = 100.00D;
                double value2 = 15.99D;
                double result = cc.Add(value1, value2);
                Console.WriteLine("Add({0},{1}) = {2}", value1, value2, result);
                cc.Close();

            } else {
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new WcfClient());
            }
		}
	}
}
