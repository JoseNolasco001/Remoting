using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace RemoteServer
{
    internal class RemoteServer
    {
        static void Main(string[] args)
        {
            TcpChannel chan = new TcpChannel(8085);
            ChannelServices.RegisterChannel(chan,false);

            RemotingConfiguration.RegisterWellKnownServiceType(System.Type.GetType("ServerClass.myRemoteClass, ServerClass"), "RemoteTest", WellKnownObjectMode.SingleCall);

            System.Console.WriteLine("Hit <enter> to exit...");
            System.Console.ReadLine();
        }

    }
}
