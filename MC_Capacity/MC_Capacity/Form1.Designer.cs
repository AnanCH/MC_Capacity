
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rtbresual = new System.Windows.Forms.RichTextBox();
            this.scheduler = new System.Windows.Forms.Timer(this.components);
            this.showtime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbresual
            // 
            this.rtbresual.Location = new System.Drawing.Point(32, 137);
            this.rtbresual.Margin = new System.Windows.Forms.Padding(2);
            this.rtbresual.Name = "rtbresual";
            this.rtbresual.Size = new System.Drawing.Size(329, 443);
            this.rtbresual.TabIndex = 1;
            this.rtbresual.Text = "";
            // 
            // scheduler
            // 
            this.scheduler.Tick += new System.EventHandler(this.scheduler_Tick);
            // 
            // showtime
            // 
            this.showtime.AutoSize = true;
            this.showtime.BackColor = System.Drawing.Color.Silver;
            this.showtime.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showtime.Location = new System.Drawing.Point(41, 103);
            this.showtime.Name = "showtime";
            this.showtime.Size = new System.Drawing.Size(89, 21);
            this.showtime.TabIndex = 3;
            this.showtime.Text = "Show time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Check Capacity";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(393, 637);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showtime);
            this.Controls.Add(this.rtbresual);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Check Capacity Machine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbresual;
        private System.Windows.Forms.Timer scheduler;
        private System.Windows.Forms.Label showtime;
        private System.Windows.Forms.Label label1;
    }
}

