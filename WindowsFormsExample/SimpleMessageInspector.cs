using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsExample  {
    // Client message inspector  
    public class SimpleMessageInspector : IClientMessageInspector  {
        public void AfterReceiveReply(ref System.ServiceModel.Channels.Message reply, object correlationState) {
            // Implement this method to inspect/modify messages after a message  
            // is received but prior to passing it back to the client
            Console.WriteLine("AfterReceiveReply called");
        }

        public object BeforeSendRequest(ref Message request, IClientChannel channel)
        {
            // Implement this method to inspect/modify messages before they
            // are sent to the service  
            Console.WriteLine("BeforeSendRequest called");
            return null;
        }
    }
}

