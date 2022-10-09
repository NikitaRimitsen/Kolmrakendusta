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
        Button picture, mathquiz, mathgame, tableplayers; 
        public Start()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Name = "Menu";
            this.Size = new Size(550, 500);

            picture = new Button
            {
                Text = "Piltide vaatamise tööriist",
                Width = 180,
                Height = 30,
                Location = new System.Drawing.Point(180, 100),
            };
            picture.Click += Picture_Click;
            mathquiz = new Button
            {
                Text = "Matemaatika viktoriin",
                Width = 180,
                Height = 30,
                Location = new System.Drawing.Point(180, 150),
            };
            mathquiz.Click += Mathquiz_Click;
            mathgame = new Button
            {
                Text = "Mäng",
                Width = 180,
                Height = 30,
                Location = new System.Drawing.Point(180, 200),
            };
            mathgame.Click += Mathgame_Click;
            tableplayers = new Button
            {
                Text = "Mängijate tabel",
                Width = 180,
                Height = 30,
                Location = new System.Drawing.Point(180, 250),
            };
            tableplayers.Click += Tableplayers_Click;
            this.Controls.Add(picture);
            this.Controls.Add(mathquiz);
            this.Controls.Add(mathgame);
            this.Controls.Add(tableplayers);
        }

        private void Tableplayers_Click(object sender, EventArgs e)
        {
            Players players = new Players();
            players.StartPosition = FormStartPosition.CenterScreen;
            players.Show();
            this.Hide();
        }

        private void Mathgame_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.StartPosition = FormStartPosition.CenterScreen;
            game.Show();
            this.Hide();
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
