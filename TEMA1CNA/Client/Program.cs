using System;
using System.Threading.Tasks;
using Grpc.Net.Client;
using Server;

namespace Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string name;
            name = Console.ReadLine();
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);

            var clientName = new HelloRequest { Name = name };
            await client.SayHelloAsync(clientName);
           Console.ReadLine(); //Teoretic ar trebui sa nu se inchida consola imediat dupa ce primeste numele dar dupa 3 rebuilds 
            //oricum nu se inchide dupa ce dau numele nici cu linia comentata, am lasat-o totusi asa ca sa nu am surprize
        }
    }
}
