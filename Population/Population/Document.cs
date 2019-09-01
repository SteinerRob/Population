using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Population
{
    public class Document
    {
        public List<Day> _days = new List<Day>();

        public Document(string path)
        {
            _days = XMLReader.SetDays(path);
        }
    }
}
