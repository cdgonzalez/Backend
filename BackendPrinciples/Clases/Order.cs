// This class represents an order in an e-commerce system. It contains a 
// list of order items, the total amount of the order, and the payment method used for the order.
public class Order
{
    public int Id {get; set;}
    public List<OrderItem> Items {get; set;} = new List<OrderItem>();
    public decimal TotalAmount {
        get
        {
            decimal total = 0;
            if (Items != null)
            {
                foreach (var item in Items)
                {
                    total += item.GetTotalPrice();
                }
            }
            return total;
        }
    }
    public string? PaymentMethod {get; set;}
    public string GetTotalAmountFormatted()
    {
        return TotalAmount.ToString("C");
    }
}