namespace HomeWork4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowNumber, colNumber;
            while (true)
            {
                Console.WriteLine("Введите количество строк: ");
                var userInput = Console.ReadLine();
                int.TryParse(userInput, out rowNumber);

                Console.WriteLine("Введите количество столбцов: ");
                userInput = Console.ReadLine();
                int.TryParse(userInput, out colNumber);

                if (rowNumber != default && colNumber != default)
                {
                    Console.Clear();

                }
                else
                {
                    break;
                }


                int[,] array = new int[rowNumber, colNumber];

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.WriteLine("Введите элемент массива: ");
                        string element = Console.ReadLine();
                        array[i, j] = int.Parse(element);
                    }
                }
                Console.Clear();


                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write($"{array[i, j]} ");
                    }
                    Console.WriteLine();
                }


                Console.WriteLine("Выберите желаемое действие : " +
                    "1 - найти количество положительных элементов в матрице\n" +
                    "2 - найти количество отрицательных элементов в матрице\n" +
                    "3 - сортировка элементов матрицы по возрастанию\n" +
                    "4 - сортировка элементов матрицы по убыванию\n" +
                    "5 - инверсия элементов матрицы");

                string choice = Console.ReadLine();


                switch (choice)
                {
                    case "1":
                        {
                            int positiveCount = 0;
                            for (int i = 0; i < array.GetLength(0); i++)
                            {
                                for (int j = 0; j < array.GetLength(1); j++)
                                {
                                    if (array[i, j] > 0)
                                    {
                                        positiveCount++;
                                    }
                                }
                                Console.WriteLine($"Количество положительных элементов в массиве: {positiveCount}");
                                Console.ReadLine();
                                Console.Clear();

                            }
                            break;
                        }
                    case "2":
                        {
                            int negativeCount = 0;
                            for (int i = 0; i < array.GetLength(0); i++)
                            {
                                for (int j = 0; j < array.GetLength(1); j++)
                                {
                                    if (array[i, j] < 0)
                                    {
                                        negativeCount++;
                                    }
                                }
                                Console.WriteLine($"Количество отрицательных элементов в массиве: {negativeCount = 0}");
                                Console.ReadLine();
                                Console.Clear();
                            }
                            break;
                        }
                    case "3":
                        {
                            for (int i = 0; i < array.GetLength(0); i++)
                            {
                                for (int j = 0; j < array.GetLength(1); j++)
                                {
                                    for (int k = 0; k < array.GetLength(1) - 1; k++)
                                    {
                                        if ((array[i, k] > array[i, k + 1]))
                                        {
                                            int temp = array[i, k];
                                            array[i, k] = array[i, k + 1];
                                            array[i, k + 1] = temp;

                                        }

                                    }
                                }
                            }
                            for (int i = 0; i < array.GetLength(0); i++)
                            {
                                for (int j = 0; j < array.GetLength(1); j++)
                                {
                                    Console.Write(array[i, j] + " ");
                                }
                                Console.WriteLine();
                            }
                        }
                        break;

                    case "4":
                        {
                            for (int i = 0; i < array.GetLength(0); i++)
                            {
                                for (int j = 0; j < array.GetLength(1); j++)
                                {
                                    for (int k = 0; k < array.GetLength(1) - j - 1; k++)
                                    {
                                        if (array[i, k] < array[i, k + 1])
                                        {
                                            int temp = array[i, k];
                                            array[i, k] = array[i, k + 1];
                                            array[i, k + 1] = temp;
                                        }

                                    }
                                }
                            }

                            for (int i = 0; i < array.GetLength(0); i++)
                            {
                                for (int j = 0; j < array.GetLength(1); j++)
                                {
                                    Console.Write(array[i, j] + " ");
                                }
                                Console.WriteLine();
                            }
                        }
                        break;



                    case "5":
                        {
                            for (int i = 0; i < array.GetLength(0); i++)
                            {
                                int str = array.GetLength(1) / 2;
                                for (int j = 0; j < str; j++)
                                {
                                    int temp = array[i, j];
                                    array[i, j] = array[i, array.GetLength(1) - 1 - j];
                                    array[i, array.GetLength(1) - 1 ] = temp;
                                }
                            }

                            for (int i = 0; i < array.GetLength(0); i++)
                            {
                                for (int j = 0; j < array.GetLength(1); j++)
                                {
                                    Console.Write(array[i, j] + " ");
                                }
                                Console.WriteLine();
                            }
                        }
                        break;
                }
            }
        }

    }
}
            
       

    

