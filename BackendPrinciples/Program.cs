using System;

class Program
{
    static void Main(string[] args)
    {
        IPaymentProcessor creditCardProcessor = new CreditCardProcessor();
        IPaymentProcessor paypalProcessor = new PaypalProcessor();
        IOrderValidator orderValidator = new OrderValidator();
        IOrderRepository orderRepository = new OrderRepository();
        INotificationService notificationService = new NotificationService();
        
        Order order = new Order
        {
            Id = 1,
            Items = new List<OrderItem>
            {
                new OrderItem { ProductId = 101, Quantity = 2, Price = 10.5m },
                new OrderItem { ProductId = 102, Quantity = 1, Price = 20.0m }
            },
            PaymentMethod = "Tarjeta de Crédito"
        };

        Order orderTwo = new Order
        {
            Id = 2,
            Items = new List<OrderItem>
            {
                new OrderItem { ProductId = 101, Quantity = 6, Price = 10.5m },
                new OrderItem { ProductId = 102, Quantity = 10, Price = 20.0m }
            },
            PaymentMethod = "Paypal"
        };

        OrderService creditCardService = new OrderService(orderValidator, orderRepository, notificationService, creditCardProcessor);
        creditCardService.CreateOrder(order);
        creditCardService.PayOrder(order);

        OrderService paypalService = new OrderService(orderValidator, orderRepository, notificationService, paypalProcessor);
        paypalService.CreateOrder(orderTwo);
        paypalService.PayOrder(orderTwo);
        
    }
}