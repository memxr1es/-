﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Диплом
{
    public partial class Aquapark : Form
    {
        public Aquapark()
        {
            InitializeComponent();
        }

        private void Aquapark_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "центрОРDataSet.Аквапарк". При необходимости она может быть перемещена или удалена.
            this.аквапаркTableAdapter.Fill(this.центрОРDataSet.Аквапарк);

        }
    }
}
