using ServerClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            myRemoteClass remoteObj = (myRemoteClass)Activator.GetObject(typeof(myRemoteClass), "tcp://localhost:8085/RemoteTest");

            while (true)
            {
                Console.WriteLine("\nEscriba un mensaje");
                string txt = Console.ReadLine();
                bool message = remoteObj.SetString(txt);
            }
            Console.ReadLine();
        }
    }
}
