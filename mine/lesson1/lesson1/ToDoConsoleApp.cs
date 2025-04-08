//using System;
//using System.Threading.Tasks;
//namespace ToDoConsoleApp
//{
//    class ToDoConsoleApp
//    {
//        static void ToDoEngine(string[] args)
//        {
//            List<string> ToDoList = new List<string>();
//            while (true)
//            {
//                int selection = mainMenu();
//                if (selection == 0)
//                {
//                    break;
//                }
//                else if (selection == 1)
//                {
//                    Console.WriteLine("Add To Do");
//                    Console.Write("Please enter your To Do: ");
//                    string todo = Console.ReadLine();
//                    ToDoList.Add(todo);
//                    Console.WriteLine($"To Do '{todo}' added successfully.");
//                }
//                else if (selection == 2)
//                {
//                    if (ToDoList.Count == 0)
//                    {
//                        Console.WriteLine("To Do list is empty.");
//                    }
//                    else
//                    {
//                        Console.WriteLine("To Do list:");
//                        for (int i = 0; i < ToDoList.Count; i++)
//                        {
//                            Console.WriteLine($"{i + 1}. {ToDoList[i]}");
//                        }
//                    }
//                }
//                else if (selection == 3)
//                {
//                    Console.WriteLine("Remove To Do by id");
//                    if (ToDoList.Count == 0)
//                    {
//                        Console.WriteLine("ToDo not Found!!!\nPlease enter ToDo before");
//                        continue;
//                    }
//                    else
//                    {
//                        Console.WriteLine("To Do list:");
//                        for (int i = 0; i < ToDoList.Count; i++)
//                        {
//                            Console.WriteLine($"{i + 1}. {ToDoList[i]}");
//                        }
//                    }
//                    Console.Write("Please enter the id of the To Do to remove: ");
//                    string input = Console.ReadLine();
//                    int id;
//                    if (int.TryParse(input, out id) && id > 0 && id <= ToDoList.Count)
//                    {
//                        string removedTodo = ToDoList[id - 1];
//                        ToDoList.RemoveAt(id - 1);
//                        Console.WriteLine($"To Do '{removedTodo}' removed successfully.");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Invalid id. Please try again.");
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Invalid selection. Please try again.");
//                }
//            }
//        }
//        static int mainMenu()
//        {
//            Console.WriteLine("==================");
//            Console.WriteLine("1. Add To Do");
//            Console.WriteLine("2. Show To Do list");
//            Console.WriteLine("3. Remove To Do by id");
//            Console.WriteLine("0. Exit App");
//            Console.Write("\nPlease enter your selection:\n");
//            Console.WriteLine("==================");
//            string input = Console.ReadLine();
//            int selection;
//            int.TryParse(input, out selection);
//            return selection;
//        }
//    }
//}