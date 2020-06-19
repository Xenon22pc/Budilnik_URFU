using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace budilnik
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //При касании любой стены лабиринта, позиция будет обновляться до стартового.
        private void label71_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            SoundPlayer scream = new SoundPlayer("C:/2.wav");
            scream.Play();

        }
        //Выставляем стартовую позицию курсора.
        // +55 и +60 это позиция labelStart относительно позиции формы на рабочем столе.
        private void Form2_Load(object sender, EventArgs e)
        {
            Cursor.Position = new Point(this.Location.X + 55, this.Location.Y + 60);
        }

        private void labelFinish_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Hide();
            MessageBox.Show("Ты точно проснулся?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer("C:/1.wav");
            sp.Play();
            pictureBox1.Visible = false;
            Cursor.Position = new Point(this.Location.X + 55, this.Location.Y + 60);
        }
    }
}
