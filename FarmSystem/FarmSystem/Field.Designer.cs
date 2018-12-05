namespace FarmSystem
{
    partial class Field
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
            this.dataGridViewFiel = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1soiltype = new System.Windows.Forms.TextBox();
            this.textBox2cropid = new System.Windows.Forms.TextBox();
            this.textBox3growthstat = new System.Windows.Forms.TextBox();
            this.textBox4fieldName = new System.Windows.Forms.TextBox();
            this.textBoxfieldID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiel)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFiel
            // 
            this.dataGridViewFiel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFiel.Location = new System.Drawing.Point(25, 47);
            this.dataGridViewFiel.Name = "dataGridViewFiel";
            this.dataGridViewFiel.Size = new System.Drawing.Size(308, 339);
            this.dataGridViewFiel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(418, 432);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1soiltype
            // 
            this.textBox1soiltype.Location = new System.Drawing.Point(405, 318);
            this.textBox1soiltype.Name = "textBox1soiltype";
            this.textBox1soiltype.Size = new System.Drawing.Size(100, 20);
            this.textBox1soiltype.TabIndex = 3;
            // 
            // textBox2cropid
            // 
            this.textBox2cropid.Location = new System.Drawing.Point(405, 344);
            this.textBox2cropid.Name = "textBox2cropid";
            this.textBox2cropid.Size = new System.Drawing.Size(100, 20);
            this.textBox2cropid.TabIndex = 4;
            // 
            // textBox3growthstat
            // 
            this.textBox3growthstat.Location = new System.Drawing.Point(405, 292);
            this.textBox3growthstat.Name = "textBox3growthstat";
            this.textBox3growthstat.Size = new System.Drawing.Size(100, 20);
            this.textBox3growthstat.TabIndex = 5;
            // 
            // textBox4fieldName
            // 
            this.textBox4fieldName.Location = new System.Drawing.Point(405, 266);
            this.textBox4fieldName.Name = "textBox4fieldName";
            this.textBox4fieldName.Size = new System.Drawing.Size(100, 20);
            this.textBox4fieldName.TabIndex = 6;
            // 
            // textBoxfieldID
            // 
            this.textBoxfieldID.Location = new System.Drawing.Point(405, 240);
            this.textBoxfieldID.Name = "textBoxfieldID";
            this.textBoxfieldID.Size = new System.Drawing.Size(100, 20);
            this.textBoxfieldID.TabIndex = 7;
            // 
            // Field
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 488);
            this.Controls.Add(this.textBoxfieldID);
            this.Controls.Add(this.textBox4fieldName);
            this.Controls.Add(this.textBox3growthstat);
            this.Controls.Add(this.textBox2cropid);
            this.Controls.Add(this.textBox1soiltype);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewFiel);
            this.Name = "Field";
            this.Text = "Field";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFiel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1soiltype;
        private System.Windows.Forms.TextBox textBox2cropid;
        private System.Windows.Forms.TextBox textBox3growthstat;
        private System.Windows.Forms.TextBox textBox4fieldName;
        private System.Windows.Forms.TextBox textBoxfieldID;
    }
}