class Alarm
    {
        private string bentuk = "Bulat";
        private string warna = "Putih";
        private int[] dimensi = { 15, 10, 5 };
        private string merk = "Casio";
        private string baterai = "AA";

        public void MenunjukanWaktu()
        {
            Console.WriteLine(DateTime.Now);
        }

        public void MengeluarkanSuara()
        {
            Console.WriteLine("Beep .. Beep ... Beep");
        }

        public void MenggerakanJarum()
        {
            Console.WriteLine("Menggerakan Jarum");
        }

        public void TampilkanSpek()
        {
            Console.WriteLine("==Spesifikasi :");
            Console.WriteLine("Bentuk : {0}", this.bentuk);
            Console.WriteLine("Dimensi : {0}", this.dimensi);
            Console.WriteLine("Merk : {0}", this.merk);
            Console.WriteLine("Warna : {0}", this.warna);
            Console.WriteLine("Baterai : {0}", this.baterai);
        }
    }
	
class Program
    {
        static void Main(string[] args)
        {
            Alarm alarmObj = new Alarm();
            alarmObj.TampilkanSpek();
            alarmObj.MenunjukanWaktu();
            alarmObj.MengeluarkanSuara();
            alarmObj.MenggerakanJarum();

            Console.ReadKey();
        }
    }