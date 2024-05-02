using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCamDo
{
    public class Utility
    {
        string[] words =
            [
                "không",
                "một",
                "hai",
                "ba",
                "bốn",
                "năm",
                "sáu",
                "bảy",
                "tám",
                "chín",
                "mười",
                "mười một",
                "mười hai",
                "mười ba",
                "mười bốn",
                "mười lăm",
                "mười sáu",
                "mười bảy",
                "mười tám",
                "mười chín"
            ];

        string[] units = [
            "",
            "nghìn",
            "triệu",
            "tỷ"
        ];

        public string ConvertPriceToText(double number)
        {
            if (number <= 0)
            {
                return "Không đồng";
            }

            int integralPart = (int)Math.Floor(number);

            string text = ConvertIntergerPartToText(integralPart);

            return text + " đồng";
        }

        private string ConvertIntergerPartToText(int number)
        {
            string text = "";
            int unitIndex = 0;

            while (number > 0)
            {
                int threeDigitGroup = number % 1000;
                text = ConvertThreeDigitGroupToText(threeDigitGroup) + " " + units[unitIndex] + " " + text;
                number /= 1000;
                unitIndex++;
            }

            return text.Trim();
        }

        private string ConvertThreeDigitGroupToText(int number)
        {
            string text = "";

            int hundred = number / 100;
            number %= 100;

            if (hundred > 0)
            {
                text = words[hundred] + " trăm ";
            }

            if (number > 0)
            {
                if (hundred > 0 && number < 10)
                {
                    text += "lẻ ";
                }
                text += ConvertTwoDigitNumberToText(number);
            }

            return text.Trim();
        }

        private string ConvertTwoDigitNumberToText(int number)
        {
            if (number == 0)
            {
                return "";
            }

            int ten = number / 10;
            int unit = number % 10;

            if (ten == 1)
            {
                return words[unit + 10];
            }
            else
            {
                return words[ten] + " mươi " + words[unit];
            }
        }
    }
}
