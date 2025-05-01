using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaniBogat1
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
            this.questionsTableAdapter.Fill(this.stani_bogatDataSet.Questions);
        }

        private void questionsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
      

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btnBackToGame_Click(object sender, EventArgs e)
        {
            this.Hide(); 
        }
    }
}
