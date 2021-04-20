using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CommandTool.Controls
{
    public partial class ArgumentGridControl : UserControl
    {
        public event EventHandler ArgumentsUpdated;
        public ArgumentGridControl()
        {
            InitializeComponent();
        }

        public void AddArgument(string argumentName, string argumentValue = "")
        {
            var controlName = $"arg{argumentName}";

            var control = flowLayoutPanel1.Controls.Find(controlName, false);

            if (control.FirstOrDefault() != null) 
                return;

            var argumentControl = new ArgumentControl
            {
                ArgumentKey = argumentName,
                Name = controlName
            };
            argumentControl.ArgumentValueChanged += ArgumentControl_ArgumentValueChanged;
            flowLayoutPanel1.Controls.Add(argumentControl);
        }

        public void RemoveArgument(string argumentName)
        {
            flowLayoutPanel1.Controls.RemoveByKey($"arg{argumentName}");
        }

        private void ArgumentControl_ArgumentValueChanged(object sender, (string argumentName, string value) args)
        {
            ArgumentsUpdated?.Invoke(sender, null);
        }
    }
}
