// This is a class to validate the order before processing it. 
// It checks if the order meets certain criteria, such as having a positive total amount and a valid payment method.    
public interface IOrderValidator
{
    bool Validate(Order order);
}

public class OrderValidator : IOrderValidator
{
    public bool Validate(Order order)
    {
        // Implement validation logic here (e.g., check if total amount is positive, payment method is valid, etc.)
        if (order.TotalAmount <= 0)
        {
            Console.WriteLine("Invalid order: Total amount must be greater than zero.");
            return false;
        }

        if (string.IsNullOrEmpty(order.PaymentMethod))
        {
            Console.WriteLine("Invalid order: Payment method is required.");
            return false;
        }

        // Additional validation rules can be added here

        return true; // Order is valid
    }
}