using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    static class PAYMENT
    {

        // DataContainer1 ECR->EFT
        public static readonly string TAG_PAYMENT_REQUEST_DATA_ID = "A005";
        public static string TAG_PAYMENT_REQUEST_DATA_LENGHT;



        public static readonly string TAG_PAYMENT_REQUEST_STD_DATA_ID = "A006";
        public static string TAG_PAYMENT_REQUEST_STD_DATA_LENGHT ;


        public static readonly string TAG_AMOUNT_ECR_ID = "000C";
        public static string TAG_AMOUNT_ECR_LENGHT ;
        public static string TAG_AMOUNT_ECR_VALUE ;


        public static readonly string TAG_CURRENCY_ID = "000D";
        public static string TAG_CURRENCY_LENGHT ;
        public static string TAG_CURRENCY_VALUE ;


        public static readonly string TAG_PAY_KIND_ID = "000E";
        public static string TAG_PAY_KIND_LENGHT ;
        public static string TAG_PAY_KIND_VALUE ;


        public static readonly string TAG_PAY_POINTS_ID = "0031";
        public static string TAG_PAY_POINTS_LENGHT ;
        public static string TAG_PAY_POINTS_VALUE ;


        public static readonly string TAG_PAY_METHOD_ECR_ID = "0032";
        public static string TAG_PAY_METHOD_ECR_LENGHT ;
        public static string TAG_PAY_METHOD_ECR_VALUE ;


        public static readonly string TAG_SESSION_ID_ECR_ID = "002A";
        public static string TAG_SESSION_ID_ECR_LENGHT ;
        public static string TAG_SESSION_ID_ECR_VALUE ;


        public static readonly string TAG_PAYMENT_REQUEST_EXTRA_DATA_ID = "A007";
        public static string TAG_PAYMENT_REQUEST_EXTRA_DATA_LENGHT ;


        public static readonly string TAG_PAYMENT_REQUEST_ADDITIONAL_DATA_ID = "A008";
        public static string TAG_PAYMENT_REQUEST_ADDITIONAL_DATA_LENGHT ;


        public static readonly string TAG_ECR_STAN_ECR_ID = "000F";
        public static string TAG_ECR_STAN_ECR_LENGHT ;
        public static string TAG_ECR_STAN_ECR_VALUE ;


        public static readonly string TAG_ECR_DATE_TIME_ID = "0010";
        public static string TAG_ECR_DATE_TIME_LENGHT ;
        public static string TAG_ECR_DATE_TIME_VALUE ;


        public static readonly string TAG_PAYMENT_REQUEST_OPTIONAL_DATA_ID = "A009";
        public static string TAG_PAYMENT_REQUEST_OPTIONAL_DATA_LENGHT ;


        public static readonly string TAG_CACHIER_ID_ID = "0011";
        public static string TAG_CACHIER_ID_LENGHT ;
        public static string TAG_CACHIER_ID_VALUE ;


        public static readonly string TAG_INVOICE_NUM_ID = "0012";
        public static string TAG_INVOICE_NUM_LENGHT ;
        public static string TAG_INVOICE_NUM_VALUE ;


        public static readonly string TAG_ECR_NUM_ID = "0003";
        public static string TAG_ECR_NUM_LENGHT ;
        public static string TAG_ECR_NUM_VALUE ;


        public static readonly string TAG_PAYMENT_REQUEST_MANUAL_DATA_ID = "A00A";
        public static string TAG_PAYMENT_REQUEST_MANUAL_DATA_LENGHT ;


        public static readonly string TAG_CARD_NUM_ID = "0013";
        public static string TAG_CARD_NUM_LENGHT ;
        public static string TAG_CARD_NUM_VALUE ;


        public static readonly string TAG_EXPIRY_DATE_ID = "0014";
        public static string TAG_EXPIRY_DATE_LENGHT ;
        public static string TAG_EXPIRY_DATE_VALUE ;


        public static readonly string TAG_CVV2_CVC2_ID = "0015";
        public static string TAG_CVV2_CVC2_LENGHT ;
        public static string TAG_CVV2_CVC2_VALUE ;



        // DataContainer2 EFT->ECR

        public static readonly string TAG_PROCESS_STATUS_ID = "0008";
        public static string TAG_PROCESS_STATUS_LENGHT ;
        public static string TAG_PROCESS_STATUS_VALUER ;

        // DataContainer3 EFT->ECR
        public static readonly string TAG_PAYMENT_RESPONSE_DATA_ID = "A00B";


        public static readonly string TAG_PAYMENT_RESPONSE_STD_DATA_ID = "A00C";


        public static readonly string TAG_TIME_ID = "0016";
        public static string TAG_TIME_LENGHT ;
        public static string TAG_TIME_VALUE ;


        public static readonly string TAG_AMOUNT_EFT_ID = "000C";
        public static string TAG_AMOUNT_EFT_LENGHT ;
        public static string TAG_AMOUNT_EFT_VALUE ;


        public static readonly string TAG_SESSION_ID_EFT_ID = "002A";
        public static string TAG_SESSION_ID_EFT_LENGHT ;
        public static string TAG_SESSION_ID_EFT_VALUE ;


        public static readonly string TAG_RESULT_ID = "000B";
        public static string TAG_RESULT_LENGHT ;
        public static string TAG_RESULT_VALUE ;


        public static readonly string TAG_PAY_METHOD_EFT_ID = "0032";
        public static string TAG_PAY_METHOD_EFT_LENGHT ;
        public static string TAG_PAY_METHOD_EFT_VALUE ;


        public static readonly string TAG_PAYMENT_RESPONSE_EXTRA_DATA_ID = "A00D";


        public static readonly string TAG_PAYMENT_RESPONSE_ADDITIONAL_DATA_ID = "A00E";


        public static readonly string TAG_ECR_STAN_EFT_ID = "000F";
        public static string TAG_ECR_STAN_EFT_LENGHT ;
        public static string TAG_ECR_STAN_EFT_VALUE ;


        public static readonly string TAG_EFT_STAN_ID = "0029";
        public static string TAG_EFT_STAN_LENGHT ;
        public static string TAG_EFT_STAN_VALUE ;


        public static readonly string TAG_CARD_LAST_DIGITS_ID = "0070";
        public static string TAG_CARD_LAST_DIGITS_LENGHT ;
        public static string TAG_CARD_LAST_DIGITS_VALUE ;


        public static readonly string TAG_TEL_PAR_STATUS_ID = "0017";
        public static string TAG_TEL_PAR_STATUS_LENGHT ;
        public static string TAG_TEL_PAR_STATUS_VALUE ;


        public static readonly string EFT_TAG_CARDTYPE_ID = "006A";
        public static string EFT_TAG_CARDTYPE_LENGHT ;
        public static string EFT_TAG_CARDTYPE_VALUE ;


        public static readonly string TAG_LOCALCARD_ID = "006B";
        public static string TAG_LOCALCARD_LENGHT ;
        public static string TAG_LOCALCARD_VALUE ;


        public static readonly string TAG_CARD_ENTRYMODE_ID = "006C";
        public static string TAG_CARD_ENTRYMODE_LENGHT ;
        public static string TAG_CARD_ENTRYMODE_VALUE ;


        public static readonly string TAG_CARD_CTMODE_ID = "006D";
        public static string TAG_CARD_CTMODE_LENGHT ;
        public static string TAG_CARD_CTMODE_VALUE ;


        public static readonly string TAG_PAYMENT_RESPONSE_OPTIONAL_DATA_ID = "A00F";


        public static readonly string TAG_CRYPT_CARD_NUM_ID = "0018";
        public static string TAG_CRYPT_CARD_NUM_LENGHT ;
        public static string TAG_CRYPT_CARD_NUM_VALUE ;


        public static readonly string TAG_AUTH_NUM_ID = "0019";
        public static string TAG_AUTH_NUM_LENGHT ;
        public static string TAG_AUTH_NUM_VALUE ;


        public static readonly string TAG_DATE_TRS_ID = "001A";
        public static string TAG_DATE_TRS_LENGHT ;
        public static string TAG_DATE_TRS_VALUE ;


        public static readonly string TAG_CARD_NUM_MASK_ID = "001B";
        public static string TAG_CARD_NUM_MASK_LENGHT ;
        public static string TAG_CARD_NUM_MASK_VALUE ;


        public static readonly string TAG_CARD_TYPE_ID = "004B";
        public static string TAG_CARD_TYPE_LENGHT ;
        public static string TAG_CARD_TYPE_VALUE ;


        public static readonly string TAG_TRS_IN_DCC_ID = "001C";
        public static string TAG_TRS_IN_DCC_LENGHT ;
        public static string TAG_TRS_IN_DCC_VALUE ;


        public static readonly string TAG_AMOUNT_IN_DCC_ID = "001D";
        public static string TAG_AMOUNT_IN_DCC_LENGHT ;
        public static string TAG_AMOUNT_IN_DCC_VALUE ;


        public static readonly string TAG_CURRENCY_IN_DCC_ID = "0033";
        public static string TAG_CURRENCY_IN_DCC_LENGHT ;
        public static string TAG_CURRENCY_IN_DCC ;


    }
}
