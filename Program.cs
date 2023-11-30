

namespace App
{
    class TodoList
    {
        static void ShowMenuTodo()
        {
            
            Console.WriteLine("Welcome to Todo-list: ");
            Console.WriteLine("---------------------");
            Console.WriteLine("Manual todolist");
            Console.WriteLine("Add - Please enter A");
            Console.WriteLine("Delete - Please enter D");
            Console.WriteLine("Edit - Please enter E");
            Console.WriteLine("Exit in menu - Q");
            Console.WriteLine("---------------------");
        }

        static void ShowTodolist(List<string?> todoList)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Todolist: ");
            
            foreach (var todo in todoList)
            {
                Console.WriteLine(todo);
            }
        }

        static void Add(List<string?> todoList, string? task)
        {
            string? haveTodoIsTask = todoList.Find((item) => item == task);

            if (haveTodoIsTask == task)
            {
                throw new Exception("Have this todo in todolist");
            }

            todoList.Add(task);
        }

        static void Edit(List<string?> todoList, string? task, string? newTask)
        {
            int idxFoundTask = todoList.FindIndex((item) => item == task);
            if (idxFoundTask == -1)
            {
                throw new Exception("Not found this todo for edit");
            }

            if (task == "" || newTask == "")
            {
                throw new Exception("Not have task or new task for edit");
            }

            todoList[idxFoundTask] = newTask;
        }

        static void Delete(List<string?> todoList, string? task)
        {
            int idxFoundTask = todoList.FindIndex((item) => item == task);

            if (idxFoundTask == -1)
            {
                throw new Exception("Not found this todo for delete");
            }

            todoList.RemoveAt(idxFoundTask);
        }

        static void Main(string[] args)
        {
            List<string?> todoList = new List<string?>(); // general list for todolist
            bool isPressedKey = true; // pressed key

            ShowMenuTodo(); // MENU

            try
            {
                do
                {
                    Console.Write("Please enter your key: ");
                    var key = Console.ReadKey();

                    if (key.Key == ConsoleKey.A) // add task
                    {
                        Console.WriteLine();
                        Console.Write("Please enter your task: ");
                        string? task = Console.ReadLine();

                        bool taskNotString = task != null && task.All(char.IsNumber);
                   
                        if (taskNotString)
                        {
                            throw new Exception("This task not string");
                        }

                        Add(todoList, task);
                    }
                    else if (key.Key == ConsoleKey.E) // edit
                    {
                        Console.WriteLine();
                        Console.Write("Please enter your task: ");
                        string? task = Console.ReadLine();
                        Console.Write("Please enter your new task: ");
                        string? newTask = Console.ReadLine();

                        Edit(todoList, task, newTask);
                    }
                    else if (key.Key == ConsoleKey.D) // delete
                    {
                        Console.WriteLine();
                        Console.Write("Please enter your task: ");
                        string? task = Console.ReadLine();

                        Delete(todoList, task);
                    }
                    else if (key.Key == ConsoleKey.Q)
                    {
                        Console.WriteLine();
                        isPressedKey = false;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Not correct key");
                        isPressedKey = false;
                    }
                } while (isPressedKey);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                ShowTodolist(todoList);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}