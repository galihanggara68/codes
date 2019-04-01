interface IGun {
        void Shoot();
        void Reload();
        void FiringMode();
        void Scope();
    }

    interface IScope
    {
        void Zoom();
    }

    class DotSight : IScope {
        public void Zoom()
        {
            Console.WriteLine("Dot Sight Zooming");
        }
    }

    class HolographicSight : IScope {
        public void Zoom()
        {
            Console.WriteLine("Holographic Sight Zooming");
        }
    }

    class Rifle : IGun {
        private int ammo;
        private bool autoMode = false;
        private IScope sight;

        public IScope Sight {
            set
            {
                this.sight = value;
            }
            get
            {
                return this.sight;
            }
        }

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

        public void Scope() {
            this.sight.Zoom();
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

        public void Scope()
        {
            //
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
            IGun playerGun;
            Rifle rifle = new Rifle();
            HolographicSight sight = new HolographicSight();
            DotSight dotSight = new DotSight();

            playerGun = rifle;  // Player mengambil Rifle
            playerGun.Reload();
            playerGun.Shoot(); // Shoot();
            Console.WriteLine("Ammo Left : {0}", rifle.Ammo);
            playerGun.FiringMode();
            playerGun.Shoot(); // Shoot();
            Console.WriteLine("Ammo Left : {0}", rifle.Ammo);

            rifle.Sight = sight;
            playerGun.Scope();
            rifle.Sight = dotSight;
            playerGun.Scope();
            playerGun.Shoot();

            Console.ReadKey();
        }
    }