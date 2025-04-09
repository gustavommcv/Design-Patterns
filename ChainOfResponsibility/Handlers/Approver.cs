using ChainOfResponsibility.Requests;

namespace ChainOfResponsibility.Handlers;

public abstract class Approver {
    protected Approver NextApprover;

    public Approver SetNextApprover(Approver nextApprover) {
        NextApprover = nextApprover;
        return NextApprover;
    }

    public abstract void ProcessRequest(PurchaseRequst request);
}
