class Program
    {
        static void Main(string[] args)
        {
            string nama = args[0];

            try
            {
                switch(nama)
                {
                    case "persegipanjang":
                        {
                            if(args.Length > 3)
                                throw new ArgumentOutOfRangeException();
                            int p, l, hasil;
                            p = int.Parse(args[1]);
                            l = int.Parse(args[2]);
                            hasil = p * l;
                            Console.WriteLine("Luas Persegi Panjang : ({0}x{1}) = {2}", p, l, hasil);
                        }
                        break;
                    case "lingkaran":
                        {
                            const double PI = 3.14;
                            double r = int.Parse(args[1]);
                            double hasil = PI * (r * r);
                            Console.WriteLine("Luas Lingkaran : ({0}x({1}^2)) = {2}", PI, r, hasil);
                        }
                        break;
                }
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Argument terlalu sedikit");
            }
            catch(ArgumentOutOfRangeException e) {
                Console.WriteLine("Argument terlalu banyak");
            }

            Console.ReadKey();
        }
    }