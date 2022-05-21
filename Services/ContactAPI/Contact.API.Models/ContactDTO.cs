namespace Contact.API.Models
{
    public class ContactDTO
    {
        public int Id { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public String FullName => $"{FirstName} {LastName}";
    }
}
