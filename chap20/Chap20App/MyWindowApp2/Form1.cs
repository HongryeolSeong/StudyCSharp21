using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWindowApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            var result = $"sender : {sender} \r\n" +
                         $"e : {e}\r\n" +
                         $"e.X : {e.X}, e.Y : {e.Y}\r\n" +
                         $"Button : {e.Button}, Clicks : {e.Clicks}";
            MessageBox.Show(result);
        }
    }
}
