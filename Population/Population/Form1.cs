using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Population
{
    public partial class Form1 : Form
    {
        public Document document;
        public Form1()
        {
            InitializeComponent();
            FileDialog.ShowDialog();
            var path = FileDialog.FileName;
            document = new Document(path);


        }


    }
}
