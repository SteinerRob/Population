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
        public Document document= null;



        public Form1()
        {
            InitializeComponent();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            FileDialog.ShowDialog();
            var path = FileDialog.FileName;
            document = new Document(path,label2);


        }

        private void DrawBtn_Click(object sender, EventArgs e)
        {
            if (document != null)
            {
                //draw graph
            }
            else
            {
                MessageBox.Show("Load Xml file please");
                FileDialog.ShowDialog();
                var path = FileDialog.FileName;
                document = new Document(path, label2);

            }
        }
    }
}
