using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CommandTool.Controls
{
    public partial class ArgumentControl : UserControl
    {
        private string _argumentKey;
        public string ArgumentKey
        {
            get => _argumentKey;
            set
            {
                _argumentKey = value;
                lblArgumentName.Text = value;
            }
        }

        public string ArgumentValue => tbArgumentValue.Text;

        public ArgumentControl()
        {
            InitializeComponent();
        }
    }
}
