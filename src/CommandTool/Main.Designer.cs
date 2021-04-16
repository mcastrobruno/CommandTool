
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
            this.lboxCommands = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.commandControl1 = new CommandTool.Controls.CommandControl();
            this.btnSaveCommand = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lboxCommands
            // 
            this.lboxCommands.FormattingEnabled = true;
            this.lboxCommands.ItemHeight = 15;
            this.lboxCommands.Location = new System.Drawing.Point(631, 87);
            this.lboxCommands.Name = "lboxCommands";
            this.lboxCommands.Size = new System.Drawing.Size(286, 409);
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
            // commandControl1
            // 
            this.commandControl1.Arguments = null;
            this.commandControl1.CommandName = "";
            this.commandControl1.Key = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.commandControl1.Location = new System.Drawing.Point(0, 0);
            this.commandControl1.Name = "commandControl1";
            this.commandControl1.Size = new System.Drawing.Size(625, 496);
            this.commandControl1.Syntax = "";
            this.commandControl1.TabIndex = 13;
            // 
            // btnSaveCommand
            // 
            this.btnSaveCommand.Location = new System.Drawing.Point(635, 36);
            this.btnSaveCommand.Name = "btnSaveCommand";
            this.btnSaveCommand.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCommand.TabIndex = 14;
            this.btnSaveCommand.Text = "Save";
            this.btnSaveCommand.UseVisualStyleBackColor = true;
            this.btnSaveCommand.Click += new System.EventHandler(this.btnSaveCommand_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(716, 36);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 508);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSaveCommand);
            this.Controls.Add(this.commandControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lboxCommands);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lboxCommands;
        private System.Windows.Forms.Label label3;
        private Controls.CommandControl commandControl1;
        private System.Windows.Forms.Button btnSaveCommand;
        private System.Windows.Forms.Button btnDelete;
    }
}

