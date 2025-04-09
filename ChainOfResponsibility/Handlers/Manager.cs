using ChainOfResponsibility.Requests;

namespace ChainOfResponsibility.Handlers;

public class Manager : Approver {
    public override void ProcessRequest(PurchaseRequst request) {
        if (request.Amount <= 1000) {
            Console.WriteLine($"Gerente aprovou o pagamento");
        } else if (NextApprover != null) {
            NextApprover.ProcessRequest(request);
        }
    }
}
