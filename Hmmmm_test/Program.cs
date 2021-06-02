using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Hmmmm_test
{
    class Program
    {
        static void Main(string[] args)
        {
            //StartServer(); unkoment later
            Task.Delay(1000).Wait();


            //Client
            var client = new NamedPipeClientStream("PipesOfPiece");
            client.Connect();
            StreamReader reader = new StreamReader(client);
            StreamWriter writer = new StreamWriter(client);

            while (true)
            {
                string input = Console.ReadLine();
                if (String.IsNullOrEmpty(input)) break;
                writer.WriteLine(input);
                writer.Flush();
                Console.WriteLine(reader.ReadLine());
            }
        }
        //public static string story = "Once, there was a boy who became bored when he watched over the village sheep grazing on the hillside. To entertain himself, he sang out, “Wolf! Wolf! The wolf is chasing the sheep!” When the villagers heard the cry, they came running up the hill to drive the wolf away.But, when they arrived, they saw no wolf. The boy was amused when seeing their angry faces. “Don’t scream wolf, boy,” warned the villagers, “when there is no wolf!” They angrily went back down the hill. Later, the shepherd boy cried out once again, “Wolf! Wolf! The wolf is chasing the sheep!” To his amusement, he looked on as the villagers came running up the hill to scare the wolf away...... Pls pay to know the end of the story :)";

        /*static void StartServer()
        {
            Task.Factory.StartNew(() =>
            {
                var server = new NamedPipeServerStream("PipesOfPiece");
                server.WaitForConnection();
                StreamReader reader = new StreamReader(server);
                StreamWriter writer = new StreamWriter(server);   
                while (true)
                {
                    var line = reader.ReadLine();
                    string line2 = "";
                    if (line2 == "gn")
                    {
                        Thread.Sleep(3000);
                        Environment.Exit(0);
                    }
                    line2 = line;
                    switch (line2)
                    {
                        case "Hello":
                        case "Hi":
                            writer.WriteLine(String.Join("", $"Ala: Hello my friend!"));
                            break;
                        case "How are you?":
                        case "How re u?":
                        case "hru?":
                            writer.WriteLine(String.Join("", $"Ala: Im fine, thanks. And you?"));
                            break;
                        case "gn":
                            writer.WriteLine(String.Join("", $"Ala: Bye bye..."));
                            break;
                        case "I want 5":
                            writer.WriteLine(String.Join("", $"Ala: Really? Pozdrawiam!"));
                            break;
                        case "console.hack(Ala)":
                            writer.WriteLine(String.Join("", $"Ala: Really? Try one more time!"));
                            break;
                        case "story":
                            writer.WriteLine(String.Join("", $"Ala: "+ story));
                            break;
                        case "thanks":
                            writer.WriteLine(String.Join("", $"Ala: You re welcome!"));
                            break;
                        default:
                            writer.WriteLine(String.Join("", $"Ala: You re good boy!"));
                            break;
                    }
                   
                    
                    writer.Flush();
                }
                
            });
        }*/


    }
}
