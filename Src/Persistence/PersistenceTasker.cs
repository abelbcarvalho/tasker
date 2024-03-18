using System.Numerics;
using Database;
using IPersistenceTasker;
using ModelTask;
using PriorityEnumUtil;

namespace PersistenceTasker
{
    public class TaskerPersistence : ITaskerPersistence
    {
        public TaskModel CreateTask(TaskModel tasker)
        {
            try
            {
                DatabaseConnectione.OpenConnection();

                using var command = DatabaseConnectione.Command(
                    "insert into Taskers (title, description, priority, startAt, finishAt) values (@title,@description,@priority,@startAt,@finishAt)"
                );

                command.Parameters.AddWithValue("@title", tasker.Title);
                command.Parameters.AddWithValue("@description", tasker.Description);
                command.Parameters.AddWithValue("@priority", PriorityUtil.EnumValueString(tasker.Priority));
                command.Parameters.AddWithValue("@startAt", tasker.StartAt);
                command.Parameters.AddWithValue("@finishAt", tasker.FinishAt);

                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                DatabaseConnectione.CloseConnection();
            }

            return tasker;
        }

        public void DeleteTasker(BigInteger id)
        {
            try
            {
                DatabaseConnectione.OpenConnection();

                using var command = DatabaseConnectione.Command(
                    "delete from Taskers where id=@id"
                );

                command.Parameters.AddWithValue("@id", id);

                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                DatabaseConnectione.CloseConnection();
            }
        }

        public void FinishTasker(BigInteger id)
        {
            try
            {
                DatabaseConnectione.OpenConnection();

                using var command = DatabaseConnectione.Command(
                    "update Taskers set complete=@complete"
                );

                command.Parameters.AddWithValue("@complete", true);

                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                DatabaseConnectione.CloseConnection();
            }
        }

        public List<TaskModel> GetTasker()
        {
            try
            {
                DatabaseConnectione.OpenConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                DatabaseConnectione.CloseConnection();
            }

            return [];
        }

        public TaskModel UpdateTasker(TaskModel tasker, BigInteger id)
        {
            try
            {
                DatabaseConnectione.OpenConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                DatabaseConnectione.CloseConnection();
            }

            return tasker;
        }
    }
}