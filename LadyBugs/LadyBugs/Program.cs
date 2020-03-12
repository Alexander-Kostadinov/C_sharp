namespace LadyBugs
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var field = new int[size];

            int[] givenIndexes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            for (int i = 0; i < givenIndexes.Length; i++)
            {
                var currentIndex = givenIndexes[i];

                if (currentIndex < field.Length && currentIndex >= 0)
                {
                    field[currentIndex] = 1;
                } 
            }

            var command = Console.ReadLine();

            while (command != "end")
            {
                var splitedCommand = command.Split(" ");

                var index = int.Parse(splitedCommand[0]);
                var direcion = splitedCommand[1];
                var lenght = int.Parse(splitedCommand[2]);

                if (index < field.Length && index >= 0 && field[index] == 1)
                {
                    field[index] = 0;

                    if (direcion == "right")
                    {
                        while (index + lenght < field.Length && index + lenght >= 0)
                        {
                            if (field[index + lenght] == 0)
                            {
                                field[index + lenght] = 1;
                                break;
                            }

                            else
                            {
                                index += lenght;
                            }
                        }
                    }

                    else if (direcion == "left")
                    {
                        while (index - lenght >= 0 && index - lenght < field.Length)
                        {
                            if (field[index - lenght] == 0)
                            {
                                field[index - lenght] = 1;
                                break;
                            }

                            else
                            {
                                index -= lenght;
                            }
                        }
                    }

                    else
                    {
                        field[index] = 1;
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
