
namespace MC_Capacity
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btstart = new System.Windows.Forms.Button();
            this.rtbresual = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btstart
            // 
            this.btstart.Location = new System.Drawing.Point(141, 128);
            this.btstart.Name = "btstart";
            this.btstart.Size = new System.Drawing.Size(75, 23);
            this.btstart.TabIndex = 0;
            this.btstart.Text = "START";
            this.btstart.UseVisualStyleBackColor = true;
            this.btstart.Click += new System.EventHandler(this.btstart_Click);
            // 
            // rtbresual
            // 
            this.rtbresual.Location = new System.Drawing.Point(44, 169);
            this.rtbresual.Name = "rtbresual";
            this.rtbresual.Size = new System.Drawing.Size(288, 315);
            this.rtbresual.TabIndex = 1;
            this.rtbresual.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 509);
            this.Controls.Add(this.rtbresual);
            this.Controls.Add(this.btstart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btstart;
        private System.Windows.Forms.RichTextBox rtbresual;
    }
}

