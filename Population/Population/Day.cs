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
        public string Date { get; private set; }
        public string Gender { get; private set; }

        public Day(int value, string date, string gender)
        {
            Value = value;
            Date = date;
            Gender = gender;
        }
    }
}
