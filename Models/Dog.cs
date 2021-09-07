using System;
using System.ComponentModel.DataAnnotations;

namespace petshop.Models
{
  public class Dog
  {
    public string Id{get;set;}
    
    [Required]
    [MinLength(3)]
    [MaxLength(15)]
    public string Name {get;set;}

    [Range(0, int.MaxValue)]
    public int Age {get;set;}
    public string Mood {get;set;}

    public Dog(string name, int age, string mood)
    {
      Name = name;
      Age = age;
      Mood = mood;
      Id=Guid.NewGuid().ToString();
    }

  }
}