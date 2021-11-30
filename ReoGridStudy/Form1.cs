using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using unvell.ReoGrid.Print;
using unvell.ReoGrid.IO;
using unvell.ReoGrid;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace ReoGridStudy
{
    public partial class Form1 : Form
    {
        public void LoadExcel()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                String strFileName = System.IO.Path.GetFullPath(dlg.FileName);
                m_gridCtrl.Load(strFileName);
            }
        }

        public Form1()
        {
            InitializeComponent();
            //LoadExcel();
        }

        private void m_gridCtrl_Click(object sender, EventArgs e)
        {

        }
    }
}
