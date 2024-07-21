namespace E2;


public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
}

public class CreditCard : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Credit card payment processed for {amount} $");
    }
}

public class PaypalProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"PayPal payment processed for {amount} $");
    }
}

public class PaymentService
{
    private readonly IPaymentProcessor _processor;

    public PaymentService(IPaymentProcessor processor)
    {
        _processor = processor;
    }
    
    public void MakePayment(decimal amount)
    {
        _processor.ProcessPayment(amount);
    }
}

class Program
{
    static void Main(string[] args)
    {
        IPaymentProcessor creditCardprocessor = new CreditCard();
        PaymentService paymentService = new PaymentService(creditCardprocessor);
        
        paymentService.MakePayment(100); // Output: Credit card payment processed for 100 $
        
        IPaymentProcessor paypalProcessor = new PaypalProcessor();
        paymentService = new PaymentService(paypalProcessor);
        
        paymentService.MakePayment(150); // Output: PayPal payment processed for 150 $
    }
}