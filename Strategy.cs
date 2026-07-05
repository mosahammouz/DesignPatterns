namespace DesignPatternsNotion;

public interface IPaymentStrategy
{
    void Pay(int amount);
}

public class CreditCardStrategy : IPaymentStrategy
{
    private readonly string _name;
    private readonly string _cardNumber;
    private readonly string _cvv;
    private readonly string _expiryDate;
    
    public CreditCardStrategy(string name, string cardNumber, string cvv, string expiryDate)
    {
        _name = name;
        _cardNumber = cardNumber;
        _cvv = cvv;
        _expiryDate = expiryDate;
    }
    
    public void Pay(int amount)
    {
        Console.WriteLine($"${amount} paid with credit card (Card: {_cardNumber})");
    }
}
                                                             //2 Algo.s
public class PayPalStrategy : IPaymentStrategy
{
    private readonly string _emailId;
    private readonly string _password;
    
    public PayPalStrategy(string emailId, string password)
    {
        _emailId = emailId;
        _password = password;
    }
    
    public void Pay(int amount)
    {
        Console.WriteLine($"${amount} paid using PayPal (Account: {_emailId})");
    }
}

public class ShoppingCart
{
    private readonly List<int> _prices = new List<int>();
    
    public void AddItem(int price)
    {
        _prices.Add(price);
    }

    public void Pay(IPaymentStrategy paymentMethod) // here it is the Power of Strategy pattern
    {
        int total = _prices.Sum();
        paymentMethod.Pay(total);
    }
}
