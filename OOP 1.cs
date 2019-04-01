class Baterai {
        private int kapasitas;
        private int[] dimensi;

        public int Kapsitas
        {
            get
            {
                return this.kapasitas;
            }
            set
            {
                this.kapasitas = value;
            }
        }
    }

    class Alarm
    {
        public static int totalAlarm = 0;
        public static string machineCode = "EAX00FF";
        private string bentuk;
        private string warna;
        private int[] dimensi;
        private string merk;
        private Baterai baterai;
        private int jam = 12;
        private int menit = 5;
        private int detik = 30;
        private bool hidup = false;

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
        public Baterai Baterai
        {
            get
            {
                return this.baterai;
            }
            set
            {
                this.baterai = value;
            }
        }

        public Alarm() {
            totalAlarm++;
            Console.WriteLine("Objek Alarm Dibuat");
            Console.WriteLine("Memasang Baterai");
            this.baterai = new Baterai { Kapsitas = 100 };
            Console.WriteLine("Menyalakan Alarm . . .");
            this.hidup = true;
            this.bentuk = "Kotak";
            Console.WriteLine("Alarm Siap Digunakan, dengan kapasitas baterai " + this.baterai.Kapsitas);
            Console.WriteLine("Machine Code : " + machineCode);
        }

        public Alarm(Baterai baterai, bool hidupkan) {
            totalAlarm++;
            this.baterai = baterai;
            Console.WriteLine("Baterai dimasukan, dengan kapasitas " + baterai.Kapsitas);
            this.hidup = hidupkan;
            Console.WriteLine("Alarm " + (hidupkan ? "dihidupkan" : "tidak dihidupkan" ));
            Console.WriteLine("Machine Code : " + machineCode);
        }

        public static void Count() {
            Console.WriteLine("Total Alarm : " + totalAlarm);
        }

        public string MenunjukanWaktu()
        {
            return DateTime.Now.ToString();
        }

        public int AmbilWaktu(string waktu) {
            switch(waktu)
            {
                case "jam":
                    return this.jam;
                    break;
                case "menit":
                    return this.menit;
                    break;
                case "detik":
                    return this.detik;
                    break;
                default:
                    return -1;
                    break;
            }
        }

        public bool GetKondisiAlarm() {
            return this.hidup;
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
	
// With Constructor and Static Member
class Program
    {
        static void Main(string[] args)
        {
            Baterai baterai = new Baterai { Kapsitas = 75 };
            Alarm alarm = new Alarm(baterai, false);
            Alarm.Count();
            Alarm alarm2 = new Alarm();
            Alarm.Count();
            Alarm.machineCode = "MOVFFF0X";
            Alarm alarm3 = new Alarm();
            Alarm.Count();
            Alarm alarm4 = new Alarm();
            Alarm.Count();

            Console.ReadKey();
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