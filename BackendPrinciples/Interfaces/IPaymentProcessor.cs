// Interface for processing different types of payments

public interface IPaymentProcessor
{
    void ProcessPayment(Order order);
}

// Implementing the IPaymentProcessor interface for a specific payment method (e.g., CreditCardPaymentProcessor)
public class PaypalProcessor : IPaymentProcessor {

    public void ProcessPayment(Order order) {
        Console.WriteLine("Procesando pago de " + order.TotalAmount.ToString("C") + " con " + order.PaymentMethod);
    }
};
public class StripeProcessor : IPaymentProcessor {

    public void ProcessPayment(Order order) {
        Console.WriteLine("Procesando pago de " + order.TotalAmount.ToString("C") + " con " + order.PaymentMethod);
    }
};
public class MercadoPagoProcessor : IPaymentProcessor {

    public void ProcessPayment(Order order) {
        Console.WriteLine("Procesando pago de " + order.TotalAmount.ToString("C") + " con " + order.PaymentMethod);
    }
};
public class CreditCardProcessor : IPaymentProcessor {

    public void ProcessPayment(Order order) {
        Console.WriteLine("Procesando pago de " + order.TotalAmount.ToString("C") + " con " + order.PaymentMethod);
    }
};