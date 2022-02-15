using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursWork
{
    public partial class CursWork : Form
    {
        public CursWork()
        {
            InitializeComponent();
        }

        private void theoryButtonOnClick(object sender, EventArgs e)
        {
            this.Hide();
            TheoryForm form = new TheoryForm(this);
            form.Show();
        }

        private void testButtonOnClick(object sender, EventArgs e)
        {
            this.Hide();
            InstructionTestForm form = new InstructionTestForm(this);
            form.Show();
        }

        private void aboutProgrammButtonOnClick(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.BackColor = Color.Violet;
            richTextBox1.Font = new Font("Arial", 15, FontStyle.Bold);
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.Text = "О программе";
            
        }
    }
}
