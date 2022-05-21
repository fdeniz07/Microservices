using Contact.API.Infrastructure;
using Contact.API.Models;

namespace Contact.API.Services
{
    public class ContactService:IContactService
    {
        #region Implementation of IContactService

        public ContactDTO GetContactById(int Id)
        {
            return new ContactDTO()
            {
                Id = Id,
                FirstName = "Fatih",
                LastName = "Deniz"
            };
        }

        #endregion
    }
}
