using System.Numerics;
using IController;
using ModelTask;
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

        public void DeleteTasker(BigInteger id)
        {
            this.servTasker.DeleteTasker(id);
        }

        public void FinishTasker(BigInteger id)
        {
            this.servTasker.FinishTasker(id);
        }

        public List<TaskModel> GetTasker()
        {
            return this.servTasker.GetTasker();
        }

        public TaskModel UpdateTasker(TaskModel tasker, BigInteger id)
        {
            return this.servTasker.UpdateTasker(tasker, id);
        }
    }
}