using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Population
{
    public class Day
    {
        public int Value { get; private set; }
        public DateTime Date { get; private set; }
        public int Gender { get; private set; }

        public Day(int value, string date, string gender)
        {
            Value = value;
            Date = SetDateFromString(date);
            Gender = GenderToInt(gender);
        }

        private DateTime SetDateFromString(string date)
        {
            DateTime dateTime;
            var temp = date.Split(' ');
            dateTime = new DateTime(2016, Month(temp[1]), int.Parse(temp[0]));
            return dateTime;
        }
        private int GenderToInt(string gender)
        {

            if (gender == "muž")
                return 0;
            else
                return 1;
        }
        private int Month(string month)
        {
            int result = 0;
            switch (month)
            {
                case "január":
                    result = 1;
                    break;
                case "február":
                    result = 2;
                    break;
                case "marec":
                    result = 3;
                    break;
                case "apríl":
                    result = 4;
                    break;
                case "máj":
                    result = 5;
                    break;
                case "jún":
                    result = 6;
                    break;
                case "júl":
                    result = 7;
                    break;
                case "august":
                    result = 8;
                    break;
                case "september":
                    result = 9;
                    break;
                case "október":
                    result = 10;
                    break;
                case "november":
                    result = 11;
                    break;
                case "december":
                    result = 12;
                    break;
            }
            return result;
        }
    }
}
