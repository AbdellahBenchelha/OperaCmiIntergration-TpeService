using ConsoleApp1.CMI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.SocketConnection
{
    public class Connection
    {
        private static Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public static void StartReceiveLoop()
        {
            try
            {
                // Change IPAddress.Loopback to a remote IP to connect to a remote host.
                clientSocket.Connect(IPAddress.Loopback, 3333);

                while (true)
                {
                    Console.Write("Waiting message ");
                    var buffer = new byte[2048];
                    int received = clientSocket.Receive(buffer);

                    // Shrink the buffer so we don't get null chars in the text.
                    Array.Resize(ref buffer, received);
                    string receivedMsg = Encoding.ASCII.GetString(buffer);
                    // Reset the buffer.
                    Array.Resize(ref buffer, clientSocket.ReceiveBufferSize);
                    Console.WriteLine("Message received: " + receivedMsg);
                    Console.WriteLine("Message received: " + receivedMsg);
                    Console.WriteLine("Message received: " + receivedMsg);
                    Console.WriteLine("Message received: " + receivedMsg);
                    CheckReceivedMessage(receivedMsg);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Console.Clear();
                StartReceiveLoop();
            }
        }
        private static void CheckReceivedMessage(string message)
        {
            string reponse = message.Substring(0,2);
            Console.WriteLine(message);
            if (reponse == "#P")//PAYMENT
            {
                Console.WriteLine("Amount");
                string montant = GetKeyValue(message, "MN");
                Console.WriteLine("Amount" + montant);
                Console.WriteLine("Currency");
                string currency = GetKeyValue(message, "CR");

                
                Console.WriteLine("Currency" + currency);
                Console.WriteLine("Amount : " + montant +" "+ currency);
                string data = CMI_Connection.Payment(montant, currency);
                Console.WriteLine("Data from TPF : "+ data);
                SendLoop(data);
            }
            if (reponse == "#A")//PREAUTORISATION
            {
                Console.WriteLine("Amount");
                string montant = GetKeyValue(message, "MN");
                Console.WriteLine("Amount" + montant);
                Console.WriteLine("Currency");
                string currency = GetKeyValue(message, "CR");


                Console.WriteLine("Currency" + currency);
                Console.WriteLine("Amount : " + montant + " " + currency);
                string data = CMI_Connection.PREAUTORISATION(montant, currency);
                Console.WriteLine("Data from TPF : " + data);
                SendLoop(data);
            }
            if (reponse == "#W")//PREAUTORISATION Confirmation
            {
                Console.WriteLine("Amount");
                string montant = GetKeyValue(message, "MN");
                Console.WriteLine("Amount" + montant);
                Console.WriteLine("Currency");
                string currency = GetKeyValue(message, "CR");


                Console.WriteLine("Currency" + currency);
                Console.WriteLine("Amount : " + montant + " " + currency);
                string data = CMI_Connection.PREAUTORISATION_Confirmation(montant, currency);
                Console.WriteLine("Data from TPF : " + data);
                SendLoop(data);
            }
            if (reponse == "#C")
            {
                
                string data = CMI_Connection.Void_PREAUTORISATION();
                Console.WriteLine("Data from TPF : " + data);
                SendLoop(data);
            }
        }

        private static string GetKeyValue(string message, string key)
        {
            string data = null;
            if (message.IndexOf(key) != -1)
            {
                data = message.Substring(message.IndexOf(key), message.Length - message.IndexOf(key));
                data = data.Substring(data.IndexOf(key), data.IndexOf("|"));
                data = data.Remove(0, 2);
            }

            return data;
        }
        private static void SendLoop(string message)
        {
            clientSocket.Send(Encoding.ASCII.GetBytes(message));
        }
    }
}
