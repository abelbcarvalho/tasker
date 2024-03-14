using System.Numerics;
using IService;
using ModelTask;
using UtilDateTime;
using UtilString;

namespace Service
{
    public class ServiceTasker : IServiceTasker
    {
        public TaskModel CreateTask(TaskModel tasker)
        {
            StringUtil.IsNotEmptyString(tasker.Title, "Title");
            DateTimeUtil.IsNotStartGreaterThanFinish(tasker.StartAt, tasker.FinishAt);

            return tasker;
        }

        public void DeleteTasker(BigInteger id)
        {
            throw new NotImplementedException();
        }

        public void FinishTasker(BigInteger id)
        {
            throw new NotImplementedException();
        }

        public List<TaskModel> GetTasker()
        {
            throw new NotImplementedException();
        }

        public TaskModel UpdateTasker(TaskModel tasker, BigInteger id)
        {
            throw new NotImplementedException();
        }
    }
}