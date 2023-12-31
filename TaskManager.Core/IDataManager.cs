namespace TaskManager.Core;

public interface IDataManager
{
    public Task<Guid> SaveTask(Entities.Task task);
    public Task<Entities.Task> GetTaskById(Guid id);
    public Task DeleteTask(Guid id);
}