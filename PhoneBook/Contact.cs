using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
  public class Contact
  {
    public Contact(string name, string lastName, long phoneNumber, string email)
    {
      Name = name;
      LastName = lastName;
      PhoneNumber = phoneNumber;
      Email = email;
    }

    public string Name { get; }
    public string LastName { get; }
    public long PhoneNumber { get; }
    public string Email { get; }
  }
}
