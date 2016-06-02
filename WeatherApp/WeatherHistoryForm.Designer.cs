namespace WeatherApp
{
    partial class WeatherHistoryForm
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
            this.DG = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.tempnumeric = new System.Windows.Forms.NumericUpDown();
            this.tempmaxnumeric = new System.Windows.Forms.NumericUpDown();
            this.tempminnumeric = new System.Windows.Forms.NumericUpDown();
            this.windspeednumeric = new System.Windows.Forms.NumericUpDown();
            this.cloudsnumeric = new System.Windows.Forms.NumericUpDown();
            this.descriptextbox = new System.Windows.Forms.TextBox();
            this.clrbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempnumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempmaxnumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempminnumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windspeednumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloudsnumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // DG
            // 
            this.DG.AllowUserToAddRows = false;
            this.DG.AllowUserToDeleteRows = false;
            this.DG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG.Location = new System.Drawing.Point(12, 64);
            this.DG.Name = "DG";
            this.DG.ReadOnly = true;
            this.DG.RowTemplate.Height = 24;
            this.DG.Size = new System.Drawing.Size(1620, 977);
            this.DG.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Temp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(369, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Temp Max:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(533, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Temp Min:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(697, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Description:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(861, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cloud:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1025, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Wind Speed:";
            // 
            // nametextbox
            // 
            this.nametextbox.Location = new System.Drawing.Point(16, 36);
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(158, 22);
            this.nametextbox.TabIndex = 17;
            this.nametextbox.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // tempnumeric
            // 
            this.tempnumeric.DecimalPlaces = 2;
            this.tempnumeric.Location = new System.Drawing.Point(209, 36);
            this.tempnumeric.Name = "tempnumeric";
            this.tempnumeric.Size = new System.Drawing.Size(158, 22);
            this.tempnumeric.TabIndex = 18;
            this.tempnumeric.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // tempmaxnumeric
            // 
            this.tempmaxnumeric.DecimalPlaces = 2;
            this.tempmaxnumeric.Location = new System.Drawing.Point(373, 37);
            this.tempmaxnumeric.Name = "tempmaxnumeric";
            this.tempmaxnumeric.Size = new System.Drawing.Size(158, 22);
            this.tempmaxnumeric.TabIndex = 19;
            this.tempmaxnumeric.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // tempminnumeric
            // 
            this.tempminnumeric.DecimalPlaces = 2;
            this.tempminnumeric.Location = new System.Drawing.Point(537, 37);
            this.tempminnumeric.Name = "tempminnumeric";
            this.tempminnumeric.Size = new System.Drawing.Size(158, 22);
            this.tempminnumeric.TabIndex = 20;
            this.tempminnumeric.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // windspeednumeric
            // 
            this.windspeednumeric.Location = new System.Drawing.Point(1029, 36);
            this.windspeednumeric.Name = "windspeednumeric";
            this.windspeednumeric.Size = new System.Drawing.Size(158, 22);
            this.windspeednumeric.TabIndex = 21;
            this.windspeednumeric.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // cloudsnumeric
            // 
            this.cloudsnumeric.Location = new System.Drawing.Point(865, 36);
            this.cloudsnumeric.Name = "cloudsnumeric";
            this.cloudsnumeric.Size = new System.Drawing.Size(158, 22);
            this.cloudsnumeric.TabIndex = 22;
            this.cloudsnumeric.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // descriptextbox
            // 
            this.descriptextbox.Location = new System.Drawing.Point(701, 35);
            this.descriptextbox.Name = "descriptextbox";
            this.descriptextbox.Size = new System.Drawing.Size(158, 22);
            this.descriptextbox.TabIndex = 25;
            this.descriptextbox.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // clrbutton
            // 
            this.clrbutton.Location = new System.Drawing.Point(1239, 13);
            this.clrbutton.Name = "clrbutton";
            this.clrbutton.Size = new System.Drawing.Size(98, 44);
            this.clrbutton.TabIndex = 26;
            this.clrbutton.Text = "Reset";
            this.clrbutton.UseVisualStyleBackColor = true;
            this.clrbutton.Click += new System.EventHandler(this.clrbutton_Click);
            // 
            // WeatherHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1644, 953);
            this.Controls.Add(this.clrbutton);
            this.Controls.Add(this.descriptextbox);
            this.Controls.Add(this.cloudsnumeric);
            this.Controls.Add(this.windspeednumeric);
            this.Controls.Add(this.tempminnumeric);
            this.Controls.Add(this.tempmaxnumeric);
            this.Controls.Add(this.tempnumeric);
            this.Controls.Add(this.nametextbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DG);
            this.Name = "WeatherHistoryForm";
            this.Text = "Weather History";
            this.Load += new System.EventHandler(this.WeatherHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempnumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempmaxnumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempminnumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windspeednumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloudsnumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.NumericUpDown tempnumeric;
        private System.Windows.Forms.NumericUpDown tempmaxnumeric;
        private System.Windows.Forms.NumericUpDown tempminnumeric;
        private System.Windows.Forms.NumericUpDown windspeednumeric;
        private System.Windows.Forms.NumericUpDown cloudsnumeric;
        private System.Windows.Forms.TextBox descriptextbox;
        private System.Windows.Forms.Button clrbutton;
    }
}