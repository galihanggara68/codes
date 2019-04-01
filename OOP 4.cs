interface IGun {
        void Shoot();
        void Reload();
        void FiringMode();
    }

    class Rifle : IGun {
        private int ammo;
        private bool autoMode = false;

        public int Ammo
        {
            get
            {
                return this.ammo;
            }
            set
            {
                this.ammo = value;
            }
        }

        public void Shoot()
        {
            Console.WriteLine("Rifle Shooting . . .");
            if(autoMode)
            {
                ammo -= 5;
            }
            else
            {
                ammo--;
            }
        }

        public void Reload()
        {
            Console.WriteLine("Rifle Reloading . . .");
            ammo = 30;
        }

        public void FiringMode()
        {
            Console.WriteLine("Mode : {0}", (this.autoMode ? "Auto" : "Single"));
            this.autoMode = !this.autoMode;
        }
    }

    class Pistol : IGun
    {
        private int ammo;
        private bool autoMode = false;

        public int Ammo
        {
            get
            {
                return this.ammo;
            }
            set
            {
                this.ammo = value;
            }
        }

        public void Shoot()
        {
            Console.WriteLine("Pistol Shooting . . .");
            if(autoMode)
            {
                ammo -= 3;
            }
            else
            {
                ammo--;
            }
        }

        public void Reload()
        {
            Console.WriteLine("Pistol Reloading . . .");
            ammo = 6;
        }

        public void FiringMode()
        {
            Console.WriteLine("Mode : {0}", (this.autoMode ? "Auto" : "Single" ));
            this.autoMode = !this.autoMode;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pistol pistol = new Pistol();
            Rifle rifle = new Rifle();

            IGun playerGun;
            playerGun = pistol; // Player mengambil Pistol
            playerGun.Reload();
            playerGun.Shoot(); // Shoot();
            Console.WriteLine("Ammo Left : {0}", pistol.Ammo);
            playerGun.FiringMode();
            playerGun.Shoot(); // Shoot();
            Console.WriteLine("Ammo Left : {0}", pistol.Ammo);

            playerGun = rifle;  // Player mengambil Rifle
            playerGun.Reload();
            playerGun.Shoot(); // Shoot();
            Console.WriteLine("Ammo Left : {0}", rifle.Ammo);
            playerGun.FiringMode();
            playerGun.Shoot(); // Shoot();
            Console.WriteLine("Ammo Left : {0}", rifle.Ammo);

            Console.ReadKey();
        }
    }