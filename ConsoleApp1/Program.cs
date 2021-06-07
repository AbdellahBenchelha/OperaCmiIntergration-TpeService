using System;
using ConsoleApp1.CMI;
using ConsoleApp1.Data;
using ConsoleApp1.Model;
using ConsoleApp1.SocketConnection;
using Grpc.Net.Client;
using PCARD_CLIB_45;
namespace ConsoleApp1
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {


            //CMI_Connection.PREAUTORISATION("1000.00");
            //CMI_Connection.Void_PAYMENT();



            //string DC1 = "";
            //string DC2 = "";
            //string DC3 = "";
            //PCARDAPI api = new PCARDAPI(1);
            //PCARDAPI.dDisplay = new PCARDAPI.dlgtOutPut(myDisplay);
            //PCARDAPI.dPrint = new PCARDAPI.dlgtOutPut(myPrint);
            //int rep;

          
             do {
                CMI_Connection.SignOn();
                Connection.StartReceiveLoop();

                //DC1 = "A000005200010002010002000201000300020100040004PCAR0005000200A001003200060002300007000205003500040180";
                //rep = api.SignOn(DC1, ref DC2, ref DC3);
                //Console.WriteLine("SignOn - DC2 : " + DC2 + "  -  DC3 : " + DC3);

                ////OpenSession
                //DC1 = "A0030012002A00040009";
                //rep = api.OpenSession(DC1, ref DC2, ref DC3);
                //Console.WriteLine("OpenSession - DC2 : " + DC2 + "  -  DC3 : " + DC3);

                ////Payment
                //string montant = "045000";
                //string currency = "504";
                //DC1 = "A0050156A0060062000C0006" + montant + "000D0003" + currency + "000E00010002A00040009A0070082A0080034000F000675432100100012150120095114A009003200110010869132451100120006122";
                //rep = api.Payment(DC1, ref DC2, ref DC3);
                //Console.WriteLine("Payment - DC2 : " + DC2 + "  -  DC3 : " + DC3);

                //RefillCard
                //DC1 = "A03A0105A03B0035000C0006100000003200012002A00040009A03C0054000F00067543210010001217101910193700110002140003000211";
                //rep = api.RefillCard(DC1, ref DC2, ref DC3);
                //Console.WriteLine("RefillCard - DC2 : " + DC2 + "  -  DC3 : " + DC3);

                ////Abort
                //DC1 = "A0150012002A00040009";
                //rep = api.Abort(DC1, ref DC2);
                //Console.WriteLine("Abort - DC2 : " + DC2);


                ////Void
                //DC1 = "A0160065A017002600290006123456002A00040009A0180023000F0006654321002800011";
                //rep = api.Void(DC1, ref DC2, ref DC3);
                //Console.WriteLine("Void - DC2 : " + DC2 + "  -  DC3 : " + DC3);

                ////CloseSession
                //DC1 = "A01C0012002A00040009";
                //rep = api.CloseSession(DC1, ref DC2, ref DC3);
                //Console.WriteLine("CloseSession - DC2 : " + DC2 + "  -  DC3 : " + DC3);

                //////ManualEndOfDay
                ////DC1 = "A01F0012002A00040009";
                ////rep = api.ManualEndOfDay(DC1, ref DC2, ref DC3);
                ////Console.WriteLine("ManualEndOfDay - DC2 : " + DC2 + "  -  DC3 : " + DC3);

                ////TotalReceipt
                //DC1 = "A0210031002A000400090003000201003400011";
                //rep = api.TotalReceipt(DC1, ref DC2, ref DC3);
                //Console.WriteLine("TotalReceipt - DC2 : " + DC2 + "  -  DC3 : " + DC3);

                ////TransactReceiptDuplicate
                //DC1 = "A023009800290006123456002B0012150406123526000F000665432100100012150406123743000300011002A00040009";
                //rep = api.TransactReceiptDuplicate(DC1, ref DC2, ref DC3);
                //Console.WriteLine("TransactReceiptDuplicate - DC2 : " + DC2 + "  -  DC3 : " + DC3);

                //DC1 = "A0240055000F000665432100100012150406130928000300011002A00040009";
                //rep = api.TransactStatus(DC1, ref DC2, ref DC3);
                //Console.WriteLine("TransactStatus - DC2 : " + DC2 + "  -  DC3 : " + DC3);

                ////EchoTest
                //DC1 = "A0260021002C00010002A00040009";
                //rep = api.EchoTest(DC1, ref DC2, ref DC3);
                //Console.WriteLine("EchoTest - DC2 : " + DC2 + "  -  DC3 : " + DC3);

                ////TransLog
                //DC1 = "A0280030000300011002D00010002A00040009";
                //rep = api.TransLog(DC1, ref DC2, ref DC3);
                //Console.WriteLine("TransLog - DC2 : " + DC2 + "  -  DC3 : " + DC3);

                ////ETopUp
                //DC1 = "A0300135A03A0067002A000634567800360004200000370012160217145400001100013003800041234A03B0052003900011A03C0035003A0006567890003B00042000003C00011";
                //rep = api.ETopUp(DC1, ref DC2, ref DC3);
                //Console.WriteLine("ETopUp - DC2 : " + DC2 + "  -  DC3 : " + DC3);
                } while (true);

        }

    }
}

