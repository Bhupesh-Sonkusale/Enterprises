using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprises
{
    public class Shop_Detail
    {
        public string SHOP_ID = "1";
        public string SHOP_NAME = "Enterprises says to You";
        public string BRANCH_ID = "1001";
        public string USER_ID = "1001";
        public string FINANCIAL_ID = DateTime.Now.Year.ToString() + "-" + DateTime.Now.AddYears(1); // "2022-2023";
        public string VERSION = "copyright @" + DateTime.Now.Year +" | Version : 1.1.1.3 | Contact : Bhupesh Sonkusale [9579325790]";
        public string IMAGE_PATH = "C:\\ProjectDB\\SarojFashion\\";
        public string WELCOME_MSG = "Welcome You, Login Time : " + DateTime.Now.Hour.ToString().PadLeft(2, '0') + ":" + DateTime.Now.Minute.ToString().PadLeft(2, '0');
        public string DB_PATH = "C:\\ProjectDB\\SarojFashion\\Database.mdf";
        public string COMPANY_MOBILE = "Mo. : +91 9579325790 , +91 9579048489";
        public string BILL_PATH = "C:\\ProjectDB\\SarojFashion\\";
    }

    public class DateFormats
    {
        public string DateCvtoyymmdd(string date)
        {
            string[] code = date.Split('/');
            string d1 = code[0].ToString();
            string d2 = code[1].ToString();
            string d3 = code[2].ToString();
            date = d3 + "-" + d2 + "-" + d1;
            return date;
        }

        public string DateCvtoddmmyy(string date)
        {
            string[] code = date.Split('/');
            string d1 = code[0].ToString();
            string d2 = code[1].ToString();
            string d3 = code[2].ToString();
            date = d2 + "/" + d1 + "/" + d3;
            return date;
        }
    }

    public class ConvertNumberToWords
    {
        public string ConvertNumbertoWords(int numbers)
        {
            int number = numbers;

            if (number == 0) return "Zero";
            if (number == -2147483648) return "Minus Two Hundred and Fourteen Crore Seventy Four Lakh Eighty Three Thousand Six Hundred and Forty Eight";
            int[] num = new int[4];
            int first = 0;
            int u, h, t;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            if (number < 0)
            {
                sb.Append("Minus ");
                number = -number;
            }
            string[] words0 = {"" ,"One ", "Two ", "Three ", "Four ","Five " ,"Six ", "Seven ", "Eight ", "Nine "};
            string[] words1 = {"Ten ", "Eleven ", "Twelve ", "Thirteen ", "Fourteen ","Fifteen ","Sixteen ","Seventeen ","Eighteen ", "Nineteen "};
            string[] words2 = {"Twenty ", "Thirty ", "Forty ", "Fifty ", "Sixty ","Seventy ","Eighty ", "Ninety "};
            string[] words3 = { "Thousand ", "Lakh ", "Crore " };
            num[0] = number % 1000; // units
            num[1] = number / 1000;
            num[2] = number / 100000;
            num[1] = num[1] - 100 * num[2]; // thousands
            num[3] = number / 10000000; // crores
            num[2] = num[2] - 100 * num[3]; // lakhs
            for (int i = 3; i > 0; i--)
            {
                if (num[i] != 0)
                {
                    first = i;
                    break;
                }
            }
            for (int i = first; i >= 0; i--)
            {
                if (num[i] == 0) continue;
                u = Convert.ToInt16(num[i] % 10); // ones
                t = Convert.ToInt16(num[i] / 10);
                h = Convert.ToInt16(num[i] / 100); // hundreds
                t = t - 10 * h; // tens
                if (h > 0) sb.Append(words0[h] + "Hundred ");
                if (u > 0 || t > 0)
                {
                    if (h > 0 || i == 0) sb.Append(" ");
                    if (t == 0)
                        sb.Append(words0[u]);
                    else if (t == 1)
                        sb.Append(words1[u]);
                    else
                        sb.Append(words2[t - 2] + words0[u]);
                }
                if (i != 0) sb.Append(words3[i - 1]);
            }
            return sb.ToString().TrimEnd();
        }
    }
}
