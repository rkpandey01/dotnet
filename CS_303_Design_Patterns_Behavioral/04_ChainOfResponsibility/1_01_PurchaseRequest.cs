namespace _04_ChainOfResponsibility
{
    // Request class representing a purchase request
    public class PurchaseRequest
    {
        public string ItemName { get; set; }
        public decimal Amount { get; set; }

        public PurchaseRequest(string itemName, decimal amount)
        {
            ItemName = itemName;
            Amount = amount;
        }
    }

}
