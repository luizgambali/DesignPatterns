public class QueueSender : IMessageSender
{
    public void SendMessage(string subject, string body)
    {
        Console.WriteLine($"MSMQ\n{subject}\n{body}\n");
    }
}