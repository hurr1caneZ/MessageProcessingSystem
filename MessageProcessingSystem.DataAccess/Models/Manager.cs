namespace MessageProcessingSystem.DataAccess.Models;

public class Manager : Employee
{
    public Manager(string firstName, string lastName, Guid id)
        : base(firstName, lastName, id)
    {
        Subordinates = new List<Subordinate>();
        Reports = new List<Report>();
    }
    
    public virtual ICollection<Subordinate> Subordinates { get; internal set; }
    public virtual ICollection<Report> Reports { get; internal set; }
}