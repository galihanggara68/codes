class Program
    {
        static void Main(string[] args)
        {
            string[] genres = { "Pop", "Jazz", "Dangdut" };
            string[,] musicArray = {
                { "Menunggu", "Saya", "3 menit", "Pop" },
                { "Menanti", "Dia", "2 menit", "Pop"  },
                { "Mengharap", "Kamu", "4 menit", "Pop"  },
                { "Menempati", "Kita", "3.2 menit", "Jazz" },
                { "Menghuni", "Aku", "4.1 menit", "Jazz" },
                { "Memiliki", "Mereka", "2.4 menit", "Jazz" },
                { "Mempunyai", "Orang", "3 menit", "Dangdut" },
                { "Menyimpan", "Aku", "1 menit", "Dangdut" },
                { "Menyandang", "Dia", "2 menit", "Dangdut" },
            };

            List<Dictionary<string, string>> musics = new List<Dictionary<string, string>>();

            for(int i = 0; i < musicArray.GetLength(0); i++) {
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("nama", musicArray[i, 0]);
                dict.Add("artis", musicArray[i, 1]);
                dict.Add("durasi", musicArray[i, 2]);
                dict.Add("genre", musicArray[i, 3]);
                musics.Add(dict);
            }

            for(int i = 0; i < genres.Length; i++) {
                Console.WriteLine("-{0}:", genres[i]);
                foreach(Dictionary<string, string> music in musics)
                {
                    if(music["genre"].Equals(genres[i]))
                    {
                        Console.WriteLine("={0} {1} {2}", music["nama"], music["artis"], music["durasi"]);
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }