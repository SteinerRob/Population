using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Population
{
    public class Document
    {
        public List<Day> _days = new List<Day>();

        public Document(string path, Label label)
        {
            _days = XMLReader.SetDays(path);
            label.Text = XMLReader.GetNameFromPath(path);
        }
    }
}
