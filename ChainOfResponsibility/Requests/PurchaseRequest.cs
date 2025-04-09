namespace ChainOfResponsibility.Requests;

public class PurchaseRequst {
    public double Amount {get;}
    public PurchaseRequst(double amount) {
        Amount = amount;
    }
}
