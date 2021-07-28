using Demo.ModelMultiTable.Models;
using Demo.ModelsAndServices;
using Demo.ModelsAndServices.Entities;
using System;

namespace Demo.ModelMultiTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact c = new Contact { Email = "samuel.legrain@bstorm.be", Phone = "080033800" };
            Person p = new Person { FirstName = "Samuel", LastName = "Legrain" };

            PersonContactModel pcm = new PersonContactModel { FirstName = p.FirstName, LastName = p.LastName, Email = c.Email, Phone = c.Phone };

            PersonService service = new PersonService();

            Person p1;
            Contact c1;
            p1 = pcm.GetEntities(out c1);

            service.DoSomething(p1, c1);
        }
    }
}
