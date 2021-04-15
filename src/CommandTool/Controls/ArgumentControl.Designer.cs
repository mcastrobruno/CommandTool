
namespace CommandTool.Controls
{
    partial class ArgumentControl
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
            this.lblArgumentName = new System.Windows.Forms.Label();
            this.tbArgumentValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblArgumentName
            // 
            this.lblArgumentName.AutoSize = true;
            this.lblArgumentName.Location = new System.Drawing.Point(0, 0);
            this.lblArgumentName.Name = "lblArgumentName";
            this.lblArgumentName.Size = new System.Drawing.Size(38, 15);
            this.lblArgumentName.TabIndex = 0;
            this.lblArgumentName.Text = "label1";
            // 
            // tbArgumentValue
            // 
            this.tbArgumentValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbArgumentValue.Location = new System.Drawing.Point(1, 17);
            this.tbArgumentValue.Name = "tbArgumentValue";
            this.tbArgumentValue.Size = new System.Drawing.Size(153, 23);
            this.tbArgumentValue.TabIndex = 1;
            this.tbArgumentValue.Validated += new System.EventHandler(this.tbArgumentValue_TextChanged);
            // 
            // ArgumentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbArgumentValue);
            this.Controls.Add(this.lblArgumentName);
            this.Name = "ArgumentControl";
            this.Size = new System.Drawing.Size(156, 41);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArgumentName;
        private System.Windows.Forms.TextBox tbArgumentValue;
    }
}
