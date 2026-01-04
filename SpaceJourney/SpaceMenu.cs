using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceJourney
{
    public partial class SpaceMenu : Form
    {
        public SpaceMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTNOrderTheJourney_Click(object sender, EventArgs e)
        {//че м show ot showdialog отличается? без диалог можно при открытии новой формы работать с предыдущей а с диалог только с открытой так что либо заказывать поездку либо нажимаьь на кнопку во второй форме чтобы ее закрыть
            FormOrder order= new FormOrder();
            order.ShowDialog();
        }
    }
}
