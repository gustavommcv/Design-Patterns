using ChainOfResponsibility.Handlers;
using ChainOfResponsibility.Requests;

Approver manager = new Manager();
Approver director = new Director();

manager.SetNextApprover(director);

manager.ProcessRequest(new PurchaseRequst(800));
manager.ProcessRequest(new PurchaseRequst(400000000));
