
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
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.panelArguments = new System.Windows.Forms.FlowLayoutPanel();
            this.btnParse = new System.Windows.Forms.Button();
            this.tbParsedCommand = new System.Windows.Forms.TextBox();
            this.btnSaveSyntax = new System.Windows.Forms.Button();
            this.tbCommandName = new System.Windows.Forms.TextBox();
            this.lblCommandName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbCommandSyntax
            // 
            this.tbCommandSyntax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCommandSyntax.Location = new System.Drawing.Point(15, 27);
            this.tbCommandSyntax.Name = "tbCommandSyntax";
            this.tbCommandSyntax.Size = new System.Drawing.Size(630, 23);
            this.tbCommandSyntax.TabIndex = 0;
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
            // btnEvaluate
            // 
            this.btnEvaluate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEvaluate.Location = new System.Drawing.Point(651, 27);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(127, 23);
            this.btnEvaluate.TabIndex = 2;
            this.btnEvaluate.Text = "Evaluate Command";
            this.btnEvaluate.UseVisualStyleBackColor = true;
            this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click);
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
            this.panelArguments.Size = new System.Drawing.Size(763, 278);
            this.panelArguments.TabIndex = 3;
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(703, 364);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(75, 23);
            this.btnParse.TabIndex = 4;
            this.btnParse.Text = "Parse";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // tbParsedCommand
            // 
            this.tbParsedCommand.Location = new System.Drawing.Point(15, 319);
            this.tbParsedCommand.Name = "tbParsedCommand";
            this.tbParsedCommand.ReadOnly = true;
            this.tbParsedCommand.Size = new System.Drawing.Size(763, 23);
            this.tbParsedCommand.TabIndex = 5;
            // 
            // btnSaveSyntax
            // 
            this.btnSaveSyntax.Location = new System.Drawing.Point(195, 364);
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
            this.tbCommandName.Location = new System.Drawing.Point(15, 364);
            this.tbCommandName.Name = "tbCommandName";
            this.tbCommandName.Size = new System.Drawing.Size(174, 23);
            this.tbCommandName.TabIndex = 7;
            // 
            // lblCommandName
            // 
            this.lblCommandName.AutoSize = true;
            this.lblCommandName.Location = new System.Drawing.Point(15, 346);
            this.lblCommandName.Name = "lblCommandName";
            this.lblCommandName.Size = new System.Drawing.Size(99, 15);
            this.lblCommandName.TabIndex = 8;
            this.lblCommandName.Text = "Command Name";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 399);
            this.Controls.Add(this.lblCommandName);
            this.Controls.Add(this.tbCommandName);
            this.Controls.Add(this.btnSaveSyntax);
            this.Controls.Add(this.tbParsedCommand);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.panelArguments);
            this.Controls.Add(this.btnEvaluate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCommandSyntax);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCommandSyntax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEvaluate;
        private System.Windows.Forms.FlowLayoutPanel panelArguments;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.TextBox tbParsedCommand;
        private System.Windows.Forms.Button btnSaveSyntax;
        private System.Windows.Forms.TextBox tbCommandName;
        private System.Windows.Forms.Label lblCommandName;
    }
}

