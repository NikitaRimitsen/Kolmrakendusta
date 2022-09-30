using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolm_rakendust
{
    public partial class Start : Form
    {
        Button picture, mathquiz, mathgame; 
        public Start()
        {
            this.Name = "Picture Viewer";
            this.Size = new Size(550, 500);

            picture = new Button
            {
                Text = "Picture Viewer",
                Width = 120,
                Height = 30,
                Location = new System.Drawing.Point(200, 100),
            };
            picture.Click += Picture_Click;
            mathquiz = new Button
            {
                Text = "Math quiz ",
                Width = 120,
                Height = 30,
                Location = new System.Drawing.Point(200, 150),
            };
            mathquiz.Click += Mathquiz_Click;
            this.Controls.Add(picture);
            this.Controls.Add(mathquiz);
        }

        private void Mathquiz_Click(object sender, EventArgs e)
        {
            Mathquiz math = new Mathquiz();
            math.StartPosition = FormStartPosition.CenterScreen;
            math.Show();
            this.Hide();
        }

        private void Picture_Click(object sender, EventArgs e)
        {
            Pictureviewer pictureviewer = new Pictureviewer();
            pictureviewer.StartPosition = FormStartPosition.CenterScreen;
            pictureviewer.Show();
            this.Hide();
        }
    }
}
