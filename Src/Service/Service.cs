using System.Numerics;
using IService;
using ModelTask;
using PersistenceTasker;
using Priority;
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

        public List<TaskModel> GetTaskersByTitle(string title)
        {
            return this.taskerPersistence.GetTaskersByTitle(title);
        }

        public List<TaskModel> GetTaskersByPriority(EnumPriority priority)
        {
            return this.taskerPersistence.GetTaskersByPriority(priority);
        }

        public List<TaskModel> GetTaskersByDateTimeStart(DateTime startAt)
        {
            return this.taskerPersistence.GetTaskersByDateTimeStart(startAt);
        }

        public List<TaskModel> GetTaskersByDateTimeFinish(DateTime finishAt)
        {
            return this.taskerPersistence.GetTaskersByDateTimeFinish(finishAt);
        }

        public List<TaskModel> GetTaskersByDateTimeStartAndFinish(DateTime startAt, DateTime finishAt)
        {
            return this.taskerPersistence.GetTaskersByDateTimeStartAndFinish(startAt, finishAt);
        }

        public TaskModel UpdateTasker(TaskModel tasker, BigInteger id)
        {
            throw new NotImplementedException();
        }
    }
}