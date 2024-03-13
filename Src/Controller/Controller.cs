using System.Numerics;
using IController;
using ModelTask;
using Service;

namespace Controller
{
    public class ControllerTasker : IControllerTasker
    {
        private readonly ServiceTasker ServTasker = new();

        public TaskModel CreateTask(TaskModel tasker)
        {
            return this.ServTasker.CreateTask(tasker);
        }

        public void DeleteTasker(BigInteger id)
        {
            this.ServTasker.DeleteTasker(id);
        }

        public void FinishTasker(BigInteger id)
        {
            this.ServTasker.FinishTasker(id);
        }

        public List<TaskModel> GetTasker()
        {
            return this.ServTasker.GetTasker();
        }

        public TaskModel UpdateTasker(TaskModel tasker, BigInteger id)
        {
            return this.UpdateTasker(tasker, id);
        }
    }
}