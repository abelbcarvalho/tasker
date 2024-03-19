using ModelTask;
using Priority;

namespace TaskModelUtil
{
    public class ModelTaskUtil
    {
        public static void ModelToDefault(TaskModel taskModel)
        {
            taskModel.Id = 0;
            taskModel.Title = "";
            taskModel.Description = "";
            taskModel.Priority = EnumPriority.Unknown;
            taskModel.StartAt = default(DateTime);
            taskModel.FinishAt = default(DateTime);
        }
    }
}