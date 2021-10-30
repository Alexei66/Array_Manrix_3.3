using System;

namespace Matrix_3._3
{
    class Program
    {
        // *** Задание 3.3
        // Заказчику требуется приложение позволяющщее перемножать математические матрицы
        // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
        // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матриц
        // Добавить возможность ввода количество строк и столцов матрицы.
        // Матрицы заполняются автоматически
        // Если по введённым пользователем данным действие произвести нельзя - сообщить об этом
        //  
        //  |  1  3  5  |   |  1  3  4  |   | 22  48  57  |
        //  |  4  5  7  | х |  2  5  6  | = | 35  79  95  |
        //  |  5  3  1  |   |  3  6  7  |   | 14  36  45  |
        //
        //  
        //                  | 4 |   
        //  |  1  2  3  | х | 5 | = | 32 |
        //                  | 6 |  
        //

        static int CheckValue()
        {
            int correctValue;
            while (!int.TryParse(Console.ReadLine(), out correctValue))
            {
                Console.WriteLine("Неправильно! Попробуй еще раз.");
            }
            return correctValue;
        }


        static void Main(string[] args)
        {
            Console.Write("Введите кол-во строк = ");
            int line1;

            do
            {
                line1 = CheckValue();
                if (line1 <= 0)
                {
                    Console.WriteLine("Неправильно! Попробуй еще раз.");
                }
            } while (line1 <= 0);

            Console.Write("Введите кол-во столбцов = ");
            
            int column1;
            do
            {
                column1 = CheckValue();
                if (column1 <= 0)
                {
                    Console.WriteLine("Неправильно! Попробуй еще раз.");
                }
            } while (column1 <= 0);

            Random rand = new Random();

            int[,] array1 = new int[line1, column1];

            Console.WriteLine("\n---|ARRAY-1|---\n");
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    array1[i, j] = rand.Next(1, 16);
                    Console.Write($"{array1[i, j],4}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            Console.Write("Введите кол-во строк = ");
            int line2;

            do
            {
                line2 = CheckValue();
                if (line2 <= 0)
                {
                    Console.WriteLine("Неправильно! Попробуй еще раз.");
                }
            } while (line2 <= 0);

            Console.Write("Введите кол-во столбцов = ");

            int column2;
            do
            {
                column2 = CheckValue();
                if (column2 <= 0)
                {
                    Console.WriteLine("Неправильно! Попробуй еще раз.");
                }
            } while (column2 <= 0);

            int[,] array2 = new int[line2, column2];

            Console.WriteLine("---|ARRAY-2|---\n");
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    array2[i, j] = rand.Next(-15, 21);
                    Console.Write($"{array2[i, j],4}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            if (array1.GetLength(1) != array2.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");   // генерация исключения, когда строки != столбцам 
            int[,] arraySum = new int[line1, column2];

            Console.WriteLine("---|ARRAY-Multiplication|---\n");
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    //arraySum[i, j] = 0;
                    for (int k = 0; k < array2.GetLength(0); k++)
                    {
                        arraySum[i, j] += array1[i, k] * array2[k, j] ;
                        
                    }
                    Console.Write($"{arraySum[i, j],5}");

                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
