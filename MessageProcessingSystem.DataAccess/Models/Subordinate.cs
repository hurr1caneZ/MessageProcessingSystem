namespace MessageProcessingSystem.DataAccess.Models;

public class Subordinate : Employee
{
    public Subordinate(Manager manager, string firstName, string lastName, Guid id) : base(firstName, lastName, id)
    {
        Messages = new List<Message>();
        Manager = manager;
    }
    public Manager Manager { get; internal set; }
    public virtual ICollection<Message> Messages { get; internal set; }
}