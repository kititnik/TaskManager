namespace TaskManager.Entities;

public class Task
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public Project Project { get; private set; }
    public Priority Priority { get; private set; }
    public DateTime DueDate { get; private set; }

    public Task(string name, Project project, Priority priority, DateTime dueDate)
    {
        Id = Guid.NewGuid();
        Name = name;
        Project = project;
        Priority = priority;
        DueDate = dueDate;
    }

    public void UpdateProject(Project project)
    {
        Project = project;
    }
    
    public void UpdatePriority(Priority priority)
    {
        Priority = priority;
    }

    public void UpdateName(string name)
    {
        if (!string.IsNullOrWhiteSpace(name))
            Name = name;
        else throw new ArgumentException("Name is not valid");
    }

    public void UpdateDueDate(DateTime dueDate)
    {
        DueDate = dueDate;
    }
}