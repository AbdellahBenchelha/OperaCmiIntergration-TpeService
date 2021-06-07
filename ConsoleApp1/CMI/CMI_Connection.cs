using ConsoleApp1.Data;
using ConsoleApp1.Model;
using PCARD_CLIB_45;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CMI
{
    public static class CMI_Connection
    {
        static PCARDAPI api = new PCARDAPI(1);
        static string DC1 = "";
        static string DC2 = "";
        static string DC3 = "";
        static int rep;
        static int myDisplay(string Msg)
        {
            Console.WriteLine("Message :  " + Msg);

            return 0;
        }
        static int myPrint(string Tckt)
        {
            //Console.WriteLine("---Ticket Debut--- :  " + Tckt+ "---Ticket Debut---");
            return 0;
        }

        public static void SignOn()
        {
            //SignOn
            PCARDAPI.dDisplay = new PCARDAPI.dlgtOutPut(myDisplay);
            PCARDAPI.dPrint = new PCARDAPI.dlgtOutPut(myPrint);

            //SignOn ECR->EFT
            //A000
            SIGN_ON.TAG_SIGN_ON_REQUEST_DATA_LENGHT = "0052";

            //0001
            SIGN_ON.TAG_PROTOCOL_VER_LENGHT = "0002";
            SIGN_ON.TAG_PROTOCOL_VER_VALUE = "01";

            //0002
            SIGN_ON.TAG_ECR_FAB_LENGHT = "0002";
            SIGN_ON.TAG_ECR_FAB_VALUE = "01";

            //0003
            SIGN_ON.TAG_ECR_NUM_LENGHT = "0002";
            SIGN_ON.TAG_ECR_NUM_VALUE = "0002";

            //0004
            SIGN_ON.TAG_PWD_LENGHT = "0002";
            SIGN_ON.TAG_PWD_VALUE = "01";

            //0005
            SIGN_ON.TAG_ECR_INPUT_OPT_LENGHT = "0002";
            SIGN_ON.TAG_ECR_INPUT_OPT_VALUE = "00";

            //A001
            SIGN_ON.TAG_TIME_OUTS_LENGHT = "0032";


            //0006
            SIGN_ON.TAG_TRANS_TIME_OUT_LENGHT = "0002";
            SIGN_ON.TAG_TRANS_TIME_OUT_VALUE = "30";


            //0007
            SIGN_ON.TAG_OPER_TIME_OUT_LENGHT = "0002";
            SIGN_ON.TAG_OPER_TIME_OUT_VALUE = "05";

            //0035
            SIGN_ON.TAG_END_OF_DAY_TIME_OUT_LENGHT = "0004";
            SIGN_ON.TAG_END_OF_DAY_TIME_OUT_VALUE = "0180";




            DC1 = SIGN_ON.TAG_SIGN_ON_REQUEST_DATA_ID +
            SIGN_ON.TAG_SIGN_ON_REQUEST_DATA_LENGHT +
            SIGN_ON.TAG_PROTOCOL_VER_ID +
            SIGN_ON.TAG_PROTOCOL_VER_LENGHT +
            SIGN_ON.TAG_PROTOCOL_VER_VALUE +
            SIGN_ON.TAG_ECR_FAB_ID +
            SIGN_ON.TAG_ECR_FAB_LENGHT +
            SIGN_ON.TAG_ECR_FAB_VALUE +
            SIGN_ON.TAG_ECR_NUM_ID +
            SIGN_ON.TAG_ECR_NUM_LENGHT +
            SIGN_ON.TAG_ECR_NUM_VALUE +
            SIGN_ON.TAG_PWD_ID +
            SIGN_ON.TAG_PWD_LENGHT +
            SIGN_ON.TAG_PWD_VALUE +
            SIGN_ON.TAG_ECR_INPUT_OPT_ID +
            SIGN_ON.TAG_ECR_INPUT_OPT_LENGHT +
            SIGN_ON.TAG_ECR_INPUT_OPT_VALUE +
            SIGN_ON.TAG_TIME_OUTS_ID +
            SIGN_ON.TAG_TIME_OUTS_LENGHT +
            SIGN_ON.TAG_TRANS_TIME_OUT_ID +
            SIGN_ON.TAG_TRANS_TIME_OUT_LENGHT +
            SIGN_ON.TAG_TRANS_TIME_OUT_VALUE +
            SIGN_ON.TAG_OPER_TIME_OUT_ID +
            SIGN_ON.TAG_OPER_TIME_OUT_LENGHT +
            SIGN_ON.TAG_OPER_TIME_OUT_VALUE +
            SIGN_ON.TAG_END_OF_DAY_TIME_OUT_ID +
            SIGN_ON.TAG_END_OF_DAY_TIME_OUT_LENGHT +
            SIGN_ON.TAG_END_OF_DAY_TIME_OUT_VALUE;

            L_SIGNON :
               rep = api.SignOn(DC1, ref DC2, ref DC3);
            string reponse_result = SplitSocketData.GetValueKey(DC2, "0008");
            if (!reponse_result.Equals("0000"))
            {
                Console.WriteLine("Exception Error : Cannot Sign On to TPE ");
                goto L_SIGNON;
            }

            Console.WriteLine("SignOn - DC2 : " + DC2 + "  -  DC3 : " + DC3);
        }
        static void OpenSession()
        {
            //A003
            OPEN_SESSION.TAG_OPEN_SESSION_REQUEST_DATA_LENGHT = "0012";

            //002A
            OPEN_SESSION.TAG_SESSION_ID_ECR_LENGHT = "0004";
            OPEN_SESSION.TAG_SESSION_ID_ECR_VALUE = "0009";
            //OpenSession
            DC1 = OPEN_SESSION.TAG_OPEN_SESSION_REQUEST_DATA_ID +
                OPEN_SESSION.TAG_OPEN_SESSION_REQUEST_DATA_LENGHT +
                OPEN_SESSION.TAG_SESSION_ID_ECR_ID +
                OPEN_SESSION.TAG_SESSION_ID_ECR_LENGHT +
                OPEN_SESSION.TAG_SESSION_ID_ECR_VALUE;

        L_OPENSESSION:
            rep = api.OpenSession(DC1, ref DC2, ref DC3);

            string reponse_result = SplitSocketData.GetValueKey(DC2, "0008");
            if (!reponse_result.Equals("0000"))
            {
                Console.WriteLine("Exception Error : Cannot Open Session to TPE ");
                goto L_OPENSESSION;
;
            }
            Console.WriteLine("OpenSession - DC2 : " + DC2 + "  -  DC3 : " + DC3);
        }
        static void CloseSession()
        {
            //A01C
            CLOSE_SESSION.TAG_CLOSE_SESSION_REQUEST_DATA_LENGHT = "0012";

            //002A
            CLOSE_SESSION.TAG_SESSION_ID_ECR_LENGHT = "0004";
            CLOSE_SESSION.TAG_SESSION_ID_ECR_VALUE = "0009";
            //CloseSession
            DC1 = CLOSE_SESSION.TAG_CLOSE_SESSION_REQUEST_DATA_ID +
                CLOSE_SESSION.TAG_CLOSE_SESSION_REQUEST_DATA_LENGHT +
                CLOSE_SESSION.TAG_SESSION_ID_ECR_ID +
                CLOSE_SESSION.TAG_SESSION_ID_ECR_LENGHT +
                CLOSE_SESSION.TAG_SESSION_ID_ECR_VALUE;

            rep = api.CloseSession(DC1, ref DC2, ref DC3);
            Console.WriteLine("CloseSession - DC2 : " + DC2 + "  -  DC3 : " + DC3);
        }
        public static string Payment(string TAG_AMOUNT,string TAG_CURRENCY)
        {
            OpenSession();

            //Payment


            //A005
            PAYMENT.TAG_PAYMENT_REQUEST_DATA_LENGHT = "0156";

            //A006
            PAYMENT.TAG_PAYMENT_REQUEST_STD_DATA_LENGHT = "0062";

            //000C
            PAYMENT.TAG_AMOUNT_ECR_LENGHT = "0006";
            PAYMENT.TAG_AMOUNT_ECR_VALUE = TAG_AMOUNT;


            //000D
            PAYMENT.TAG_CURRENCY_LENGHT = "0003";
            PAYMENT.TAG_CURRENCY_VALUE = "504";

            //000E
            PAYMENT.TAG_PAY_KIND_LENGHT = "0001";
            PAYMENT.TAG_PAY_KIND_VALUE = "0";

            //002A
            PAYMENT.TAG_SESSION_ID_ECR_LENGHT = "0004";
            PAYMENT.TAG_SESSION_ID_ECR_VALUE = "0009";

            //A007
            PAYMENT.TAG_PAYMENT_REQUEST_EXTRA_DATA_LENGHT = "0082";

            //A008
            PAYMENT.TAG_PAYMENT_REQUEST_ADDITIONAL_DATA_LENGHT = "0034";

            //000F
            PAYMENT.TAG_ECR_STAN_ECR_LENGHT = "0006";
            PAYMENT.TAG_ECR_STAN_ECR_VALUE = "754321";

            //0010
            PAYMENT.TAG_ECR_DATE_TIME_LENGHT = "0012";
            PAYMENT.TAG_ECR_DATE_TIME_VALUE = "150120095114";

            //A009
            PAYMENT.TAG_PAYMENT_REQUEST_OPTIONAL_DATA_LENGHT = "0032";

            //0011
            PAYMENT.TAG_CACHIER_ID_LENGHT = "0010";
            PAYMENT.TAG_CACHIER_ID_VALUE = "8691324511";

            //0012
            PAYMENT.TAG_INVOICE_NUM_LENGHT = "0006";
            PAYMENT.TAG_INVOICE_NUM_VALUE = "122695";

            DC1 = PAYMENT.TAG_PAYMENT_REQUEST_DATA_ID +
                PAYMENT.TAG_PAYMENT_REQUEST_DATA_LENGHT +
                PAYMENT.TAG_PAYMENT_REQUEST_STD_DATA_ID +
                PAYMENT.TAG_PAYMENT_REQUEST_STD_DATA_LENGHT +
                PAYMENT.TAG_AMOUNT_ECR_ID +
                PAYMENT.TAG_AMOUNT_ECR_LENGHT+
                PAYMENT.TAG_AMOUNT_ECR_VALUE +
                PAYMENT.TAG_CURRENCY_ID +
                PAYMENT.TAG_CURRENCY_LENGHT +
                PAYMENT.TAG_CURRENCY_VALUE +
                PAYMENT.TAG_PAY_KIND_ID +
                PAYMENT.TAG_PAY_KIND_LENGHT +
                PAYMENT.TAG_PAY_KIND_VALUE +
                PAYMENT.TAG_SESSION_ID_ECR_ID +
                PAYMENT.TAG_SESSION_ID_ECR_LENGHT +
                PAYMENT.TAG_SESSION_ID_ECR_VALUE +
                PAYMENT.TAG_PAYMENT_REQUEST_EXTRA_DATA_ID +
                PAYMENT.TAG_PAYMENT_REQUEST_EXTRA_DATA_LENGHT +
                PAYMENT.TAG_PAYMENT_REQUEST_ADDITIONAL_DATA_ID +
                PAYMENT.TAG_PAYMENT_REQUEST_ADDITIONAL_DATA_LENGHT +
                PAYMENT.TAG_ECR_STAN_ECR_ID +
                PAYMENT.TAG_ECR_STAN_ECR_LENGHT +
                PAYMENT.TAG_ECR_STAN_ECR_VALUE +
                PAYMENT.TAG_ECR_DATE_TIME_ID +
                PAYMENT.TAG_ECR_DATE_TIME_LENGHT +
                PAYMENT.TAG_ECR_DATE_TIME_VALUE +
                PAYMENT.TAG_PAYMENT_REQUEST_OPTIONAL_DATA_ID +
                PAYMENT.TAG_PAYMENT_REQUEST_OPTIONAL_DATA_LENGHT +
                PAYMENT.TAG_CACHIER_ID_ID +
                PAYMENT.TAG_CACHIER_ID_LENGHT +
                PAYMENT.TAG_CACHIER_ID_VALUE +
                PAYMENT.TAG_INVOICE_NUM_ID +
                PAYMENT.TAG_INVOICE_NUM_LENGHT +
                PAYMENT.TAG_INVOICE_NUM_VALUE;
            rep = api.Payment(DC1, ref DC2, ref DC3);
            Console.WriteLine("Payment - DC2 : " + DC2 + "  -  DC3 : " + DC3);

            string Socket_Payement = DC3;
            CloseSession();

            return Socket_Payement;
        }

        public static string PREAUTORISATION(string TAG_AMOUNT, string TAG_CURRENCY)
        {
            OpenSession();
            //Payment


            //A005
            PAYMENT.TAG_PAYMENT_REQUEST_DATA_LENGHT = "0156";

            //A006
            PAYMENT.TAG_PAYMENT_REQUEST_STD_DATA_LENGHT = "0062";

            //000C
            PAYMENT.TAG_AMOUNT_ECR_LENGHT = "0006";
            PAYMENT.TAG_AMOUNT_ECR_VALUE = TAG_AMOUNT;


            //000D
            PAYMENT.TAG_CURRENCY_LENGHT = "0003";
            PAYMENT.TAG_CURRENCY_VALUE = "504";

            //000E
            PAYMENT.TAG_PAY_KIND_LENGHT = "0001";
            PAYMENT.TAG_PAY_KIND_VALUE = "2";

            //002A
            PAYMENT.TAG_SESSION_ID_ECR_LENGHT = "0004";
            PAYMENT.TAG_SESSION_ID_ECR_VALUE = "0009";

            //A007
            PAYMENT.TAG_PAYMENT_REQUEST_EXTRA_DATA_LENGHT = "0082";

            //A008
            PAYMENT.TAG_PAYMENT_REQUEST_ADDITIONAL_DATA_LENGHT = "0034";

            //000F
            PAYMENT.TAG_ECR_STAN_ECR_LENGHT = "0006";
            PAYMENT.TAG_ECR_STAN_ECR_VALUE = "754321";

            //0010
            PAYMENT.TAG_ECR_DATE_TIME_LENGHT = "0012";
            PAYMENT.TAG_ECR_DATE_TIME_VALUE = "150120095114";

            //A009
            PAYMENT.TAG_PAYMENT_REQUEST_OPTIONAL_DATA_LENGHT = "0032";

            //0011
            PAYMENT.TAG_CACHIER_ID_LENGHT = "0010";
            PAYMENT.TAG_CACHIER_ID_VALUE = "8691324511";

            //0012
            PAYMENT.TAG_INVOICE_NUM_LENGHT = "0006";
            PAYMENT.TAG_INVOICE_NUM_VALUE = "122695";

            DC1 = PAYMENT.TAG_PAYMENT_REQUEST_DATA_ID +
                PAYMENT.TAG_PAYMENT_REQUEST_DATA_LENGHT +
                PAYMENT.TAG_PAYMENT_REQUEST_STD_DATA_ID +
                PAYMENT.TAG_PAYMENT_REQUEST_STD_DATA_LENGHT +
                PAYMENT.TAG_AMOUNT_ECR_ID +
                PAYMENT.TAG_AMOUNT_ECR_LENGHT +
                PAYMENT.TAG_AMOUNT_ECR_VALUE +
                PAYMENT.TAG_CURRENCY_ID +
                PAYMENT.TAG_CURRENCY_LENGHT +
                PAYMENT.TAG_CURRENCY_VALUE +
                PAYMENT.TAG_PAY_KIND_ID +
                PAYMENT.TAG_PAY_KIND_LENGHT +
                PAYMENT.TAG_PAY_KIND_VALUE +
                PAYMENT.TAG_SESSION_ID_ECR_ID +
                PAYMENT.TAG_SESSION_ID_ECR_LENGHT +
                PAYMENT.TAG_SESSION_ID_ECR_VALUE +
                PAYMENT.TAG_PAYMENT_REQUEST_EXTRA_DATA_ID +
                PAYMENT.TAG_PAYMENT_REQUEST_EXTRA_DATA_LENGHT +
                PAYMENT.TAG_PAYMENT_REQUEST_ADDITIONAL_DATA_ID +
                PAYMENT.TAG_PAYMENT_REQUEST_ADDITIONAL_DATA_LENGHT +
                PAYMENT.TAG_ECR_STAN_ECR_ID +
                PAYMENT.TAG_ECR_STAN_ECR_LENGHT +
                PAYMENT.TAG_ECR_STAN_ECR_VALUE +
                PAYMENT.TAG_ECR_DATE_TIME_ID +
                PAYMENT.TAG_ECR_DATE_TIME_LENGHT +
                PAYMENT.TAG_ECR_DATE_TIME_VALUE +
                PAYMENT.TAG_PAYMENT_REQUEST_OPTIONAL_DATA_ID +
                PAYMENT.TAG_PAYMENT_REQUEST_OPTIONAL_DATA_LENGHT +
                PAYMENT.TAG_CACHIER_ID_ID +
                PAYMENT.TAG_CACHIER_ID_LENGHT +
                PAYMENT.TAG_CACHIER_ID_VALUE +
                PAYMENT.TAG_INVOICE_NUM_ID +
                PAYMENT.TAG_INVOICE_NUM_LENGHT +
                PAYMENT.TAG_INVOICE_NUM_VALUE;
            rep = api.Payment(DC1, ref DC2, ref DC3);
            Console.WriteLine("Préautorisation - DC2 : " + DC2 + "  -  DC3 : " + DC3);

            string Socket_Payement = DC3;
           
            CloseSession();

            return Socket_Payement;


        }
        public static string PREAUTORISATION_Confirmation(string TAG_AMOUNT, string TAG_CURRENCY)
        {
            OpenSession();
            //Payment


            //A005
            PAYMENT.TAG_PAYMENT_REQUEST_DATA_LENGHT = "0156";

            //A006
            PAYMENT.TAG_PAYMENT_REQUEST_STD_DATA_LENGHT = "0062";

            //000C
            PAYMENT.TAG_AMOUNT_ECR_LENGHT = "0006";
            PAYMENT.TAG_AMOUNT_ECR_VALUE = TAG_AMOUNT;


            //000D
            PAYMENT.TAG_CURRENCY_LENGHT = "0003";
            PAYMENT.TAG_CURRENCY_VALUE = "504";

            //000E
            PAYMENT.TAG_PAY_KIND_LENGHT = "0001";
            PAYMENT.TAG_PAY_KIND_VALUE = "3";

            //002A
            PAYMENT.TAG_SESSION_ID_ECR_LENGHT = "0004";
            PAYMENT.TAG_SESSION_ID_ECR_VALUE = "0009";

            //A007
            PAYMENT.TAG_PAYMENT_REQUEST_EXTRA_DATA_LENGHT = "0082";

            //A008
            PAYMENT.TAG_PAYMENT_REQUEST_ADDITIONAL_DATA_LENGHT = "0034";

            //000F
            PAYMENT.TAG_ECR_STAN_ECR_LENGHT = "0006";
            PAYMENT.TAG_ECR_STAN_ECR_VALUE = "754321";

            //0010
            PAYMENT.TAG_ECR_DATE_TIME_LENGHT = "0012";
            PAYMENT.TAG_ECR_DATE_TIME_VALUE = "150120095114";

            //A009
            PAYMENT.TAG_PAYMENT_REQUEST_OPTIONAL_DATA_LENGHT = "0032";

            //0011
            PAYMENT.TAG_CACHIER_ID_LENGHT = "0010";
            PAYMENT.TAG_CACHIER_ID_VALUE = "8691324511";

            //0012
            PAYMENT.TAG_INVOICE_NUM_LENGHT = "0006";
            PAYMENT.TAG_INVOICE_NUM_VALUE = "122695";

            DC1 = PAYMENT.TAG_PAYMENT_REQUEST_DATA_ID +
                PAYMENT.TAG_PAYMENT_REQUEST_DATA_LENGHT +
                PAYMENT.TAG_PAYMENT_REQUEST_STD_DATA_ID +
                PAYMENT.TAG_PAYMENT_REQUEST_STD_DATA_LENGHT +
                PAYMENT.TAG_AMOUNT_ECR_ID +
                PAYMENT.TAG_AMOUNT_ECR_LENGHT +
                PAYMENT.TAG_AMOUNT_ECR_VALUE +
                PAYMENT.TAG_CURRENCY_ID +
                PAYMENT.TAG_CURRENCY_LENGHT +
                PAYMENT.TAG_CURRENCY_VALUE +
                PAYMENT.TAG_PAY_KIND_ID +
                PAYMENT.TAG_PAY_KIND_LENGHT +
                PAYMENT.TAG_PAY_KIND_VALUE +
                PAYMENT.TAG_SESSION_ID_ECR_ID +
                PAYMENT.TAG_SESSION_ID_ECR_LENGHT +
                PAYMENT.TAG_SESSION_ID_ECR_VALUE +
                PAYMENT.TAG_PAYMENT_REQUEST_EXTRA_DATA_ID +
                PAYMENT.TAG_PAYMENT_REQUEST_EXTRA_DATA_LENGHT +
                PAYMENT.TAG_PAYMENT_REQUEST_ADDITIONAL_DATA_ID +
                PAYMENT.TAG_PAYMENT_REQUEST_ADDITIONAL_DATA_LENGHT +
                PAYMENT.TAG_ECR_STAN_ECR_ID +
                PAYMENT.TAG_ECR_STAN_ECR_LENGHT +
                PAYMENT.TAG_ECR_STAN_ECR_VALUE +
                PAYMENT.TAG_ECR_DATE_TIME_ID +
                PAYMENT.TAG_ECR_DATE_TIME_LENGHT +
                PAYMENT.TAG_ECR_DATE_TIME_VALUE +
                PAYMENT.TAG_PAYMENT_REQUEST_OPTIONAL_DATA_ID +
                PAYMENT.TAG_PAYMENT_REQUEST_OPTIONAL_DATA_LENGHT +
                PAYMENT.TAG_CACHIER_ID_ID +
                PAYMENT.TAG_CACHIER_ID_LENGHT +
                PAYMENT.TAG_CACHIER_ID_VALUE +
                PAYMENT.TAG_INVOICE_NUM_ID +
                PAYMENT.TAG_INVOICE_NUM_LENGHT +
                PAYMENT.TAG_INVOICE_NUM_VALUE;
            rep = api.Payment(DC1, ref DC2, ref DC3);
            Console.WriteLine("Confirmation Préautorisation - DC2 : " + DC2 + "  -  DC3 : " + DC3);

            string Socket_Payement = DC3;

            CloseSession();

            return Socket_Payement;


        }
        public static string Void_PREAUTORISATION()
        {
            OpenSession();
            //Void
            DC1 = "A016" +
                "0065" +
                "A017" +
                "0026" +
                "0029" +
                "0006" +
                "123456" +
                "002A" +
                "0004" +
                "0009" +
                "A018" +
                "0023" +
                "000F" +
                "0006" +
                "654321" +
                "0028" +
                "0001" +
                "6";
            rep = api.Void(DC1, ref DC2, ref DC3);
            Console.WriteLine("Void Préautorisation - DC2 : " + DC2 + "  -  DC3 : " + DC3);
            string Socket_Payement = DC3;
            CloseSession();
            return Socket_Payement;
        }

    }
}
