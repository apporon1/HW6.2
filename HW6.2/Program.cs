public class InvalidEmailException : Exception
{
    public InvalidEmailException(string message) : base(message) { }
}
 

public class EmailHandler
{
    private string email;

    public void SetEmail(string emailAddress)
    {
        if (!emailAddress.Contains("@"))
        {
            throw new InvalidEmailException("Некорректный адрес электронной почты: отсутствует символ '@'.");
        }
        email = emailAddress;
        Console.WriteLine($"Адрес электронной почты успешно установлен: {email}");
    }
}

// Тестирование
class EmailTest
{
    static void Main()
    {
        EmailHandler handler = new EmailHandler();

        Console.WriteLine("Введите адрес электронной почты: ");
        string emailInput = Console.ReadLine();

        try
        {
            handler.SetEmail(emailInput);
        }
        catch (InvalidEmailException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}