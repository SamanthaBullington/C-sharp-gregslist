using System;
using System.Collections.Generic;
using petshop.Models;

namespace petshop.Services
{
    public class DogsService{
      internal IEnumerable<Dog> Get()
      {
        return FakeDB.Dogs;
      }

      internal Dog Get(string id)
      {
        Dog found = FakeDB.Dogs.Find(d => d.Id == id);
        if(found == null)
        {
          throw new Exception("invalid Id");
        }
        return found;
      }

      internal Dog Create(Dog newDog)
      {
        FakeDB.Dogs.Add(newDog);
        return newDog;
      }

      internal void Delete(String id)
      {
        int deleted = FakeDB.Dogs.RemoveAll(d => d.Id == id);
        if (deleted == 0)
        {throw new Exception ("invalid Id");
        }
      }
    }
}