namespace TaskManager.Core;

public interface ICore
{
    public Task<Guid> SaveTaskToData(Entities.Task task);
    public Task<Entities.Task> GetTaskById(Guid id);
    public Task DeleteTaskFromData(Guid id);
    public Task<Entities.TasksList> GetTasksList();
}