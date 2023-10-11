namespace Library;
public class WhatsAppChannel : IMessageChannel
{
    public void Send(Message message)
    {

    }

    public Message CreateMessage(Contact from, Contact to)
    {
        return new WhatsAppMessage(to);
    }
}