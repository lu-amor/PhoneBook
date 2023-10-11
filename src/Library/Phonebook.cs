using System.Collections.Generic;

namespace Library
{
    public class Phonebook
    {
        private List<Contact> persons;

        public Phonebook(Contact owner)
        {
            this.Owner = owner;
            this.persons = new List<Contact>();
        }

        public Contact Owner { get; }

        public Contact AddContact(string Name, string Phone, string Email)
        {
            Contact contact1 = new Contact(Name);
            contact1.SetPhone(Phone);
            contact1.SetEmail(Email);
            this.persons.Add(contact1);
            return contact1;
        }

        public List<Contact> Search(string[] names)
        {
            List<Contact> result = new List<Contact>();

            foreach (Contact person in this.persons)
            {
                foreach (string name in names)
                {
                    if (person.Name.Equals(name))
                    {
                        result.Add(person);
                    }
                }
            }

            return result;
        }
    }
}