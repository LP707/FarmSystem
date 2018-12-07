namespace FarmSystem
{
    partial class Fertiliser
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvFert = new System.Windows.Forms.DataGridView();
            this.txtfertname = new System.Windows.Forms.TextBox();
            this.txtfertquant = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFert)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFert
            // 
            this.dgvFert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFert.Location = new System.Drawing.Point(29, 43);
            this.dgvFert.Name = "dgvFert";
            this.dgvFert.Size = new System.Drawing.Size(394, 359);
            this.dgvFert.TabIndex = 0;
            // 
            // txtfertname
            // 
            this.txtfertname.Location = new System.Drawing.Point(653, 251);
            this.txtfertname.Name = "txtfertname";
            this.txtfertname.Size = new System.Drawing.Size(100, 20);
            this.txtfertname.TabIndex = 1;
            // 
            // txtfertquant
            // 
            this.txtfertquant.Location = new System.Drawing.Point(653, 297);
            this.txtfertquant.Name = "txtfertquant";
            this.txtfertquant.Size = new System.Drawing.Size(100, 20);
            this.txtfertquant.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(668, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(668, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Fertiliser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtfertquant);
            this.Controls.Add(this.txtfertname);
            this.Controls.Add(this.dgvFert);
            this.Name = "Fertiliser";
            this.Text = "Fertiliser";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFert;
        private System.Windows.Forms.TextBox txtfertname;
        private System.Windows.Forms.TextBox txtfertquant;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}