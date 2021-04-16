
namespace CommandTool.Controls
{
    partial class CommandControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbParsedCommand = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelArguments = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCommandSyntax = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCommandName = new System.Windows.Forms.Label();
            this.btnSaveSyntax = new System.Windows.Forms.Button();
            this.tbCommandName = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.tbParsedCommand);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 91);
            this.panel2.TabIndex = 15;
            // 
            // tbParsedCommand
            // 
            this.tbParsedCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbParsedCommand.Location = new System.Drawing.Point(3, 20);
            this.tbParsedCommand.Name = "tbParsedCommand";
            this.tbParsedCommand.ReadOnly = true;
            this.tbParsedCommand.Size = new System.Drawing.Size(223, 65);
            this.tbParsedCommand.TabIndex = 12;
            this.tbParsedCommand.Text = "";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Parsed Command";
            // 
            // panelArguments
            // 
            this.panelArguments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelArguments.AutoScroll = true;
            this.panelArguments.AutoSize = true;
            this.panelArguments.Location = new System.Drawing.Point(3, 44);
            this.panelArguments.Name = "panelArguments";
            this.panelArguments.Size = new System.Drawing.Size(226, 21);
            this.panelArguments.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Command Syntax";
            // 
            // tbCommandSyntax
            // 
            this.tbCommandSyntax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCommandSyntax.Location = new System.Drawing.Point(3, 18);
            this.tbCommandSyntax.Name = "tbCommandSyntax";
            this.tbCommandSyntax.Size = new System.Drawing.Size(226, 23);
            this.tbCommandSyntax.TabIndex = 11;
            this.tbCommandSyntax.TextChanged += new System.EventHandler(this.tbCommandSyntax_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblCommandName);
            this.panel1.Controls.Add(this.btnSaveSyntax);
            this.panel1.Controls.Add(this.tbCommandName);
            this.panel1.Location = new System.Drawing.Point(3, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 45);
            this.panel1.TabIndex = 16;
            // 
            // lblCommandName
            // 
            this.lblCommandName.AutoSize = true;
            this.lblCommandName.Location = new System.Drawing.Point(4, 1);
            this.lblCommandName.Name = "lblCommandName";
            this.lblCommandName.Size = new System.Drawing.Size(99, 15);
            this.lblCommandName.TabIndex = 8;
            this.lblCommandName.Text = "Command Name";
            // 
            // btnSaveSyntax
            // 
            this.btnSaveSyntax.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSaveSyntax.Location = new System.Drawing.Point(834, -38);
            this.btnSaveSyntax.Name = "btnSaveSyntax";
            this.btnSaveSyntax.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSyntax.TabIndex = 6;
            this.btnSaveSyntax.Text = "Save";
            this.btnSaveSyntax.UseVisualStyleBackColor = true;
            // 
            // tbCommandName
            // 
            this.tbCommandName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCommandName.Location = new System.Drawing.Point(2, 18);
            this.tbCommandName.Name = "tbCommandName";
            this.tbCommandName.Size = new System.Drawing.Size(224, 23);
            this.tbCommandName.TabIndex = 7;
            // 
            // CommandControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelArguments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCommandSyntax);
            this.Name = "CommandControl";
            this.Size = new System.Drawing.Size(232, 215);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox tbParsedCommand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel panelArguments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCommandSyntax;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCommandName;
        private System.Windows.Forms.Button btnSaveSyntax;
        private System.Windows.Forms.TextBox tbCommandName;
    }
}
