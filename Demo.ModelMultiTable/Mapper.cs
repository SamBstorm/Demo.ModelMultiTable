using Demo.ModelMultiTable.Models;
using Demo.ModelsAndServices.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.ModelMultiTable
{
    public static class Mapper
    {
        public static Person GetEntities(this PersonContactModel pcm, out Contact c)
        {
            c = new Contact { Phone = pcm.Phone, Email = pcm.Email };
            return new Person { FirstName = pcm.FirstName, LastName = pcm.LastName };
        }
    }
}
