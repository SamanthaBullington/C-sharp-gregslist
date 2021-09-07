using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using petshop.Models;
using petshop.Services;

namespace petshop.Controllers
{
  //needed for program to read route
[ApiController]
 [Route("/api/[controller]")]
 public class DogsController : ControllerBase
 {
   private readonly DogsService _dogsService;
   
   public DogsController(DogsService dogsService)
   {
     _dogsService = dogsService;
   }

//GetAll request
   [HttpGet]
   public ActionResult<IEnumerable<Dog>> Get()
   {
     try
     {
       IEnumerable<Dog> dogs = _dogsService.Get();
       return Ok(dogs);
     }
     catch (Exception err)
     {
       return BadRequest(err.Message);
     }
   }
//get by ID
   [HttpGet("{id}")]

   public ActionResult<Dog> Get(string id)
   {
     try
     {
       Dog found = _dogsService.Get(id);
       return Ok(found);
     }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
   }
    [HttpPost]
    public ActionResult<Dog> Create([FromBody] Dog newDog)
    {
      try
      {
        Dog dog = _dogsService.Create(newDog);
        return Ok(dog);
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }
    //delete by Id
  [HttpDelete("{id}")]
    public ActionResult<String> Delete(string id)
    {
      try
      {
       
        _dogsService.Delete(id);
        return Ok("Successfully Adopted Dog");
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }
 }
}