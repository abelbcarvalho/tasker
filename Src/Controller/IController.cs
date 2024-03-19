using System.Numerics;
using ModelTask;
using Priority;

namespace IController
{
    public interface IControllerTasker
    {
        public abstract TaskModel CreateTask(TaskModel tasker);
        public abstract List<TaskModel> GetTaskersByTitle(string title);
        public abstract List<TaskModel> GetTaskersByPriority(EnumPriority priority);
        public abstract List<TaskModel> GetTaskersByDateTimeStart(DateTime startAt);
        public abstract List<TaskModel> GetTaskersByDateTimeFinish(DateTime finishAt);
        public abstract List<TaskModel> GetTaskersByDateTimeStartAndFinish(DateTime startAt, DateTime finishAt);
        public abstract TaskModel UpdateTasker(TaskModel tasker, BigInteger id);
        public abstract bool DeleteTasker(BigInteger id);
        public abstract bool FinishTasker(BigInteger id);
    }
}