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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFert)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFert
            // 
            this.dgvFert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFert.Location = new System.Drawing.Point(13, 53);
            this.dgvFert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvFert.Name = "dgvFert";
            this.dgvFert.Size = new System.Drawing.Size(1142, 652);
            this.dgvFert.TabIndex = 0;
            // 
            // txtfertname
            // 
            this.txtfertname.Location = new System.Drawing.Point(1284, 492);
            this.txtfertname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtfertname.Name = "txtfertname";
            this.txtfertname.Size = new System.Drawing.Size(132, 22);
            this.txtfertname.TabIndex = 1;
            // 
            // txtfertquant
            // 
            this.txtfertquant.Location = new System.Drawing.Point(1284, 549);
            this.txtfertquant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtfertquant.Name = "txtfertquant";
            this.txtfertquant.Size = new System.Drawing.Size(132, 22);
            this.txtfertquant.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1304, 615);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1304, 668);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1174, 496);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fertiliser Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1214, 552);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quantity";
            // 
            // Fertiliser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 718);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtfertquant);
            this.Controls.Add(this.txtfertname);
            this.Controls.Add(this.dgvFert);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Fertiliser";
            this.Text = "Fertiliser";
            this.Load += new System.EventHandler(this.Fertiliser_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}