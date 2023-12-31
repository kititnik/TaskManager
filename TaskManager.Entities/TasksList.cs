using System.Collections;

namespace TaskManager.Entities;

public class TasksList : IEnumerable<Task>
{
    private List<Task> _tasks = new List<Task>();
    public IEnumerator<Task> GetEnumerator() => _tasks.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}