
// This class is responsible for handling the order processing logic, including validation, saving, sending emails, and logging. 
// It follows the Single Responsibility Principle by encapsulating all order-related operations within a single class.

// public class OrderService
// {
//     public void CreateOrder(Order order)
//     {
//         ValidateOrder(order);

//         SaveOrder(order);

//         SendEmail(order);

//         LogOrder(order);
//     }

//     private void ValidateOrder(Order order){}
//     private void SaveOrder(Order order){}
//     private void SendEmail(Order order){}
//     private void LogOrder(Order order){}
// }

// Last class need to be refactored to follow the Single Responsibility Principle. 
// Each method should be moved to a separate class that handles a specific responsibility, 
// such as OrderValidator, OrderRepository, EmailService, and Logger. 
// This way, each class will have a single reason to change, making the code more maintainable and easier to test.

public class OrderService
{
    private readonly IOrderValidator _orderValidator;
    private readonly IOrderRepository _orderRepository;
    private readonly INotificationService _notificationService;
    private readonly IPaymentProcessor _paymentProcessor;

    public OrderService(IOrderValidator validator, 
    IOrderRepository repository, 
    INotificationService notificationService, 
    IPaymentProcessor paymentProcessor)
    {
        _orderValidator = validator;
        _orderRepository = repository;
        _notificationService = notificationService;
        _paymentProcessor = paymentProcessor;
    }

    public void CreateOrder(Order order)
    {
        if (!_orderValidator.Validate(order))
        {
            throw new Exception("Orden Invalida");
        }
        _orderRepository.Save(order);
        _orderRepository.LogOrder(order);
        _notificationService.Send(order);
    }

    public void PayOrder(Order order)
    {
        _paymentProcessor.ProcessPayment(order);
    }
}