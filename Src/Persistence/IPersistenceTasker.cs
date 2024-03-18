using System.Numerics;
using ModelTask;

namespace IPersistenceTasker
{
    public interface ITaskerPersistence
    {
        public abstract TaskModel CreateTask(TaskModel tasker);
        public abstract List<TaskModel> GetTasker();
        public abstract TaskModel UpdateTasker(TaskModel tasker, BigInteger id);
        public abstract void DeleteTasker(BigInteger id);
        public abstract void FinishTasker(BigInteger id);
    }
}