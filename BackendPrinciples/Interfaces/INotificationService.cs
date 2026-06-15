// This class defines the INotificationService interface, which is responsible for sending notifications related to orders.
public interface INotificationService
{
    void Send(Order order);
}

public class NotificationService : INotificationService
{
    public void Send(Order order)
    {
        Console.WriteLine("Enviando notificación para la orden con ID: " + order.Id);
    }
}