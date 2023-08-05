namespace sem7_hw;
using vgnamespace;
class Program
{
    static void Main(string[] args)
    {
        IO.CC();
        //Задача 47. Задайте двумерный массив размером m×n, 
        //заполненный случайными вещественными числами, округлёнными до одного знака.
        // m = 3, n = 4.
        // 0,5 7 -2 -0,2
        // 1 -3,3 8 -9,9
        // 8 7,8 -7,1 9
        void Task47()
        {
            int[] UsrInput = IO.MultiInputInt("Введите размерность массива");
            double[,] Arr = new double[UsrInput[0], UsrInput[1]];
            IO.GenRndArrVal(Arr, -10, 9, 1);
            IO.PrintArr(Arr, "Сгенерирован массив:", "\t");
        }
        //Задача 50. Напишите программу, которая на вход принимает индексы элемента в 
        //двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
        void Task50()
        {
            int RLength = 6;
            int CLength = 7;
            int[,] Arr = new int[RLength, CLength];
            IO.GenRndArrVal(Arr, 0, 100);
            IO.PrintArr(Arr, "Сгенерирован массив:", "\t");
            int[] UsrInput = IO.MultiInputInt("Введите индексы элемента массива");
            if (UsrInput[0] >= 0 && UsrInput[0] < RLength && UsrInput[1] >= 0 && UsrInput[1] < CLength)
                Console.WriteLine(Arr[UsrInput[0], UsrInput[1]]);
                else Console.WriteLine("Заданный индекс находится за пределами размеров массива.");



        }
        //Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
        void Task52()
        {
            int[] UsrInput = IO.MultiInputInt("Введите размерность массива");
            int[,] Arr = new int[UsrInput[0], UsrInput[1]];
            double[] AvrArr = new double[UsrInput[1]];
            IO.GenRndArrVal(Arr, 0, 10);
            //for (int Rows = 0; Rows < Arr.GetLength(0); Rows++)
            for (int Columns = 0, Sum = 0; Columns < Arr.GetLength(1); Columns++, Sum = 0)
            {
                for (int Rows = 0; Rows < Arr.GetLength(0); Rows++)
                {
                    Sum += Arr[Rows, Columns];
                }
                AvrArr[Columns] = Math.Round((double)Sum / Arr.GetLength(0), 2);
            }



            IO.PrintArr(Arr, "Сгенерирован массив и выведены средние значения столбцов:", "\t");
            string division = "";
            for (int i = 0; i < AvrArr.Length; i++)
                division += "========";
            Console.WriteLine(division);
            IO.PrintArr(AvrArr, "", "\t");

        }


        //Task47();
        //Task50();
        //Task52();


/*
        VGMenu menu = new VGMenu();
        menu.Create();
        menu.AddItem("Задача 47.",
        "Задайте двумерный массив размером mxn, заполненный случайными вещественными числами, округлёнными до одного знака.");
        menu.AddItem("Задача 50.",
        "Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
        menu.AddItem("Задача 52.",
        "Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
        //Console.WriteLine(menu.GetTest(2));
        menu.Execute();
        */
        
    


    }
}
