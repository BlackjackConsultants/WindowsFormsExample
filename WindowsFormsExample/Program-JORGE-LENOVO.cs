﻿using CSharpExamples;
using CSharpExamples.CalculatorClient;
using CSharpExamples.SimpleService;
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
                EndpointAddress ea = new EndpointAddress("Http://localhost:8080/Calculator/secureCalculator");
                var cc = new CalculatorClient(b, ea);
                cc.Endpoint.EndpointBehaviors.Add(new SimpleEndpointBehavior());
                cc.Open();

                // Now call the service and display the results
                // Call the Add service operation.
                double value1 = 100.00D;
                double value2 = 15.99D;
                double result = cc.Add(value1, value2);
                Console.WriteLine("Add({0},{1}) = {2}", value1, value2, result);
                double result2 = cc.Subtract(value1, value2);
                Console.WriteLine("Add({0},{1}) = {2}", value1, value2, result2);
                cc.Close();

                // simple service
                EndpointAddress ea2 = new EndpointAddress("http://localhost:8080/SimpleService/SimpleService");
                var ss = new SimpleServiceClient(b, ea2);
                ss.Open();

                // ok
                var u = ss.GetUserName();
                Console.WriteLine(u);

            } else {
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new WcfClient());
            }
		}
	}
}
