using ContosoPizza.Models;

namespace ContosoPizza.Services;

// Static class to perform operations related to Pizza.
public static class PizzaService
{
    // List to hold Pizza objects.
    static List<Pizza> Pizzas { get; }
    
    // An interger to hold the next pizza´s id.
    static int nextId = 3;

    // Static constructor to initialize the Pizzas list.
    static PizzaService()
    {
        Pizzas = new List<Pizza>
        {
            new Pizza { Id = 1, Name = "Classic Italian", IsGlutenFree = false },
            new Pizza { Id = 2, Name = "Veggie", IsGlutenFree = true }
        };
    }

    // Method to get all pizzas.
    public static List<Pizza> GetAll() => Pizzas;

    // Method to get a specific pizza based on its id.
    public static Pizza? Get(int id) => Pizzas.FirstOrDefault(p => p.Id == id);

    // Method to add a new pizza.
    // It increments the nextId each time a new pizza is added.
    public static void Add(Pizza pizza)
    {
        pizza.Id = nextId++;
        Pizzas.Add(pizza);
    }

    // Method to delete a pizza based on its id.
    // It does nothing if the pizza with the given id is not found.
    public static void Delete(int id)
    {
        var pizza = Get(id);
        if(pizza is null)
            return;

        Pizzas.Remove(pizza);
    }

    // Method to update an existing pizza.
    // It does nothing if the pizza with the given id is not found.
    public static void Update(Pizza pizza)
    {
        var index = Pizzas.FindIndex(p => p.Id == pizza.Id);
        if(index == -1)
            return;

        Pizzas[index] = pizza;
    }
}