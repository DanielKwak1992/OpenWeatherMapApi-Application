namespace WeatherApp
{
    partial class v
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
            this.components = new System.ComponentModel.Container();
            this.Temphighlabel = new System.Windows.Forms.Label();
            this.datevalue = new System.Windows.Forms.Label();
            this.coordvalue = new System.Windows.Forms.Label();
            this.Tempvalue = new System.Windows.Forms.Label();
            this.templowlabel = new System.Windows.Forms.Label();
            this.templowvalue = new System.Windows.Forms.Label();
            this.temphighvalue = new System.Windows.Forms.Label();
            this.descriptionvalue = new System.Windows.Forms.Label();
            this.Cloudlabel = new System.Windows.Forms.Label();
            this.Cloudvalue = new System.Windows.Forms.Label();
            this.Humiditylabel = new System.Windows.Forms.Label();
            this.pressurevalue = new System.Windows.Forms.Label();
            this.pressurelabel = new System.Windows.Forms.Label();
            this.humidityvalue = new System.Windows.Forms.Label();
            this.visibilityvalue = new System.Windows.Forms.Label();
            this.visibilitylabel = new System.Windows.Forms.Label();
            this.winddegvalue = new System.Windows.Forms.Label();
            this.windspeedvalue = new System.Windows.Forms.Label();
            this.previousbutton = new System.Windows.Forms.Button();
            this.nextbutton = new System.Windows.Forms.Button();
            this.weatherDatabaseDataSet = new WeatherApp.WeatherDatabaseDataSet();
            this.weatherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.weatherTableAdapter = new WeatherApp.WeatherDatabaseDataSetTableAdapters.WeatherTableAdapter();
            this.citycombobox = new System.Windows.Forms.ComboBox();
            this.weatherpictureBox = new System.Windows.Forms.PictureBox();
            this.Winddeglabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.weatherhistorybutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.weatherDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Temphighlabel
            // 
            this.Temphighlabel.AutoSize = true;
            this.Temphighlabel.Location = new System.Drawing.Point(475, 197);
            this.Temphighlabel.Name = "Temphighlabel";
            this.Temphighlabel.Size = new System.Drawing.Size(41, 17);
            this.Temphighlabel.TabIndex = 5;
            this.Temphighlabel.Text = "High:";
            // 
            // datevalue
            // 
            this.datevalue.AutoSize = true;
            this.datevalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datevalue.Location = new System.Drawing.Point(46, 92);
            this.datevalue.Name = "datevalue";
            this.datevalue.Size = new System.Drawing.Size(58, 26);
            this.datevalue.TabIndex = 3;
            this.datevalue.Text = "Date";
            // 
            // coordvalue
            // 
            this.coordvalue.AutoSize = true;
            this.coordvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coordvalue.Location = new System.Drawing.Point(196, 57);
            this.coordvalue.Name = "coordvalue";
            this.coordvalue.Size = new System.Drawing.Size(90, 26);
            this.coordvalue.TabIndex = 2;
            this.coordvalue.Text = "Lat, Lon";
            // 
            // Tempvalue
            // 
            this.Tempvalue.AutoSize = true;
            this.Tempvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tempvalue.Location = new System.Drawing.Point(360, 118);
            this.Tempvalue.Name = "Tempvalue";
            this.Tempvalue.Size = new System.Drawing.Size(227, 76);
            this.Tempvalue.TabIndex = 4;
            this.Tempvalue.Text = "00.00°";
            // 
            // templowlabel
            // 
            this.templowlabel.AutoSize = true;
            this.templowlabel.Location = new System.Drawing.Point(475, 214);
            this.templowlabel.Name = "templowlabel";
            this.templowlabel.Size = new System.Drawing.Size(37, 17);
            this.templowlabel.TabIndex = 6;
            this.templowlabel.Text = "Low:";
            // 
            // templowvalue
            // 
            this.templowvalue.AutoSize = true;
            this.templowvalue.Location = new System.Drawing.Point(511, 214);
            this.templowvalue.Name = "templowvalue";
            this.templowvalue.Size = new System.Drawing.Size(14, 17);
            this.templowvalue.TabIndex = 8;
            this.templowvalue.Text = "°";
            // 
            // temphighvalue
            // 
            this.temphighvalue.AutoSize = true;
            this.temphighvalue.Location = new System.Drawing.Point(514, 197);
            this.temphighvalue.Name = "temphighvalue";
            this.temphighvalue.Size = new System.Drawing.Size(14, 17);
            this.temphighvalue.TabIndex = 7;
            this.temphighvalue.Text = "°";
            // 
            // descriptionvalue
            // 
            this.descriptionvalue.AutoSize = true;
            this.descriptionvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionvalue.Location = new System.Drawing.Point(47, 275);
            this.descriptionvalue.Name = "descriptionvalue";
            this.descriptionvalue.Size = new System.Drawing.Size(267, 31);
            this.descriptionvalue.TabIndex = 9;
            this.descriptionvalue.Text = "Light intensity drizzle";
            // 
            // Cloudlabel
            // 
            this.Cloudlabel.AutoSize = true;
            this.Cloudlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cloudlabel.Location = new System.Drawing.Point(46, 329);
            this.Cloudlabel.Name = "Cloudlabel";
            this.Cloudlabel.Size = new System.Drawing.Size(75, 26);
            this.Cloudlabel.TabIndex = 10;
            this.Cloudlabel.Text = "Cloud:";
            // 
            // Cloudvalue
            // 
            this.Cloudvalue.AutoSize = true;
            this.Cloudvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cloudvalue.Location = new System.Drawing.Point(117, 329);
            this.Cloudvalue.Name = "Cloudvalue";
            this.Cloudvalue.Size = new System.Drawing.Size(32, 26);
            this.Cloudvalue.TabIndex = 11;
            this.Cloudvalue.Text = "%";
            // 
            // Humiditylabel
            // 
            this.Humiditylabel.AutoSize = true;
            this.Humiditylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Humiditylabel.Location = new System.Drawing.Point(46, 399);
            this.Humiditylabel.Name = "Humiditylabel";
            this.Humiditylabel.Size = new System.Drawing.Size(104, 26);
            this.Humiditylabel.TabIndex = 12;
            this.Humiditylabel.Text = "Humidity:";
            // 
            // pressurevalue
            // 
            this.pressurevalue.AutoSize = true;
            this.pressurevalue.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pressurevalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressurevalue.Location = new System.Drawing.Point(346, 329);
            this.pressurevalue.Name = "pressurevalue";
            this.pressurevalue.Size = new System.Drawing.Size(51, 26);
            this.pressurevalue.TabIndex = 15;
            this.pressurevalue.Text = "hPa";
            // 
            // pressurelabel
            // 
            this.pressurelabel.AutoSize = true;
            this.pressurelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressurelabel.Location = new System.Drawing.Point(239, 329);
            this.pressurelabel.Name = "pressurelabel";
            this.pressurelabel.Size = new System.Drawing.Size(105, 26);
            this.pressurelabel.TabIndex = 14;
            this.pressurelabel.Text = "Pressure:";
            // 
            // humidityvalue
            // 
            this.humidityvalue.AutoSize = true;
            this.humidityvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityvalue.Location = new System.Drawing.Point(144, 399);
            this.humidityvalue.Name = "humidityvalue";
            this.humidityvalue.Size = new System.Drawing.Size(32, 26);
            this.humidityvalue.TabIndex = 16;
            this.humidityvalue.Text = "%";
            // 
            // visibilityvalue
            // 
            this.visibilityvalue.AutoSize = true;
            this.visibilityvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visibilityvalue.Location = new System.Drawing.Point(337, 399);
            this.visibilityvalue.Name = "visibilityvalue";
            this.visibilityvalue.Size = new System.Drawing.Size(31, 26);
            this.visibilityvalue.TabIndex = 18;
            this.visibilityvalue.Text = "m";
            // 
            // visibilitylabel
            // 
            this.visibilitylabel.AutoSize = true;
            this.visibilitylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visibilitylabel.Location = new System.Drawing.Point(239, 399);
            this.visibilitylabel.Name = "visibilitylabel";
            this.visibilitylabel.Size = new System.Drawing.Size(98, 26);
            this.visibilitylabel.TabIndex = 17;
            this.visibilitylabel.Text = "Visibility:";
            // 
            // winddegvalue
            // 
            this.winddegvalue.AutoSize = true;
            this.winddegvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winddegvalue.Location = new System.Drawing.Point(672, 326);
            this.winddegvalue.Name = "winddegvalue";
            this.winddegvalue.Size = new System.Drawing.Size(41, 29);
            this.winddegvalue.TabIndex = 20;
            this.winddegvalue.Text = "70";
            // 
            // windspeedvalue
            // 
            this.windspeedvalue.AutoSize = true;
            this.windspeedvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windspeedvalue.Location = new System.Drawing.Point(632, 396);
            this.windspeedvalue.Name = "windspeedvalue";
            this.windspeedvalue.Size = new System.Drawing.Size(41, 29);
            this.windspeedvalue.TabIndex = 21;
            this.windspeedvalue.Text = "70";
            // 
            // previousbutton
            // 
            this.previousbutton.Location = new System.Drawing.Point(391, 19);
            this.previousbutton.Name = "previousbutton";
            this.previousbutton.Size = new System.Drawing.Size(30, 30);
            this.previousbutton.TabIndex = 22;
            this.previousbutton.Text = "◀";
            this.previousbutton.UseVisualStyleBackColor = true;
            this.previousbutton.Click += new System.EventHandler(this.previousbutton_Click);
            // 
            // nextbutton
            // 
            this.nextbutton.Location = new System.Drawing.Point(427, 19);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(30, 30);
            this.nextbutton.TabIndex = 23;
            this.nextbutton.Text = "▶";
            this.nextbutton.UseVisualStyleBackColor = true;
            this.nextbutton.Click += new System.EventHandler(this.nextbutton_Click);
            // 
            // weatherDatabaseDataSet
            // 
            this.weatherDatabaseDataSet.DataSetName = "WeatherDatabaseDataSet";
            this.weatherDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // weatherBindingSource
            // 
            this.weatherBindingSource.DataMember = "Weather";
            this.weatherBindingSource.DataSource = this.weatherDatabaseDataSet;
            // 
            // weatherTableAdapter
            // 
            this.weatherTableAdapter.ClearBeforeFill = true;
            // 
            // citycombobox
            // 
            this.citycombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citycombobox.FormattingEnabled = true;
            this.citycombobox.Location = new System.Drawing.Point(49, 12);
            this.citycombobox.Name = "citycombobox";
            this.citycombobox.Size = new System.Drawing.Size(340, 37);
            this.citycombobox.TabIndex = 24;
            // 
            // weatherpictureBox
            // 
            this.weatherpictureBox.Image = global::WeatherApp.Properties.Resources.NA;
            this.weatherpictureBox.InitialImage = null;
            this.weatherpictureBox.Location = new System.Drawing.Point(53, 118);
            this.weatherpictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.weatherpictureBox.Name = "weatherpictureBox";
            this.weatherpictureBox.Size = new System.Drawing.Size(233, 157);
            this.weatherpictureBox.TabIndex = 0;
            this.weatherpictureBox.TabStop = false;
            // 
            // Winddeglabel
            // 
            this.Winddeglabel.AutoSize = true;
            this.Winddeglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Winddeglabel.Location = new System.Drawing.Point(481, 326);
            this.Winddeglabel.Name = "Winddeglabel";
            this.Winddeglabel.Size = new System.Drawing.Size(185, 29);
            this.Winddeglabel.TabIndex = 25;
            this.Winddeglabel.Text = "Wind Direction:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(479, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 29);
            this.label2.TabIndex = 26;
            this.label2.Text = "Windspeed:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1800000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // weatherhistorybutton
            // 
            this.weatherhistorybutton.Location = new System.Drawing.Point(501, 12);
            this.weatherhistorybutton.Name = "weatherhistorybutton";
            this.weatherhistorybutton.Size = new System.Drawing.Size(140, 37);
            this.weatherhistorybutton.TabIndex = 27;
            this.weatherhistorybutton.Text = "Weather History";
            this.weatherhistorybutton.UseVisualStyleBackColor = true;
            this.weatherhistorybutton.Click += new System.EventHandler(this.weatherhistorybutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 26);
            this.label1.TabIndex = 28;
            this.label1.Text = "Coordinates:";
            // 
            // v
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 499);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weatherhistorybutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Winddeglabel);
            this.Controls.Add(this.citycombobox);
            this.Controls.Add(this.nextbutton);
            this.Controls.Add(this.previousbutton);
            this.Controls.Add(this.windspeedvalue);
            this.Controls.Add(this.winddegvalue);
            this.Controls.Add(this.visibilityvalue);
            this.Controls.Add(this.visibilitylabel);
            this.Controls.Add(this.humidityvalue);
            this.Controls.Add(this.pressurevalue);
            this.Controls.Add(this.pressurelabel);
            this.Controls.Add(this.Humiditylabel);
            this.Controls.Add(this.Cloudvalue);
            this.Controls.Add(this.Cloudlabel);
            this.Controls.Add(this.descriptionvalue);
            this.Controls.Add(this.templowvalue);
            this.Controls.Add(this.temphighvalue);
            this.Controls.Add(this.templowlabel);
            this.Controls.Add(this.Temphighlabel);
            this.Controls.Add(this.Tempvalue);
            this.Controls.Add(this.datevalue);
            this.Controls.Add(this.coordvalue);
            this.Controls.Add(this.weatherpictureBox);
            this.Name = "v";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.weatherDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Label Temphighlabel;
        private System.Windows.Forms.Label datevalue;
        private System.Windows.Forms.Label coordvalue;
        private System.Windows.Forms.PictureBox weatherpictureBox;
        private System.Windows.Forms.Label Tempvalue;
        private System.Windows.Forms.Label templowlabel;
        private System.Windows.Forms.Label templowvalue;
        private System.Windows.Forms.Label temphighvalue;
        private System.Windows.Forms.Label descriptionvalue;
        private System.Windows.Forms.Label Cloudlabel;
        private System.Windows.Forms.Label Cloudvalue;
        private System.Windows.Forms.Label Humiditylabel;
        private System.Windows.Forms.Label pressurevalue;
        private System.Windows.Forms.Label pressurelabel;
        private System.Windows.Forms.Label humidityvalue;
        private System.Windows.Forms.Label visibilityvalue;
        private System.Windows.Forms.Label visibilitylabel;
        private System.Windows.Forms.Label winddegvalue;
        private System.Windows.Forms.Label windspeedvalue;
        private System.Windows.Forms.Button previousbutton;
        private System.Windows.Forms.Button nextbutton;
        private WeatherDatabaseDataSet weatherDatabaseDataSet;
        private System.Windows.Forms.BindingSource weatherBindingSource;
        private WeatherDatabaseDataSetTableAdapters.WeatherTableAdapter weatherTableAdapter;
        private System.Windows.Forms.ComboBox citycombobox;
        private System.Windows.Forms.Label Winddeglabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button weatherhistorybutton;
        private System.Windows.Forms.Label label1;
    }
}

