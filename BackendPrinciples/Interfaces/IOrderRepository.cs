// This class defines the IOrderRepository interface, wich is responsible for handling all database operation related to orders
public interface IOrderRepository
{
    void Save(Order order);

    void LogOrder(Order order);

    void Delete(Order order);

    void Update(Order order);
}

public class OrderRepository : IOrderRepository
{
    public void Save(Order order)
    {
        Console.WriteLine("Guardando orden con ID: " + order.Id + " y " + order.TotalAmount.ToString("C") + " en la base de datos.");
    }

    public void LogOrder(Order order)
    {
        Console.WriteLine("Registrando orden con ID: " + order.Id + " en el sistema de logs.");
    }

    public void Delete(Order order)
    {
        Console.WriteLine("Eliminando orden con ID: " + order.Id);
    } 

    public void Update(Order order)
    {
        Console.WriteLine("Actualizando orden con ID: " + order.Id);
    }
}