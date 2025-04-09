using ChainOfResponsibility.Requests;

namespace ChainOfResponsibility.Handlers;

public class Director : Approver {
    public override void ProcessRequest(PurchaseRequst request) {
        Console.WriteLine("Compra aprovada (Diretor)");
    }
}
