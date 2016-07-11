namespace Food_Order
{
    partial class Form1
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dGV1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.rdLunch = new System.Windows.Forms.RadioButton();
            this.rdDinner = new System.Windows.Forms.RadioButton();
            this.rdSehri = new System.Windows.Forms.RadioButton();
            this.rdIftar = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.ControlDarkDark;
            this.dateTimePicker1.Location = new System.Drawing.Point(115, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(35, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date :";
            // 
            // dGV1
            // 
            this.dGV1.AllowUserToDeleteRows = false;
            this.dGV1.AllowUserToResizeColumns = false;
            this.dGV1.AllowUserToResizeRows = false;
            this.dGV1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dGV1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dGV1.Location = new System.Drawing.Point(3, 16);
            this.dGV1.Name = "dGV1";
            this.dGV1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dGV1.Size = new System.Drawing.Size(989, 240);
            this.dGV1.TabIndex = 2;
            this.dGV1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGV1_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "EmployeeName";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "EmployeeCode";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Project";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Department";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Todays_InTime";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "OrderTime";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Food_Requested";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "FlNight";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Ramadan";
            this.Column9.Name = "Column9";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dGV1);
            this.groupBox1.Location = new System.Drawing.Point(12, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(995, 259);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(899, 57);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(108, 50);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "View List";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(899, 456);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 50);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnExcel.Location = new System.Drawing.Point(12, 456);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(163, 50);
            this.btnExcel.TabIndex = 6;
            this.btnExcel.Text = "Export To Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // rdLunch
            // 
            this.rdLunch.AutoSize = true;
            this.rdLunch.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.rdLunch.Location = new System.Drawing.Point(446, 27);
            this.rdLunch.Name = "rdLunch";
            this.rdLunch.Size = new System.Drawing.Size(81, 30);
            this.rdLunch.TabIndex = 7;
            this.rdLunch.TabStop = true;
            this.rdLunch.Text = "Lunch";
            this.rdLunch.UseVisualStyleBackColor = true;
            // 
            // rdDinner
            // 
            this.rdDinner.AutoSize = true;
            this.rdDinner.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.rdDinner.Location = new System.Drawing.Point(446, 91);
            this.rdDinner.Name = "rdDinner";
            this.rdDinner.Size = new System.Drawing.Size(88, 30);
            this.rdDinner.TabIndex = 8;
            this.rdDinner.TabStop = true;
            this.rdDinner.Text = "Dinner";
            this.rdDinner.UseVisualStyleBackColor = true;
            // 
            // rdSehri
            // 
            this.rdSehri.AutoSize = true;
            this.rdSehri.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.rdSehri.Location = new System.Drawing.Point(688, 27);
            this.rdSehri.Name = "rdSehri";
            this.rdSehri.Size = new System.Drawing.Size(74, 30);
            this.rdSehri.TabIndex = 9;
            this.rdSehri.TabStop = true;
            this.rdSehri.Text = "Sehri";
            this.rdSehri.UseVisualStyleBackColor = true;
            // 
            // rdIftar
            // 
            this.rdIftar.AutoSize = true;
            this.rdIftar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.rdIftar.Location = new System.Drawing.Point(688, 91);
            this.rdIftar.Name = "rdIftar";
            this.rdIftar.Size = new System.Drawing.Size(66, 30);
            this.rdIftar.TabIndex = 10;
            this.rdIftar.TabStop = true;
            this.rdIftar.Text = "Iftar";
            this.rdIftar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.rdIftar);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.rdSehri);
            this.groupBox2.Controls.Add(this.rdLunch);
            this.groupBox2.Controls.Add(this.rdDinner);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(32);
            this.groupBox2.Size = new System.Drawing.Size(853, 155);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "EmpID";
            this.Column10.Name = "Column10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 537);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order_Food";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGV1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.RadioButton rdLunch;
        private System.Windows.Forms.RadioButton rdDinner;
        private System.Windows.Forms.RadioButton rdSehri;
        private System.Windows.Forms.RadioButton rdIftar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}

