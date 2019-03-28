class Program
    {
        static void Main(string[] args)
        {
            string[] genres = { "Dangdut", "Jazz", "Pop" };
            string[,] musics = new string[3, 4] {
                {
                    "Dangdut",
                    "Via Vallen - Sayang",
                    "Iis Dahlia - Tak Mampu Membencimu",
                    "Rhoma Irama - Judi"
                },
                {
                    "Jazz",
                    "Take Five - Dave Brubeck",
                    "So What - Miles Davis",
                    "Take The A Train - Duke Ellington"
                },
                {
                    "Pop",
                    "Another Night - Real McCoy",
                    "Smooth - Santana Featuring Rob Thomas",
                    "Hanging By A Moment - Lifehouse"
                }
            };

            //for(int i = 0; i < genres.Length; i++)
            //{
            //    Console.WriteLine("-{0} :", genres[i]);
            //    for(int j = 0; j < musics.GetLength(1); j++)
            //    {
            //        Console.WriteLine("={0}", musics[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            for(int i = 0; i < musics.GetLength(0); i++)
            {
                Console.WriteLine("-{0} :", musics[i, 0]);
                for(int j = 1; j < musics.GetLength(1); j++)
                {
                    Console.WriteLine("={0}", musics[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }