namespace ContosoPizza.Models;

// The Pizza class represents a pizza in the ContosoPizza application.
public class Pizza 
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsGlutenFree { get; set; }
}