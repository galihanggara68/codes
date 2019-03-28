class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(args[0]);
            int position = int.Parse(args[1]);

            for(int i = 0; i < count; i++) {
                if(position != 1 && position != 3) {
                    if(position == 2)
                    {
                        for(int x = count-i; x > 0; x--)
                        {
                            Console.Write(" ");
                        }
                    }
                    else {
                        for(int x = 0; x < i; x++)
                        {
                            Console.Write(" ");
                        }
                    }
                }
                if(position == 1 || position == 2)
                {
                    for(int j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }
                }
                else {
                    for(int j = count-i; j > 0; j--)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }