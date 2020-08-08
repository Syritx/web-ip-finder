using System;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace WebPing
{
    class MainClass {
        public static void Main(string[] args) {

            Task webip = new Task(GetWebsiteIPAddr);
            webip.Start();
            webip.Wait();

            Console.ReadKey();
        }
        
        static async void GetWebsiteIPAddr() {

            string webURL = "google.com";
            Ping ping = new Ping();

            try {
                PingReply pingRep = await ping.SendPingAsync(webURL);

                Console.WriteLine("The address for: {0} is {1} \nRuntime: {2}s",
                            webURL,pingRep.Address,pingRep.RoundtripTime/1000);
            }catch(Exception e) { Console.WriteLine(e.Message); }
        }
    }
}
