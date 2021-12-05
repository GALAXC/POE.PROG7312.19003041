using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POE.PROG7312._19003041
{
    public partial class FindingCallNumbers : Form
    {
        public FindingCallNumbers()
        {
            InitializeComponent();
        }

        private void FindingCallNumbers_Load(object sender, EventArgs e)
        {
            CallNumbers.LoadCallNums();
        }
    }
}