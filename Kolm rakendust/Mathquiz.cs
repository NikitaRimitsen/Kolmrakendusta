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
        
        NumericUpDown numeric1, numeric2, numeric3, numeric4;
        string text;
        Button button;
        Label time;
        Label timetext;
        Button start;
        

        public Mathquiz()
        {
            var rand = new Random();
            int random = rand.Next(1, 100);
            string number1 = random.ToString();
            int random2 = rand.Next(1, 100);
            string number2 = random2.ToString();
            int random3 = rand.Next(1, 100);
            string number3 = random3.ToString();
            int random4 = rand.Next(1, 100);
            string number4 = random4.ToString();
            string[] randomad = new string[4] { number1, number2, number3, number4 };
            this.Name = "Math Quiz";
            this.Size = new Size(500, 1500);
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
                Location = new Point(0,150),
                BorderStyle = BorderStyle.FixedSingle,

            };
            numeric1 = new NumericUpDown
            {
                Font = new Font("Calibri", 18, FontStyle.Bold),
                Width = 100,
                Name = "sum"
            };
            numeric2 = new NumericUpDown
            {
                Font = new Font("Calibri", 18, FontStyle.Bold),
                Width = 100,
                Name = "min"
            };
            numeric3 = new NumericUpDown
            {
                Font = new Font("Calibri", 18, FontStyle.Bold),
                Width = 100,
                Name = "umn"
            };
            numeric4 = new NumericUpDown
            {
                Font = new Font("Calibri", 18, FontStyle.Bold),
                Width = 100,
                Name = "del"
            };
            button = new Button
            {
                
            };
            time = new Label
            {
                Name = "timeLabel",
                AutoSize = false,
                BorderStyle = BorderStyle.FixedSingle,
                Width = 200,
                Height = 30,
                Font = new Font("Calibri", 16, FontStyle.Bold),
                Text = "",
                //FlowDirection = FlowDirection.RightToLeft,

            };
            timetext = new Label
            {
                Text = "Time left",
                Font = new Font("Calibri", 16, FontStyle.Bold),
                AutoSize = true
            };
            start = new Button
            {
                Text = "Start the quiz",
                Name = "starButton",
                Font = new Font("Calibri", 14, FontStyle.Bold),
                AutoSize = true,
                TabIndex = 0,
                Location = new Point(150, 280),
            };
            


            var l_nimed = new string[5, 4];
            for (int i = 0; i < 4; i++)
            {
                var randa = new Random();
                int randoma = randa.Next(1, 100);
                string number1a = random.ToString();
                table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50));
                for (int j = 0; j < 5; j++)
                {
                    table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
                    var l_nimi = "L" + j.ToString() + i.ToString();
                    l_nimed[j, i] = l_nimi;
                    if (j == 1) { text = tehed[i]; }//tehed = new string [4] {"+", "-", "*","/"};
                    else if (j == 2) { text = "?"; }
                    else if (j == 3) { text = "*"; }
                    else if (j == 4) {
                        if (i==1)
                        {
                            numeric1 = new NumericUpDown
                            {
                                Font = new Font("Calibri", 18, FontStyle.Bold),
                                Width = 100,
                                Name = "sun"
                            };
                        }
                        else if (i == 2)
                        {
                            numeric2 = new NumericUpDown
                            {
                                Font = new Font("Calibri", 18, FontStyle.Bold),
                                Width = 100,
                                Name = "sun"
                            };
                        }
                        /*
                        /*numeric = new NumericUpDown
                        {
                            Font = new Font("Calibri", 18, FontStyle.Bold),
                            Width = 100,
                            Name = "sun"
                        };
                        table.Controls.Add(numeric);*/
                        //table.SetCellPosition(numeric, new TableLayoutPanelCellPosition(i - 1, j));

                    }
                    //l_nimi
                    else { text = "?"; }
                    Label l = new Label { Text = text};
                    table.Controls.Add(l, j, i);
                   // table.Controls.Add(l, j, i);
                }

            }
            FlowLayoutPanel flowe = new FlowLayoutPanel { FlowDirection = FlowDirection.RightToLeft, Dock = DockStyle.Top};
            flowe.Controls.Add(time);
            flowe.Controls.Add(timetext);
            this.Controls.Add(flowe);
            this.Controls.Add(start);
            this.Controls.Add(table);
            
        }
    }
}
