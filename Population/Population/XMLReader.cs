using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Population
{
    public class XMLReader
    {
        static public List<Day> SetDays(string path)
        {
            List<Day> dayList = new List<Day>();
            XmlTextReader reader = new XmlTextReader(path);

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "row")
                {
                    var date = reader.GetAttribute("col_0");
                    var gender = reader.GetAttribute("col_1");
                    var value = reader.GetAttribute("col_2");
                    var day = new Day(int.Parse(value), date, gender);
                    dayList.Add(day);
                }
            }
            return dayList;
        }
    }
}
