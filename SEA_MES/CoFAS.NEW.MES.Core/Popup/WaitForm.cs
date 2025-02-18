﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoFAS.NEW.MES.Core
{
    public partial class WaitForm : Form
    {
        public string msg;

        public WaitForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }
        public WaitForm(Form parent)
        {
            InitializeComponent();


            if (parent != null)
            {

                this.StartPosition = FormStartPosition.CenterParent;
                //this.StartPosition = FormStartPosition.Manual;
                //this.Location = new Point(parent.Location.X + parent.Width / 2 - this.Width / 2, parent.Location.Y + parent.Height / 2 - this.Height / 2);
            }
            else
            {
                this.StartPosition = FormStartPosition.CenterParent;
            }
        }

        public void CloseLoadingForm()
        {
            this.DialogResult = DialogResult.OK;
            if (label1.Image != null)
            {
                label1.Image.Dispose();
            }
            this.Close();
        }
    }
}
