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
    public partial class InstructionTestForm : Form
    {
        CursWork parent;
        public InstructionTestForm(CursWork _parent)
        {
            InitializeComponent();
            parent = _parent;
        }

        private void InstructionTestFormOnFormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void InstructionTestFormOnLoad(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void startTestButtonOnClick(object sender, EventArgs e)
        {
            TestForm form = new TestForm(this, parent, comboBox1.SelectedItem.ToString());
            form.Show();
            this.Hide();
        }
    }
}
