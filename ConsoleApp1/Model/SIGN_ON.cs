using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public static class SIGN_ON
    {
        // DataContainer1 ECR->EFT

        public static readonly string TAG_SIGN_ON_REQUEST_DATA_ID = "A000";
        public static string TAG_SIGN_ON_REQUEST_DATA_LENGHT ;

        public static readonly string TAG_PROTOCOL_VER_ID = "0001";
        public static string TAG_PROTOCOL_VER_LENGHT ;
        public static string TAG_PROTOCOL_VER_VALUE ;

        public static readonly string TAG_ECR_FAB_ID = "0002";
        public static string TAG_ECR_FAB_LENGHT ;
        public static string TAG_ECR_FAB_VALUE ;


        public static readonly string TAG_ECR_NUM_ID = "0003";
        public static string TAG_ECR_NUM_LENGHT ;
        public static string TAG_ECR_NUM_VALUE ;


        public static readonly string TAG_PWD_ID = "0004";
        public static string TAG_PWD_LENGHT ;
        public static string TAG_PWD_VALUE ;


        public static readonly string TAG_ECR_INPUT_OPT_ID = "0005";
        public static string TAG_ECR_INPUT_OPT_LENGHT ;
        public static string TAG_ECR_INPUT_OPT_VALUE ;


        public static readonly string TAG_STATION_NUM_ID = "004A";
        public static string TAG_STATION_NUM_LENGHT ;
        public static string TAG_STATION_NUM_VALUE ;



        public static readonly string TAG_TIME_OUTS_ID = "A001";
        public static string TAG_TIME_OUTS_LENGHT ;


        public static readonly string TAG_TRANS_TIME_OUT_ID = "0006";
        public static string TAG_TRANS_TIME_OUT_LENGHT ;
        public static string TAG_TRANS_TIME_OUT_VALUE ;


        public static readonly string TAG_END_OF_DAY_TIME_OUT_ID = "0035";
        public static string TAG_END_OF_DAY_TIME_OUT_LENGHT ;
        public static string TAG_END_OF_DAY_TIME_OUT_VALUE ;


        public static readonly string TAG_OPER_TIME_OUT_ID = "0007";
        public static string TAG_OPER_TIME_OUT_LENGHT ;
        public static string TAG_OPER_TIME_OUT_VALUE;



        // DataContainer2 EFT->ECR
        public static readonly string TAG_PROCESS_STATUS_ID = "0008";
        public static string TAG_PROCESS_STATUS_LEGHT ;
        public static string TAG_PROCESS_STATUS_VALUE ;



        // DataContainer3 EFT->ECR
        public static readonly string TAG_SIGN_ON_RESPONSE_DATA_ID = "A002";

        public static readonly string TAG_TERMINAL_ID_ID = "0009";
        public static string TAG_TERMINAL_ID_VALUE_lENGHT ;
        public static string TAG_TERMINAL_ID_VALUE ;

        public static readonly string TAG_OUTLET_ID_ID = "000A";
        public static string TAG_OUTLET_ID_VALUE_lENGHT ;
        public static string TAG_OUTLET_ID_VALUE ;

        public static readonly string TAG_RESULT_ID = "000B";
        public static string TAG_RESULT_VALUE_lENGHT ;
        public static string TAG_RESULT_VALUE ;

        
    }
}
