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
                    "insert into Taskers (title, description, priority, complete, startAt, finishAt) values (@title,@description,@priority,@complete,@startAt,@finishAt)"
                );

                command.Parameters.AddWithValue("@title", tasker.Title);
                command.Parameters.AddWithValue("@description", tasker.Description);
                command.Parameters.AddWithValue("@priority", PriorityUtil.EnumValueString(tasker.Priority));
                command.Parameters.AddWithValue("@complete", tasker.Complete);
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
            List<TaskModel> taskers = new();
            try
            {
                DatabaseConnectione.OpenConnection();

                using var command = DatabaseConnectione.Command(
                    "select * from Taskers"
                );

                using var resultSet = command.ExecuteReader();

                while (resultSet.Read())
                {
                    TaskModel model = new()
                    {
                        Id = resultSet.GetInt32(0),
                        Title = resultSet.GetString(1),
                        Description = resultSet.GetString(2),
                        Priority = PriorityUtil.EnumFromString(resultSet.GetString(3)),
                        Complete = resultSet.GetBoolean(4),
                        StartAt = resultSet.GetDateTime(5),
                        FinishAt = resultSet.GetDateTime(6)
                    };

                    taskers.Add(model);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                DatabaseConnectione.CloseConnection();
            }

            return taskers;
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