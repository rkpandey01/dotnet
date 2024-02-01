namespace _04_ChainOfResponsibility
{
    // Handler interface
    public interface IApprover
    {
        void SetNextApprover(IApprover nextApprover);
        void ProcessRequest(PurchaseRequest request);
    }

}
