using System.ServiceModel;

namespace Host {
    partial class Program {
        [ServiceContract]
        public interface ICalculator {
            [OperationContract]
            double Add(double a, double b);
        }

    }

}