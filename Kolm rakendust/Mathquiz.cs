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
        TableLayoutPanel table2;
        string[] tehed = new string[4] {"+", "-", "*","/"};
        
        NumericUpDown numeric1, numeric2, numeric3, numeric4;
        string text;
        Button button;
        Label time;
        Label timetext;
        Label pludLeftLabel, plusRightLabel;
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
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Size = new Size(550, 400);
            table2 = new TableLayoutPanel
            {
                ColumnStyles =
                {
                    new ColumnStyle(SizeType.Percent, 20),
                    new ColumnStyle(SizeType.Percent, 20),
                    new ColumnStyle(SizeType.Percent, 20),
                    new ColumnStyle(SizeType.Percent, 20),
                    new ColumnStyle(SizeType.Percent, 20),
                },
                RowStyles =
                {
                    new RowStyle(SizeType.Percent, 25),
                    new RowStyle(SizeType.Percent, 25),
                    new RowStyle(SizeType.Percent, 25),
                    new RowStyle(SizeType.Percent, 25),

                },
                BorderStyle = BorderStyle.FixedSingle,
                AutoSize = true,
                Location = new Point(0, 190),
            };
            plusRightLabel = new Label
            {
                Text="+"
            };

            table = new TableLayoutPanel
            {
                Location = new Point(0, 100),
                BorderStyle = BorderStyle.FixedSingle,
                AutoSize= true,
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
                BackColor = Color.Red
                //AutoSize = true
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


            //Loodud table
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
                    else if (j == 4)
                    {
                        numeric1 = new NumericUpDown
                        {
                            Font = new Font("Calibri", 18, FontStyle.Regular),
                            Width = 100,
                            Name = "sun"
                        };
                        table.Controls.Add(numeric1, j, i);
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
                    else { text = "5"; }
                    if (j != 4)
                    {
                        Label l = new Label { Text = text, Font = new Font("Calibri", 16, FontStyle.Regular) };
                        table.Controls.Add(l, j, i);
                    }
                    
                }
            }
             FlowLayoutPanel flowe = new FlowLayoutPanel { FlowDirection = FlowDirection.RightToLeft, Dock = DockStyle.Top};
            flowe.Controls.Add(time);
            flowe.Controls.Add(timetext);
            table2.Controls.Add(plusRightLabel);
            table2.SetCellPosition(flowe, new TableLayoutPanelCellPosition(5, 2));
            this.Controls.Add(flowe);
            this.Controls.Add(table);
            this.Controls.Add(start);
            
            

        }
    }
}
