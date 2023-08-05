using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vgnamespace
{
    public class VGMenu
    {
        //PRIVATE 
        private List<string> TaskNameList = new List<string>();
        private List<string> TaskDescriptionList = new List<string>();

        //private List<string> TaskStatementList = new List<string>();
        //private int ItemCount = 0;
        //METHODS
        private void PrintMenu()
        {
            Console.Clear();
            for (int i = 0; i < TaskNameList.Count; i++)
            {
                string Flag = "[ ]";
                string TaskName = "";

                string TaskDescr1 = TaskDescriptionList[i];
                string TaskDescr2 = "";
                if (TaskDescr1.Length > Console.WindowWidth - 20)
                {
                    TaskDescr2 = TaskDescr1.Substring(Console.WindowWidth - 20, TaskDescr1.Length - Console.WindowWidth + 20);
                    TaskDescr1 = TaskDescr1.Substring(0, Console.WindowWidth - 20);
                }
                Console.SetCursorPosition(0, i * 2);
                Console.Write(Flag);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(4, i * 2);
                Console.Write(TaskNameList[i]);
                Console.ResetColor();
                Console.SetCursorPosition(20, i * 2);
                Console.Write(TaskDescr1);
                Console.SetCursorPosition(20, (i * 2) + 1);
                Console.Write(TaskDescr2);
            }

        }


        //PUBLIC
        public int SelItem = 0;
        //METHODS
        public void AddItem(string TaskName, string TaskDescription)
        {
            TaskNameList.Add(TaskName);
            TaskDescriptionList.Add(TaskDescription);
            //TaskStatementList.Add(TaskStatement);
            //ItemCount++;
        }
        public void AddSysItem()
        { }
        public int Execute()
        {
            PrintMenu();
            ConsoleKeyInfo KeyInfo;
            if (Console.KeyAvailable) // Обработка нажатия клавиш
            {
                KeyInfo = Console.ReadKey(true);
                if (KeyInfo.Key == ConsoleKey.DownArrow)
                {
                    
                }
                if (KeyInfo.Key == ConsoleKey.UpArrow)
                {

                }
                if (KeyInfo.Key == ConsoleKey.Enter)
                {

                }
                

                if (KeyInfo.Key == ConsoleKey.Q)
                {

                }

            }
            return 0;
        }
        public void Create()
        {

        }

        public string GetTest(int Index)
        {
            return TaskNameList[Index];
        }

    }
}