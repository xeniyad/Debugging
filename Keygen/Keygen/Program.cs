using System;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace Keygen
{
    class Program
    {
        static void Main(string[] args)
        {
             byte[] addressBytes = NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault().GetPhysicalAddress().GetAddressBytes();
            byte[] dateBytes = BitConverter.GetBytes(DateTime.Now.Date.ToBinary());

            var bytes = addressBytes.Select((a, index) => a ^ dateBytes[index]).Select(a => a * 10);

            

            Console.WriteLine(string.Join("-", bytes));
        }
    }
}
