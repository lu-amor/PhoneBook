namespace Library;

public class WhatsAppMessage : Message
{
    public WhatsAppMessage(Contact contact) :
        base(null, contact.Phone)
    {
        // Intencionalmente en blanco
    }
}