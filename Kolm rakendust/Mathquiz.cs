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
    public partial class Mathquiz : Form
    {
        TableLayoutPanel table;
        string[] tehed = new string[4] {"+", "-", "*","/"};
        NumericUpDown numeric;
        string text;
        Button button;
        Label time;
        public Mathquiz()
        {
            this.Name = "Math Quiz";
            this.Size = new Size(500, 400);
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            table = new TableLayoutPanel
            {
                AutoSize = true,
                /*ColumnStyles = 
                {
                    new ColumnStyle(SizeType.Percent, 25),
                    new ColumnStyle(SizeType.Percent, 15),
                    new ColumnStyle(SizeType.Percent, 15),
                    new ColumnStyle(SizeType.Percent, 15),
                    new ColumnStyle(SizeType.Percent, 30),
                },
                RowStyles =
                {
                    new RowStyle(SizeType.Percent, 25),
                    new RowStyle(SizeType.Percent, 10),
                    new RowStyle(SizeType.Percent, 10),
                    new RowStyle(SizeType.Percent, 10),
                    new RowStyle(SizeType.Percent, 10),
                    new RowStyle(SizeType.Percent, 35),
                }*/
                Location = new Point(0,50)

            };
            numeric = new NumericUpDown
            {

            };
            button = new Button
            {

            };
            time = new Label
            {
                Text = "Time Left"
            };
            var l_nimed = new string[5, 4];
            for (int i = 0; i < 4; i++)
            {
                table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
                for (int j = 0; j < 5; j++)
                {
                    table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
                    var l_nimi = "L" + j.ToString() + i.ToString();
                    l_nimed[j, i] = l_nimi;
                    if (j == 1) { text = tehed[i]; }//tehed = new string [4] {"+", "-", "*","/"};
                    else if(j == 2) { text = "?"; }
                    else if (j == 3) { text = "="; }
                    else if (j == 4) { text = "?"; }
                    else { text = "?"; }//l_nimi
                    Label l = new Label { Text = text};
                    table.Controls.Add(l, j, i);
                }

            }

            this.Controls.Add(time);
            this.Controls.Add(table);
        }
    }
}
