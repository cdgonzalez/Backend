// This class represents an item in an order, containing details about the product, quantity, and price.
public class OrderItem
{
    public int ProductId {get; set;}
    public int Quantity {get; set;}
    public decimal Price {get; set;}

    public decimal GetTotalPrice()
    {
        return Quantity * Price;
    }

    public void UpdateQuantity(int newQuantity)
    {
        Quantity = newQuantity;
    }    
}