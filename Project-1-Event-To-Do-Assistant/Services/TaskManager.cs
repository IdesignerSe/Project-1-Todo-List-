using EventTodoAssistant.Models;

namespace EventTodoAssistant.Services
{
    public class TaskManager
    {
        public List<TaskItem> Tasks { get; private set; } = new List<TaskItem>();

        public void AddTask(TaskItem task)
        {
            Tasks.Add(task);
        }

        public void RemoveTask(int index)
        {
            if (index >= 0 && index < Tasks.Count)
                Tasks.RemoveAt(index);
        }

        public TaskItem? GetTask(int index)
        {
            if (index >= 0 && index < Tasks.Count)
                return Tasks[index];

            return null;
        }

        public void SortByDate()
        {
            Tasks = Tasks.OrderBy(t => t.DueDate).ToList();
        }

        public void SortByProject()
        {
            Tasks = Tasks.OrderBy(t => t.Project).ToList();
        }
    }
}
