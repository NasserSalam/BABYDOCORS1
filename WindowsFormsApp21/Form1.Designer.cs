namespace WindowsFormsApp21
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
            this.datainfo = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.THi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TWi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TBlood = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TPho = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TAL = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TBook = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TPre = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datainfo)).BeginInit();
            this.SuspendLayout();
            // 
            // datainfo
            // 
            this.datainfo.AllowUserToAddRows = false;
            this.datainfo.AllowUserToDeleteRows = false;
            this.datainfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datainfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datainfo.Location = new System.Drawing.Point(32, 433);
            this.datainfo.Name = "datainfo";
            this.datainfo.ReadOnly = true;
            this.datainfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datainfo.Size = new System.Drawing.Size(1143, 152);
            this.datainfo.TabIndex = 0;
            this.datainfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datainfo_CellContentClick);
            this.datainfo.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.datainfo_CellEnter);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.btnInsert.Location = new System.Drawing.Point(296, 601);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(107, 44);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "اضافة";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.btnUpdate.Location = new System.Drawing.Point(409, 601);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 44);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "تعديل";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.btnDelete.Location = new System.Drawing.Point(522, 602);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 44);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(931, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "التسلسل";
            // 
            // TID
            // 
            this.TID.Enabled = false;
            this.TID.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TID.Location = new System.Drawing.Point(637, 67);
            this.TID.Name = "TID";
            this.TID.Size = new System.Drawing.Size(288, 33);
            this.TID.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(931, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "اسم المريض";
            // 
            // TName
            // 
            this.TName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TName.Location = new System.Drawing.Point(637, 120);
            this.TName.Name = "TName";
            this.TName.Size = new System.Drawing.Size(288, 33);
            this.TName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(931, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "العمر";
            // 
            // TAge
            // 
            this.TAge.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TAge.Location = new System.Drawing.Point(637, 170);
            this.TAge.Name = "TAge";
            this.TAge.Size = new System.Drawing.Size(288, 33);
            this.TAge.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(931, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "الطول";
            // 
            // THi
            // 
            this.THi.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.THi.Location = new System.Drawing.Point(637, 228);
            this.THi.Name = "THi";
            this.THi.Size = new System.Drawing.Size(288, 33);
            this.THi.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(931, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "الوزن";
            // 
            // TWi
            // 
            this.TWi.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TWi.Location = new System.Drawing.Point(637, 278);
            this.TWi.Name = "TWi";
            this.TWi.Size = new System.Drawing.Size(288, 33);
            this.TWi.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(464, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "فصيلة الدم";
            // 
            // TBlood
            // 
            this.TBlood.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBlood.Location = new System.Drawing.Point(170, 70);
            this.TBlood.Name = "TBlood";
            this.TBlood.Size = new System.Drawing.Size(288, 33);
            this.TBlood.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(464, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "رقم الهاتف";
            // 
            // TPho
            // 
            this.TPho.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPho.Location = new System.Drawing.Point(170, 117);
            this.TPho.Name = "TPho";
            this.TPho.Size = new System.Drawing.Size(288, 33);
            this.TPho.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(464, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "التحسس";
            // 
            // TAL
            // 
            this.TAL.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TAL.Location = new System.Drawing.Point(170, 175);
            this.TAL.Name = "TAL";
            this.TAL.Size = new System.Drawing.Size(288, 33);
            this.TAL.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(464, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "رقم الحجز";
            // 
            // TBook
            // 
            this.TBook.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBook.Location = new System.Drawing.Point(170, 225);
            this.TBook.Name = "TBook";
            this.TBook.Size = new System.Drawing.Size(288, 33);
            this.TBook.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(464, 281);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 25);
            this.label10.TabIndex = 4;
            this.label10.Text = "موعد الحجز";
            // 
            // TPre
            // 
            this.TPre.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPre.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TPre.Location = new System.Drawing.Point(170, 281);
            this.TPre.Name = "TPre";
            this.TPre.Size = new System.Drawing.Size(288, 30);
            this.TPre.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(649, 601);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 44);
            this.button1.TabIndex = 11;
            this.button1.Text = "رجوع";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button4.Location = new System.Drawing.Point(776, 602);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 44);
            this.button4.TabIndex = 15;
            this.button4.Text = "خروج";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp21.Properties.Resources.Nasser;
            this.ClientSize = new System.Drawing.Size(1223, 653);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TPre);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TBook);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TAL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TPho);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TBlood);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TWi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.THi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.datainfo);
            this.Name = "Form1";
            this.Text = "السكرتير";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datainfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datainfo;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox THi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TWi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBlood;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TPho;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TAL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TBook;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker TPre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}

