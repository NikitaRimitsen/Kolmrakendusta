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
    public partial class Login : Form
    {
        TextBox login = new TextBox
        {
            Location = new System.Drawing.Point(200, 105),//Point(x,y)
            Height = 90,
            Width = 150
        };
        TextBox password = new TextBox
        {
            Location = new System.Drawing.Point(200, 165),//Point(x,y)
            Height = 90,
            Width = 150,
            UseSystemPasswordChar = true

        };
        public Login()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Name = "Login";
            this.Size = new Size(500, 400);

            Label nimilabel = new Label
            {
                Location = new System.Drawing.Point(200, 30),//Point(x,y)
                Height = 50,
                Width = 170,
                Text = "Login vorm",
                Font = new Font("Oswald", 16, FontStyle.Bold)
            };

            Label loginnimi = new Label
            {
                Location = new System.Drawing.Point(50, 100),//Point(x,y)
                Height = 50,
                Width = 150,
                Text = "Login:",
                Font = new Font("Oswald", 16, FontStyle.Bold)
            };

            Label passwordnimi = new Label
            {
                Location = new System.Drawing.Point(50, 160),//Point(x,y)
                Height = 50,
                Width = 150,
                Text = "Password:",
                Font = new Font("Oswald", 16, FontStyle.Bold)
            };

            Button loginbutton = new Button
            {
                Text = "Login",
                Location = new System.Drawing.Point(200, 250),//Point(x,y)
                Width = 150,
                Height = 35,
                BackColor = Color.LightYellow
            };
            loginbutton.Click += Loginbutton_Click;

            this.Controls.Add(nimilabel);
            this.Controls.Add(loginnimi);
            this.Controls.Add(passwordnimi);
            this.Controls.Add(login);
            this.Controls.Add(password);
            this.Controls.Add(loginbutton);
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            start.StartPosition = FormStartPosition.CenterScreen;
            start.Show();
            this.Hide();
        }
    }
}
