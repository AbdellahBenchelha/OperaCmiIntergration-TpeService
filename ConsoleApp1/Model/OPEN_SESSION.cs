using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    static class OPEN_SESSION
    {
        // DataContainer1 ECR->EFT
        public static readonly string TAG_OPEN_SESSION_REQUEST_DATA_ID  = "A003";
        public static string TAG_OPEN_SESSION_REQUEST_DATA_LENGHT;


        public static readonly string TAG_SESSION_ID_ECR_ID  = "002A";
        public static string TAG_SESSION_ID_ECR_LENGHT;
        public static string TAG_SESSION_ID_ECR_VALUE;



        // DataContainer2 EFT->ECR

        public static readonly string TAG_PROCESS_STATUS_ID  = "0008";
        public static string TAG_PROCESS_STATUS_LENGHT;
        public static string TAG_PROCESS_STATUS_VALUER;

        // DataContainer3 EFT->ECR

        public static readonly string TAG_OPEN_SESSION_RESPONSE_DATA_ID = "A004";

        public static readonly string TAG_SESSION_ID_EFT_ID = "002A";
        public static string TAG_SESSION_ID_EFT_LENGHT;
        public static string TAG_SESSION_ID_EFT_VALUE;


        public static readonly string TAG_RESULT_ID  = "000B";
        public static string TAG_RESULT_LENGHT;
        public static string TAG_RESULT_VALUE;


    }
}
