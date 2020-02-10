using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
namespace Wifi_Drop
{
    class Program
    {
        private void AvailabilityChanged(object sender, NetworkAvailabilityEventArgs e)
        {
            if (e.IsAvailable)
                Console.WriteLine("Network connected!");
            else
                Console.WriteLine("Network dis connected!");
        }
        public void Open()
        {
            NetworkChange.NetworkAvailabilityChanged += AvailabilityChanged;
        }

        private void Close()
        {
            NetworkChange.NetworkAvailabilityChanged -= AvailabilityChanged;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Open();
            Console.ReadLine();
            p.Close();
        }
    }
}