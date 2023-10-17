using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear el contacto dueño
            Contact dueño = new Contact("Nombre de dueño");
            dueño.SetPhone("Teléfono");
            dueño.SetEmail("E-mail");

            // Crear la lista de contactos
            Phonebook pb = new Phonebook(dueño);

            // Agregar contactos a la lista
            pb.AddContact("Felipe", "098313984", "me@felieppe.com");
            pb.AddContact("Nombre de contacto", "Teléfono", "E-mail");
            pb.AddContact("Nombre de contacto", "Teléfono", "E-mail");

            // Enviar un correo a algunos contactos

            // Enviar un WhatsApp a algunos contactos
            WhatsAppChannel wac = new WhatsAppChannel();

            string[] search = new string[] {"Felipe"};
            Contact to = pb.Search(search)[0];
            Message msg = wac.CreateMessage(dueño, to);

            msg.Text = "Hola!!";
            wac.Send(msg);

            // Enviar un SMS a algunos contactos
        }
    }
}
