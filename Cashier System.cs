using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
// github.com/galihanggara68/codes
namespace HelloCSharp
{
    // Class Item (Model)
    class Item {
        private string kode;
        private string nama;
        private int stock;
        private long harga;

        public string Kode
        {
            set
            {
                this.kode = value;
            }
            get
            {

                return this.kode;
            }
        }

        public string Nama
        {
            set
            {
                this.nama = value;
            }
            get
            {

                return this.nama;
            }
        }

        public int Stock
        {
            set
            {
                this.stock = value;
            }
            get
            {

                return this.stock;
            }
        }

        public long Harga
        {
            set
            {
                this.harga = value;
            }
            get
            {

                return this.harga;
            }
        }
    }

    class DetailTransaction
    {
        private Item item;
        private int quantity;

        public Item Item
        {
            get
            {
                return this.item;
            }
            set
            {
                this.item = value;
            }
        }

        public int Quantity
        {
            get
            {
                return this.quantity;
            }
            set
            {
                this.quantity = value;
            }
        }

        public long SubTotal()
        {
            return this.item.Harga * this.quantity;
        }
    }

    class Transaction
    {
        private string id;
        private List<DetailTransaction> detailTransactions;

        public List<DetailTransaction> DetailTransactions
        {
            get
            {
                return this.detailTransactions;
            }
            set
            {
                this.detailTransactions = value;
            }
        }

        public Transaction()
        {
            Random random = new Random();
            id = "TRX-"+random.Next(1, 1000);
        }
    }

    class Cart
    {
        private List<DetailTransaction> items;

        public List<DetailTransaction> Items
        {
            set
            {
                this.items = value;
            }
            get
            {
                return this.items;
            }
        }

        public Cart()
        {
            items = new List<DetailTransaction>();
        }

        public void AddItem(Item item, int quantity)
        {
            if(items != null)
            {
                items.Add(new DetailTransaction { Item = item, Quantity = quantity });
            }
        }

        public void AddItem(DetailTransaction item)
        {
            if(items != null)
            {
                items.Add(item);
            }
        }

        public void ShowCart()
        {
            Console.WriteLine("Kode\t|\tNama\t|\tQuantity\t|\tSubtotal\t");
            foreach(DetailTransaction item in items)
            {
                Console.WriteLine("{0}\t|\t{1}\t|\t{2}\t|\t{3}", item.Item.Kode, item.Item.Nama, item.Quantity, item.SubTotal());
            }
            Console.WriteLine(TotalCost());
        }

        public void UpdateQuantity(Item item, int quantity)
        {
            foreach(DetailTransaction i in items)
            {
                if(i.Item.Kode.Equals(item.Kode)) i.Quantity = quantity;
            }
        }

        public void RemoveCart()
        {
            if(items.Count > 0)
                items.RemoveRange(0, items.Count - 1);
        }

        public void RemoveCart(int index)
        {
            if(items.Count > 0)
                items.RemoveAt(index);
        }

        public void RemoveCart(Item item)
        {
            if(items.Count > 0)
                items.Remove(new DetailTransaction { Item=item });
        }

        public void Checkout()
        {
            // Database
            // Clear Cart
            // Print Total Cost
        }

        public long TotalCost()
        {
            long totalCost = 0;
            foreach(DetailTransaction item in items)
            {
                totalCost += item.SubTotal();
            }
            return totalCost;
        }
    }

    class Program
    {
        static void Main(string[] args) {
            int pilihan;
            List<Item> items = new List<Item>
            {
                new Item{ Kode="B001", Harga=2000, Nama="Saus", Stock=10},
                new Item{ Kode="B002", Harga=5000, Nama="Pasta Gigi", Stock=20},
                new Item{ Kode="B003", Harga=7000, Nama="Shampo", Stock=15}
            };
            Cart cart = new Cart();
            Transaction transaction = new Transaction();
            do
            {
                pilihan = int.Parse(Console.ReadLine());
                
                switch(pilihan)
                {
                    // Add Item
                    case 1:
                        {
                            foreach(Item item in items)
                            {
                                Console.WriteLine("{0} {1} {2} {3}", item.Kode, item.Nama, item.Harga, item.Stock);
                            }
                            Console.WriteLine("Masukan Kode Barang : ");
                            string kodeBarang = Console.ReadLine();
                            Item it = (from i in items where i.Kode==kodeBarang select i).FirstOrDefault();
                            Console.WriteLine("Quantity : ");
                            cart.AddItem(it, int.Parse(Console.ReadLine()));
                        }
                        break;
                    // Show Cart
                    case 2:
                        cart.ShowCart();
                        break;
                    // Update Qty
                    case 3:
                        {
                            foreach(Item item in items)
                            {
                                Console.WriteLine("{0} {1} {2} {3}", item.Kode, item.Nama, item.Harga, item.Stock);
                            }
                            Console.WriteLine("Masukan Kode Barang : ");
                            string kodeBarang = Console.ReadLine();
                            Item it = (from i in items where i.Kode == kodeBarang select i).FirstOrDefault();
                            Console.WriteLine("Quantity : ");
                            cart.UpdateQuantity(it, int.Parse(Console.ReadLine()));
                        }
                        break;
                    // Delete
                    case 4:
                        break;
                    // Checkout
                    case 5:
                        List<DetailTransaction> details = new List<DetailTransaction>();
                        foreach(DetailTransaction dt in cart.Items)
                        {
                            details.Add(dt);
                        }
                        transaction.DetailTransactions = details;
                        cart.Checkout();
                        break;
                }
            } while(pilihan != 6);
            
        }
    }
}
