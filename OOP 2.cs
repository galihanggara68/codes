class Program
    {
        static void Main(string[] args)
        {
            Alarm alarm = new Alarm();
            Baterai baterai = new Baterai();
            baterai.Kapsitas = 35;

            alarm.Baterai = baterai;
            Console.WriteLine(alarm.Baterai.Kapsitas);

            //int jam = alarm.AmbilWaktu("jam");
            //jam *= 2;
            //Console.WriteLine(jam);

            if(alarm.GetKondisiAlarm())
            {
                if(alarm.Baterai.Kapsitas < 40)
                {
                    Console.WriteLine("Baterai Melemah");
                }
                else
                {
                    Console.WriteLine(alarm.MenunjukanWaktu());
                }
            }
            else {
                Console.WriteLine("Alarm Mati, hidupkan terlebih dahulu");
            }

            Console.ReadKey();
        }
    }