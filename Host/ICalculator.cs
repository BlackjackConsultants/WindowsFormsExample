using System.ServiceModel;

namespace Host {
    [ServiceContract]
    public interface ICalculator {
        [OperationContract]
        double Add(double a, double b);
        double Add2(double a, double b);
    }
}