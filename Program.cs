using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.Security.Claims;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
            menu:
                Console.Title = "discord webhook tool v0.1";
                looksnice();
                menu();
                ConsoleKeyInfo cki = Console.ReadKey();
                char optioncki = cki.KeyChar;
                Console.Write(optioncki);
                string option  = optioncki.ToString();
                if (option == "1") ;
                {
                   
                    dcmessage();
                    Console.Clear();
                    goto menu;
                    
                }
                if (option == "2")
                {
                    
                    goto changelog1;
                changelog1:
                    Console.Clear();
                    webclientdownloader();

                    
                }
                else
                {
                    break;
                }


            }
            static void looksnice()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@"

     ----                    .___                     ___.   .__                   __       __               
  __| _/____   __  _  __ ____\_ |__ |  |__   ____   ____ |  | __ _/  |_  ____   ____ |  |  
 / __ |/ ___\  \ \/ \/ // __ \| __ \|  |  \ /  _ \ /  _ \|  |/ / \   __\/  _ \ /  _ \|  |  
/ /_/ \  \___   \     /\  ___/| \_\ \   Y  (  <_> |  <_> )    <   |  | (  <_> |  <_> )  |__
\____ |\___  >   \/\_/  \___  >___  /___|  /\____/ \____/|__|_ \  |__|  \____/ \____/|____/
     \/    \/               \/    \/     \/                   \/                                                                                                                            
                                                                        
                  -PRIVATE TOOL----------------------------------------------------


            ");

            }
            static void menu()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"
            1 - send a discord webhook message
            2 - view change log
            3 - quit
            ");
            }
            
            static async void webclientdownloader()
            {
                string changelog = "";

                try
                {
                    Console.Title = "changelog";
                    changelog = new WebClient().DownloadString("https://raw.githubusercontent.com/APLLOTHEDEV/simpledcwebhooktool/refs/heads/main/data");
                    Console.WriteLine(changelog);

                }
                catch
                {
                    Console.WriteLine("error while downloading changelog");
                    Console.Write("press any key to quit:");
                    Console.ReadKey();
                   
                }
            }
            static async void dcmessage()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("WEBHOOK URL :");
                string discordwebhook = Console.ReadLine();

                Console.Write("WEBHOOK MESSAGE : ");
                string discordmessage = Console.ReadLine();

                string json = $"{{\"content\":\"{discordmessage}\"}}";

            while (true) {

                    
                        HttpClient hc = new HttpClient();
                        HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
                        await hc.PostAsync(discordwebhook, content);


                    
                }



            }


        }
    }
}