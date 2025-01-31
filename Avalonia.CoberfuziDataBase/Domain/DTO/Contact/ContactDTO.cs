namespace Avalonia.CoberfuziDataBase.Domain.DTO.Contact;

public class ContactDTO
{
        
    public int ContactID { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string PhoneNumber { get; set; }

    public string Email { get; set; }

    public override string ToString()
    {
        return $"ContactID: {ContactID} \n" +
               $"First Name: {FirstName} \n" +
               $"Last Name: {LastName} \n" +
               $"Phone Number: {PhoneNumber} \n" +
               $"Email: {Email}";
    }
        
}