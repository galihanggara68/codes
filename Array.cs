class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2,3];
 
            for(int i = 0; i < arr.GetLength(0); i++) {
                for(int j = 0; j < arr.GetLength(1); j++) {
                    arr[i, j] = i * j;
                }
            }

            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine(arr[i, j]);
                }
            }

            Console.ReadKey();
        }
    }