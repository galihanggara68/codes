class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string>[] orangs = new Dictionary<string, string>[3];

            Dictionary<string, string> orang = new Dictionary<string, string>();
            orang.Add("nama", "Dadang");
            orang.Add("alamat", "Bandung");
            orangs[0] = orang;
            orang.Add("kelamin", "L");

            Dictionary<string, string> orang2 = new Dictionary<string, string>();
            orang2.Add("nama", "Ujang");
            orang2.Add("alamat", "Bandung");
            orangs[1] = orang2;

            Dictionary<string, string> orang3 = new Dictionary<string, string>();
            orang3.Add("nama", "Pelacore");
            orang3.Add("alamat", "Bandung");
            orangs[2] = orang3;

            foreach(Dictionary<string, string> or in orangs) {
                Console.WriteLine("{0} {1}", or["nama"], or["alamat"]);
            }

            Console.ReadKey();
        }
    }