
namespace CommandTool
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbCommandSyntax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelArguments = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSaveSyntax = new System.Windows.Forms.Button();
            this.tbCommandName = new System.Windows.Forms.TextBox();
            this.lblCommandName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbParsedCommand = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lboxCommands = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCommandSyntax
            // 
            this.tbCommandSyntax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCommandSyntax.Location = new System.Drawing.Point(15, 27);
            this.tbCommandSyntax.Name = "tbCommandSyntax";
            this.tbCommandSyntax.Size = new System.Drawing.Size(610, 23);
            this.tbCommandSyntax.TabIndex = 0;
            this.tbCommandSyntax.TextChanged += new System.EventHandler(this.tbCommandSyntax_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Command Syntax";
            // 
            // panelArguments
            // 
            this.panelArguments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelArguments.AutoScroll = true;
            this.panelArguments.AutoSize = true;
            this.panelArguments.Location = new System.Drawing.Point(15, 56);
            this.panelArguments.Name = "panelArguments";
            this.panelArguments.Size = new System.Drawing.Size(610, 137);
            this.panelArguments.TabIndex = 3;
            // 
            // btnSaveSyntax
            // 
            this.btnSaveSyntax.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSaveSyntax.Location = new System.Drawing.Point(535, 18);
            this.btnSaveSyntax.Name = "btnSaveSyntax";
            this.btnSaveSyntax.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSyntax.TabIndex = 6;
            this.btnSaveSyntax.Text = "Save";
            this.btnSaveSyntax.UseVisualStyleBackColor = true;
            this.btnSaveSyntax.Click += new System.EventHandler(this.btnSaveSyntax_Click);
            // 
            // tbCommandName
            // 
            this.tbCommandName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCommandName.Location = new System.Drawing.Point(5, 18);
            this.tbCommandName.Name = "tbCommandName";
            this.tbCommandName.Size = new System.Drawing.Size(526, 23);
            this.tbCommandName.TabIndex = 7;
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblCommandName);
            this.panel1.Controls.Add(this.btnSaveSyntax);
            this.panel1.Controls.Add(this.tbCommandName);
            this.panel1.Location = new System.Drawing.Point(15, 432);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 45);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.tbParsedCommand);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(15, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 227);
            this.panel2.TabIndex = 10;
            // 
            // tbParsedCommand
            // 
            this.tbParsedCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbParsedCommand.Location = new System.Drawing.Point(3, 36);
            this.tbParsedCommand.Name = "tbParsedCommand";
            this.tbParsedCommand.ReadOnly = true;
            this.tbParsedCommand.Size = new System.Drawing.Size(604, 187);
            this.tbParsedCommand.TabIndex = 12;
            this.tbParsedCommand.Text = "";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Parsed Command";
            // 
            // lboxCommands
            // 
            this.lboxCommands.FormattingEnabled = true;
            this.lboxCommands.ItemHeight = 15;
            this.lboxCommands.Location = new System.Drawing.Point(631, 27);
            this.lboxCommands.Name = "lboxCommands";
            this.lboxCommands.Size = new System.Drawing.Size(286, 454);
            this.lboxCommands.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(631, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Saved Commands";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 488);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lboxCommands);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelArguments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCommandSyntax);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCommandSyntax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel panelArguments;
        private System.Windows.Forms.Button btnSaveSyntax;
        private System.Windows.Forms.TextBox tbCommandName;
        private System.Windows.Forms.Label lblCommandName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tbParsedCommand;
        private System.Windows.Forms.ListBox lboxCommands;
        private System.Windows.Forms.Label label3;
    }
}

