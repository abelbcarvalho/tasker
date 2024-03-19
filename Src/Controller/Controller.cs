using System.Numerics;
using IController;
using ModelTask;
using Priority;
using Service;

namespace Controller
{
    public class ControllerTasker : IControllerTasker
    {
        private readonly ServiceTasker servTasker = new();

        public TaskModel CreateTask(TaskModel tasker)
        {
            return this.servTasker.CreateTask(tasker);
        }

        public bool DeleteTasker(BigInteger id)
        {
            return this.servTasker.DeleteTasker(id);
        }

        public bool FinishTasker(BigInteger id)
        {
            return this.servTasker.FinishTasker(id);
        }

        public List<TaskModel> GetTaskersByTitle(string title)
        {
            return this.servTasker.GetTaskersByTitle(title);
        }

        public List<TaskModel> GetTaskersByPriority(EnumPriority priority)
        {
            return this.servTasker.GetTaskersByPriority(priority);
        }

        public List<TaskModel> GetTaskersByDateTimeStart(DateTime startAt)
        {
            return this.servTasker.GetTaskersByDateTimeStart(startAt);
        }

        public List<TaskModel> GetTaskersByDateTimeFinish(DateTime finishAt)
        {
            return this.servTasker.GetTaskersByDateTimeFinish(finishAt);
        }

        public List<TaskModel> GetTaskersByDateTimeStartAndFinish(DateTime startAt, DateTime finishAt)
        {
            return this.servTasker.GetTaskersByDateTimeStartAndFinish(startAt, finishAt);
        }

        public TaskModel GetTaskerById(BigInteger id)
        {
            return this.servTasker.GetTaskerById(id);
        }

        public TaskModel UpdateTasker(TaskModel tasker, BigInteger id)
        {
            return this.servTasker.UpdateTasker(tasker, id);
        }
    }
}