using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public static class CLOSE_SESSION
    {
        // DataContainer1 ECR->EFT
        public static readonly string TAG_CLOSE_SESSION_REQUEST_DATA_ID  = "A01C";
        public static string TAG_CLOSE_SESSION_REQUEST_DATA_LENGHT;


        public static readonly string TAG_SESSION_ID_ECR_ID = "002A";
        public static string TAG_SESSION_ID_ECR_LENGHT ;
        public static string TAG_SESSION_ID_ECR_VALUE ;


        // DataContainer2 EFT->ECR

        public static readonly string TAG_PROCESS_STATUS_ID  = "0008";
        public static string TAG_PROCESS_STATUS_LENGHT ;
        public static string TAG_PROCESS_STATUS_VALUER ;

        // DataContainer3 EFT->ECR

        public static readonly string TAG_CLOSE_SESSION_RESPONSE_DATA_ID  = "A01D";

        public static readonly string TAG_RESULT_ID  = "000B";
        public static string TAG_RESULT_LENGHT;
        public static string TAG_RESULT_VALUE;

    }
}
