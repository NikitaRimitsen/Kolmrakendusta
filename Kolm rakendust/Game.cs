﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Kolm_rakendust
{
    public partial class Game : Form
    {
        TableLayoutPanel table;
        Label smail1, smail2, smail3, smail4, smail5, smail6, smail7, smail8;
        Label smail9, smail10, smail11, smail12, smail13, smail14, smail15, smail16;
        public Game()
        {
            this.Name = " Matching game";
            this.Size = new Size(550, 550);
            table = new TableLayoutPanel
            {
                BackColor = Color.CornflowerBlue,
                Dock = DockStyle.Fill,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset,

            };
            table.ColumnCount = 4;
            table.RowCount = 4;

            smail1 = new Label{ BackColor = Color.Green,AutoSize = false,Dock = DockStyle.Fill,TextAlign = ContentAlignment.MiddleCenter,Font = new Font("Webdings", 48, FontStyle.Bold),Text = "c"};
            smail2 = new Label { BackColor = Color.CornflowerBlue, AutoSize = false, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Webdings", 48, FontStyle.Bold), Text = "c" };
            smail3 = new Label { BackColor = Color.CornflowerBlue, AutoSize = false, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Webdings", 48, FontStyle.Bold), Text = "c" };
            smail4 = new Label { BackColor = Color.CornflowerBlue, AutoSize = false, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Webdings", 48, FontStyle.Bold), Text = "c" };
            smail5 = new Label { BackColor = Color.CornflowerBlue, AutoSize = false, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Webdings", 48, FontStyle.Bold), Text = "c" };
            smail6 = new Label { BackColor = Color.CornflowerBlue, AutoSize = false, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Webdings", 48, FontStyle.Bold), Text = "c" };
            smail7 = new Label { BackColor = Color.CornflowerBlue, AutoSize = false, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Webdings", 48, FontStyle.Bold), Text = "c" };

            for (int i = 0; i < 4; i++)
            { 
                table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
                smail1 = new Label
                { BackColor = Color.Red, AutoSize = false, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Webdings", 48, FontStyle.Bold), Text = "c" };
            }

            for (int i = 0; i < 4; i++) 
            { 
                table.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
            }

            table.Controls.Add(smail1);
            table.Controls.Add(smail2);
            table.Controls.Add(smail3);
            table.Controls.Add(smail4);
            table.Controls.Add(smail5);
            int a = 1;
            //string test = "smail1";
            //people = new List<>() { smail1, "Bob", "Sam" };
            table.SetCellPosition(smail1, new TableLayoutPanelCellPosition(0, 0));
            table.SetCellPosition(smail2, new TableLayoutPanelCellPosition(0, 3));
            table.SetCellPosition(smail3, new TableLayoutPanelCellPosition(0, 3));
            this.Controls.Add(table);

        }
    }
}
