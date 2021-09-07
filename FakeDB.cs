using System.Collections.Generic;
using petshop.Models;

namespace petshop
{
  static public class FakeDB
  {
    static public List<Dog> Dogs { get; set; } = new List<Dog>() { new Dog("Max", 3, "happy") };
  }
}