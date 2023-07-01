using Microsoft.EntityFrameworkCore;

namespace MessageProcessingSystem.DataAccess.Models;

public abstract class Employee
{
    

    public Employee(string firstName, string lastName, Guid id)
    {
        if (firstName is null || lastName is null)
        {
            throw new ArgumentException("null penis work");
        }
        
        FirstName = firstName;
        LastName = lastName;
        Id = id;
    }
    
    

    public string FirstName { get; internal set; }
    public string LastName { get; internal set; }
    public Guid Id { get; internal set; }





}