Project-1-Todo List 

## Project Brief ##
Your task is to build a todo list application. The application will allow a user to create new tasks, 
assign them a title and due date, and choose a project for that task to belong to. They will need 
to use a text based user interface via the command-line. Once they are using the application, 
the user should be able to also edit, mark as done or remove tasks. They can also quit and save 
the current task list to file, and then restart the application with the former state restored. The 
interface should look similar to the mockup below: 

## Requirements ##
The solution must achieve the following requirements: 
 Model a task with a task title, due date, status and project 
 Display a collection of tasks that can be sorted both by date and project 
 Support the ability to add, edit, mark as done, and remove tasks 
 Support a text-based user interface
 Load and save task list to file The solution may also include other creative features at 
your discretion in case you wish to show some flair.

## Making the TODO-LIST ##
I intent to do to a version that is Event oriente.
Using a Calender per month gets the holidays giving the opportunity to create the event.
An Ai subgest how to build the list. 
User give the ok to the suggested list. or add his own.

## Bonus: AI assistant ##
The Idea is start already to connect AI services also If is possible mimic a small one inside.

🧱 Features / Core To‑Do List

Add tasks

Edit tasks

Mark tasks as done

Remove tasks

Sort by date

Sort by project

Display all tasks

✔ File Persistence
Save tasks to a .txt file

Load tasks on startup

Each task stored as one line:
Title|2026-06-21|Midsummer|Pending

✔ AI Integration
Enter an event name

AI generates suggestions

Split‑screen console layout

Import suggestions into your list

✔ Clean Architecture
Separate class files

Models, Services, UI layers

Easy to extend

/EventTodoAssistant
│
├── Models
│   └── TaskItem.cs
│
├── Services
│   ├── TaskManager.cs
│   ├── AISuggestionService.cs
│   └── DisplayService.cs
│
├── UI
│   └── MenuUI.cs
│
├── Program.cs
└── tasks.txt


+------------------+
|    TaskItem      |
+------------------+
| Title            |
| DueDate          |
| Project          |
| Status           |
+------------------+
| MarkCompleted()  |
| UpdateTitle()    |
| UpdateDate()     |
| UpdateProject()  |
+------------------+

            1..*
              |
              v

+----------------------+
|     TaskManager      |
+----------------------+
| Tasks: List<TaskItem>|
+----------------------+
| AddTask()            |
| RemoveTask()         |
| EditTask()           |
| SortByDate()         |
| SortByProject()      |
| SaveToFile()         |
| LoadFromFile()       |
+----------------------+

+----------------------+
| AISuggestionService  |
+----------------------+
| Suggestions: List<string> |
+----------------------+
| GetSuggestions()     |
| FormatSuggestions()  |
+----------------------+

+----------------------+
|    DisplayService    |
+----------------------+
| ShowSplitScreen()    |
| DrawLine()           |
+----------------------+

+----------------------+
|       MenuUI         |
+----------------------+
| ShowMainMenu()       |
| HandleUserInput()    |
| PromptForTaskInfo()  |
| ShowAISuggestions()  |
+----------------------+
