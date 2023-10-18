using System;
using WhatsAppApiUCU;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear el contacto dueño
            Contact dueño = new Contact("Lucía");
            dueño.SetPhone("093565873");
            dueño.SetEmail("E-mail");

            // Crear la lista de contactos
            Phonebook pb = new Phonebook(dueño);

            // Agregar contactos a la lista
            pb.AddContact("Felipe", "+59898313984", "me@felieppe.com");
            pb.AddContact("twilio", "+1(415)523-8886", "E-mail");
            pb.AddContact("Nombre de contacto", "Teléfono", "E-mail");

            // Enviar un correo a algunos contactos

            // Enviar un WhatsApp a algunos contactos
            WhatsAppChannel wac = new WhatsAppChannel();

            var whatsApp = new WhatsAppApi();
            whatsApp.Send("+59893565873", "Hey! I'm using WhatsApp");

            // Enviar un SMS a algunos contactos
        }
    }
}