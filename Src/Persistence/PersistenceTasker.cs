using System.Numerics;
using Database;
using IPersistenceTasker;
using ModelTask;

namespace PersistenceTasker
{
    public class TaskerPersistence : ITaskerPersistence
    {
        public TaskModel CreateTask(TaskModel tasker)
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

        public void DeleteTasker(BigInteger id)
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
        }

        public void FinishTasker(BigInteger id)
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