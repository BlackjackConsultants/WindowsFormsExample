using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Host {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SimpleService" in both code and config file together.
    public class SimpleService : ISimpleService {
        public string GetUserName() {
            Console.WriteLine("Is Authenticated: " + ServiceSecurityContext.Current.PrimaryIdentity.IsAuthenticated.ToString());
            Console.WriteLine("Authenticated Type: " + ServiceSecurityContext.Current.PrimaryIdentity.AuthenticationType);
            Console.WriteLine("User Name: " + ServiceSecurityContext.Current.PrimaryIdentity.Name);
            return "Authenticated user name: " + ServiceSecurityContext.Current.PrimaryIdentity.Name;
        }
    }
}
