using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class loginpgLect : Form
    {
        List<Panel> listPanel = new List<Panel>();
        int index2;
        public loginpgLect()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (index2 > 0)
                listPanel[--index2].BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (index2 < listPanel.Count - 1)
                listPanel[++index2].BringToFront();
        }

        private void loginpgLect_Load(object sender, EventArgs e)
        {
            listPanel.Add(panelLecAttend0);
            listPanel.Add(panelLecAtt);
            
            listPanel.Add(panelLecAttView);
            listPanel.Add(panelMarkAtt);
            listPanel.Add(panelMedicalLec);
            listPanel[index2].BringToFront();
        }
    }
}
