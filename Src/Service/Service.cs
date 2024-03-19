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

        public bool DeleteTasker(BigInteger id)
        {
            return this.taskerPersistence.DeleteTasker(id);
        }

        public bool FinishTasker(BigInteger id)
        {
            return this.taskerPersistence.FinishTasker(id);
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
            DateTimeUtil.IsNotStartGreaterThanFinish(startAt, finishAt);

            return this.taskerPersistence.GetTaskersByDateTimeStartAndFinish(startAt, finishAt);
        }

        public TaskModel GetTaskerById(BigInteger id)
        {
            return this.taskerPersistence.GetTaskerById(id);
        }

        public TaskModel UpdateTasker(TaskModel tasker, BigInteger id)
        {
            return this.taskerPersistence.UpdateTasker(tasker, id);
        }
    }
}