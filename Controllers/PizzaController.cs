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

    // Action to handle POST requestes and create a new pizza.
    [HttpPost]
    public IActionResult Create(Pizza pizza)
    {
        PizzaService.Add(pizza);
        // Return a CreatedAction status along with the location of new resource and the resource itself.
        return CreatedAtAction(nameof(Get), new { id = pizza.Id }, pizza);
    }

    // Action to handle PUT requests and update an existing pizza.
    [HttpPut("{id}")]
    public IActionResult Update(int id, Pizza pizza)
    {
        // Check if the id in the path matches with the id of pizza in the request body.
        if (id != pizza.Id)
            return BadRequest();

        // Update the pizza.
        PizzaService.Update(pizza);

        // Return a NoContent status indicating that the operation was successful.
        return NoContent();    
    }
    
    // Action to handle DELETE requests and delete an existing pizza.
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        // Get the pizza by id.
        var pizza = PizzaService.Get(id);
        
        // If no pizza with such id is found, return a 404 Not Found status.
        if (pizza is null)
            return NotFound();

        // Delete the pizza.
        PizzaService.Delete(id);

        // Return a NoContent status indicating that the operation was successful.
        return NoContent();    
    }
}