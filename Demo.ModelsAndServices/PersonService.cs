using Demo.ModelsAndServices.Entities;
using System;

namespace Demo.ModelsAndServices
{
    public class PersonService
    {
        public void DoSomething(Person person, Contact contact)
        {
            Console.WriteLine(person.FirstName + " " + person.LastName);
            Console.WriteLine(contact.Phone + " - " + contact.Email);
        }
    }
}
