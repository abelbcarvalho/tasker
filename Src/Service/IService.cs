using System.Numerics;
using ModelTask;
using Priority;

namespace IService
{
    public interface IServiceTasker
    {
        public abstract TaskModel CreateTask(TaskModel tasker);
        public abstract List<TaskModel> GetTaskersByTitle(string title);
        public abstract List<TaskModel> GetTaskersByPriority(EnumPriority priority);
        public abstract List<TaskModel> GetTaskersByDateTimeStart(DateTime startAt);
        public abstract List<TaskModel> GetTaskersByDateTimeFinish(DateTime finishAt);
        public abstract List<TaskModel> GetTaskersByDateTimeStartAndFinish(DateTime startAt, DateTime finishAt);
        public abstract TaskModel UpdateTasker(TaskModel tasker, BigInteger id);
        public abstract void DeleteTasker(BigInteger id);
        public abstract void FinishTasker(BigInteger id);
    }
}