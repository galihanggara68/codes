class Alarm
    {
        private string bentuk;
        private string warna;
        private int[] dimensi;
        private string merk;
        private string baterai;

        public string Bentuk
        {
            get
            {
                return this.bentuk;
            }
            set
            {
                this.bentuk = value;
            }
        }
        public string Warna {
            get {
                return this.warna;
            }
            set {
                this.warna = value;
            }
        }

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
			Alarm AlarmObj = new Alarm { Bentuk="Bulat", Warna="Merah" };
            Console.WriteLine(AlarmObj.Warna);
            Console.WriteLine(AlarmObj.Bentuk);
			
            Alarm alarmObj = new Alarm();
            alarmObj.TampilkanSpek();
            alarmObj.MenunjukanWaktu();
            alarmObj.MengeluarkanSuara();
            alarmObj.MenggerakanJarum();

			Alarm[] alarmArr = { new Alarm { Bentuk="", Warna="" }, new Alarm { Warna="", Bentuk="" } };
            Alarm[] alarmArr2 = new Alarm[3];
            Alarm alarm = new Alarm();
            alarmArr2[0] = alarm;

            List<Alarm> listAlarm = new List<Alarm>();
            listAlarm.Add(alarm);
            listAlarm.Add(new Alarm { Bentuk="", Warna="" });
			
            Console.ReadKey();
        }
    }