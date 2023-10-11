namespace Library
{
    public class Contact
    {
        public Contact(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public void SetPhone(string Phone)
        {
            this.Phone = Phone;
        }

        public void SetEmail(string Email)
        {
            this.Email = Email;
        }
    }
}