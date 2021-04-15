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
        public event EventHandler ArgumentValueChanged;
        public delegate void EventHandler(object sender, (string argumentName, string value) args);


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

        private void tbArgumentValue_TextChanged(object sender, EventArgs e)
        {
            ArgumentValueChanged?.Invoke(this, (ArgumentKey, ArgumentValue));
        }
    }
}
