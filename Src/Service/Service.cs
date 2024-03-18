using System.Numerics;
using IService;
using ModelTask;
using PersistenceTasker;
using PriorityEnumUtil;
using UtilDateTime;
using UtilString;

namespace Service
{
    public class ServiceTasker : IServiceTasker
    {
        private readonly TaskerPersistence taskerPersistence = new();

        public TaskModel CreateTask(TaskModel tasker)
        {
            StringUtil.IsNotEmptyString(tasker.Title, "Title");
            DateTimeUtil.IsNotStartGreaterThanFinish(tasker.StartAt, tasker.FinishAt);
            PriorityUtil.IsUnknow(tasker.Priority);

            return this.taskerPersistence.CreateTask(tasker);
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