﻿using System;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Population
{
    public partial class Form1 : Form
    {
        public Document Document= null;
        public FilterDocument Filter=null;


        public Form1()
        {
            InitializeComponent();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            FileDialog.ShowDialog();
            var path = FileDialog.FileName;
            Document = new Document(path,label2);


        }

        private void DrawBtn_Click(object sender, EventArgs e)
        {
            if (Document != null&&Filter!=null)
            {
                DrawingManager.DrawGraph(chart1, Filter, Filter.SearchedGender);
            }
            else
            {
                MessageBox.Show("Load Xml file please");
                FileDialog.ShowDialog();
                var path = FileDialog.FileName;
                Document = new Document(path, label2);
            }
        }

        private void MonthCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Document!=null)
                Filter = new FilterDocument(Document, GenderBox.SelectedIndex, MonthCombobox.SelectedIndex);

        }

        private void GenderBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Document != null)
                Filter = new FilterDocument(Document, GenderBox.SelectedIndex, MonthCombobox.SelectedIndex);

        }
    }
}
