namespace _04_ChainOfResponsibility
{
    // Concrete handler for team lead
    public class TeamLead : IApprover
    {
        private IApprover nextApprover;

        public void SetNextApprover(IApprover nextApprover)
        {
            this.nextApprover = nextApprover;
        }

        public void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount <= 1000)
                Console.WriteLine($"Team Lead approved the purchase of {request.ItemName}.");
            else if (nextApprover != null)
                nextApprover.ProcessRequest(request);
            else
                Console.WriteLine($"Team Lead cannot approve, the request exceeds the limit.");
        }
    }

    // Concrete handler for manager
    public class Manager : IApprover
    {
        private IApprover nextApprover;

        public void SetNextApprover(IApprover nextApprover)
        {
            this.nextApprover = nextApprover;
        }

        public void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount > 1000 && request.Amount <= 5000)
                Console.WriteLine($"Manager approved the purchase of {request.ItemName}.");
            else if (nextApprover != null)
                nextApprover.ProcessRequest(request);
            else
                Console.WriteLine($"Manager cannot approve, passing to Director.");
        }
    }

    // Concrete handler for director
    public class Director : IApprover
    {
        public void SetNextApprover(IApprover nextApprover)
        {
            // Director is the highest authority, and there is no next approver.
            // You can handle this in different ways, such as throwing an exception or ignoring the call.
            // In this example, we'll just ignore the call.
        }

        public void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount > 5000)
                Console.WriteLine($"Director approved the purchase of {request.ItemName}.");
            else
                Console.WriteLine($"Director cannot approve, the request exceeds the limit.");
        }
    }
}
