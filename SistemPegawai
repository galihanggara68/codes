// Add, View, Delete
    // OOP
    // Try Catch

    class SistemPegawai {
        // Array / List
        private List<Dictionary<string, string>> listPegawai;

        public SistemPegawai()
        {
            listPegawai = new List<Dictionary<string, string>>();
        }

        public void Add(Dictionary<string, string> pegawai)
        {
            listPegawai.Add(pegawai);
        }

        public void Add(string nama, string nip, string jabatan)
        {
            Dictionary<string, string> pegawai = new Dictionary<string, string>() {
                ["nip"] = nip,
                ["nama"] = nama,
                ["jabatan"] = jabatan
            };
            listPegawai.Add(pegawai);
        }

        public void View()
        {
            Console.WriteLine("NIP\tNama\tJabatan");
            foreach(var pegawai in listPegawai)
            {
                Console.Write("{0}\t{1}\t{2}\n", pegawai["nip"], pegawai["nama"], pegawai["jabatan"]);
            }
        }

        public void Delete(int index)
        {
            try
            {
                listPegawai.RemoveAt(index);
            }catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Data Tidak Ada");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SistemPegawai sp = new SistemPegawai();
            sp.Delete(0);
            sp.View();
            Console.ReadKey();
        }
    }
