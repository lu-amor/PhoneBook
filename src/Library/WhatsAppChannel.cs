using System;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace Library;
public class WhatsAppChannel : IMessageChannel
{
    public void Send(Message message)
    {
        TwilioClient.Init("ACa84013bd9cab881b4cf870d9aa762a3e", "d7658b52096e1c783f1771dd847dc40b");

        var t = Task.Run(
        async () =>
        {
            var options = new CreateMessageOptions(new PhoneNumber(message.To))
            {
                From = new PhoneNumber("whatsapp:+14155238886"),
                Body = message.Text
            };
            var messageResponse = await MessageResource.CreateAsync(options);
        });
    }

    public Message CreateMessage(Contact from, Contact to)
    {
        if (!to.Phone.StartsWith("+598")) { 
            Console.WriteLine("Not starts with +598");
            return null; }
        if (to.Phone.Length != 12) {
            Console.WriteLine("Phone length not 12");
            return null; }
        if (!Int64.TryParse(to.Phone, out _)) {
            Console.WriteLine("to.Phone TryParse false");
            return null; }

        return new WhatsAppMessage(to);
    }
}