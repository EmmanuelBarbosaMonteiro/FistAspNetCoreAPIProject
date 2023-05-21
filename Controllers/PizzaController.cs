using ContosoPizza.Models;
using ContosoPizza.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers;

// Annotating this class as a Controller with automatic HTTP request handling.
[ApiController]

// Defining the route to access this controller.
[Route("[controller]")]

// Creating a PizzaController which inherits from ControllerBase.
public class PizzaController : ControllerBase
{
    // Constructor for the PizzaController.
    public PizzaController()
    {
    }

    // Action to handle GET requests and return all pizzas.
    [HttpGet]
    public ActionResult<List<Pizza>> GetAll() => PizzaService.GetAll();

    // Action to handle GET requests with an id parameter and return a specific pizza.
    [HttpGet("{id}")]
    public ActionResult<Pizza> Get(int id)
    {
        // Get pizza by id.
        var pizza = PizzaService.Get(id);

        // If no pizza with such id is found, return a 404 Not Found status.
        if(pizza == null)
            return NotFound();

        // If pizza is found, return the pizza.
        return pizza;    
    }

    // POST action

    // DELETE action
}