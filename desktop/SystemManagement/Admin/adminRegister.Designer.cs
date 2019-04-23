namespace SystemManagement.Admin
{
    partial class adminRegister
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
            this.adminidlbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.adminnamelbl = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.adminpasswordlbl = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.adminpinlbl = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.adminmbllbl = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.adminemaillbl = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.adminEIDlbl = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.adminDOB = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.adminaddlbl = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.adminsave = new System.Windows.Forms.Button();
            this.adminupdate = new System.Windows.Forms.Button();
            this.admindelete = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // adminidlbl
            // 
            this.adminidlbl.AutoSize = true;
            this.adminidlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminidlbl.Location = new System.Drawing.Point(50, 73);
            this.adminidlbl.Name = "adminidlbl";
            this.adminidlbl.Size = new System.Drawing.Size(75, 18);
            this.adminidlbl.TabIndex = 0;
            this.adminidlbl.Text = "Admin ID: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // adminnamelbl
            // 
            this.adminnamelbl.AutoSize = true;
            this.adminnamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminnamelbl.Location = new System.Drawing.Point(50, 111);
            this.adminnamelbl.Name = "adminnamelbl";
            this.adminnamelbl.Size = new System.Drawing.Size(56, 18);
            this.adminnamelbl.TabIndex = 2;
            this.adminnamelbl.Text = "Name: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // adminpasswordlbl
            // 
            this.adminpasswordlbl.AutoSize = true;
            this.adminpasswordlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminpasswordlbl.Location = new System.Drawing.Point(50, 146);
            this.adminpasswordlbl.Name = "adminpasswordlbl";
            this.adminpasswordlbl.Size = new System.Drawing.Size(79, 18);
            this.adminpasswordlbl.TabIndex = 4;
            this.adminpasswordlbl.Text = "Password:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(131, 147);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(159, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            // 
            // adminpinlbl
            // 
            this.adminpinlbl.AutoSize = true;
            this.adminpinlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminpinlbl.Location = new System.Drawing.Point(50, 189);
            this.adminpinlbl.Name = "adminpinlbl";
            this.adminpinlbl.Size = new System.Drawing.Size(73, 18);
            this.adminpinlbl.TabIndex = 6;
            this.adminpinlbl.Text = "Pin Code:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(131, 189);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(159, 20);
            this.textBox4.TabIndex = 7;
            this.textBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox4_KeyDown);
            // 
            // adminmbllbl
            // 
            this.adminmbllbl.AutoSize = true;
            this.adminmbllbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminmbllbl.Location = new System.Drawing.Point(50, 230);
            this.adminmbllbl.Name = "adminmbllbl";
            this.adminmbllbl.Size = new System.Drawing.Size(80, 18);
            this.adminmbllbl.TabIndex = 8;
            this.adminmbllbl.Text = "Mobile No:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(131, 228);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(159, 20);
            this.textBox5.TabIndex = 9;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.textBox5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox5_KeyDown);
            // 
            // adminemaillbl
            // 
            this.adminemaillbl.AutoSize = true;
            this.adminemaillbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminemaillbl.Location = new System.Drawing.Point(495, 77);
            this.adminemaillbl.Name = "adminemaillbl";
            this.adminemaillbl.Size = new System.Drawing.Size(53, 18);
            this.adminemaillbl.TabIndex = 10;
            this.adminemaillbl.Text = "Email: ";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(568, 78);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(218, 20);
            this.textBox6.TabIndex = 11;
            this.textBox6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox6_KeyDown);
            // 
            // adminEIDlbl
            // 
            this.adminEIDlbl.AllowDrop = true;
            this.adminEIDlbl.AutoSize = true;
            this.adminEIDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminEIDlbl.Location = new System.Drawing.Point(498, 115);
            this.adminEIDlbl.Name = "adminEIDlbl";
            this.adminEIDlbl.Size = new System.Drawing.Size(48, 18);
            this.adminEIDlbl.TabIndex = 12;
            this.adminEIDlbl.Text = "E_ID: ";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(568, 115);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(218, 20);
            this.textBox7.TabIndex = 13;
            // 
            // adminDOB
            // 
            this.adminDOB.AutoSize = true;
            this.adminDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminDOB.Location = new System.Drawing.Point(497, 150);
            this.adminDOB.Name = "adminDOB";
            this.adminDOB.Size = new System.Drawing.Size(49, 18);
            this.adminDOB.TabIndex = 14;
            this.adminDOB.Text = "DOB: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(568, 150);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(218, 20);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.Value = new System.DateTime(2018, 11, 20, 0, 0, 0, 0);
            // 
            // adminaddlbl
            // 
            this.adminaddlbl.AutoEllipsis = true;
            this.adminaddlbl.AutoSize = true;
            this.adminaddlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminaddlbl.Location = new System.Drawing.Point(498, 192);
            this.adminaddlbl.Name = "adminaddlbl";
            this.adminaddlbl.Size = new System.Drawing.Size(66, 18);
            this.adminaddlbl.TabIndex = 16;
            this.adminaddlbl.Text = "Address:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(568, 193);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(218, 55);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            // 
            // adminsave
            // 
            this.adminsave.Location = new System.Drawing.Point(142, 313);
            this.adminsave.Name = "adminsave";
            this.adminsave.Size = new System.Drawing.Size(92, 38);
            this.adminsave.TabIndex = 18;
            this.adminsave.Text = "Save";
            this.adminsave.UseVisualStyleBackColor = true;
            this.adminsave.Click += new System.EventHandler(this.adminsave_Click);
            // 
            // adminupdate
            // 
            this.adminupdate.Location = new System.Drawing.Point(409, 313);
            this.adminupdate.Name = "adminupdate";
            this.adminupdate.Size = new System.Drawing.Size(84, 38);
            this.adminupdate.TabIndex = 19;
            this.adminupdate.Text = "Update";
            this.adminupdate.UseVisualStyleBackColor = true;
            this.adminupdate.Click += new System.EventHandler(this.adminupdate_Click);
            // 
            // admindelete
            // 
            this.admindelete.Location = new System.Drawing.Point(662, 313);
            this.admindelete.Name = "admindelete";
            this.admindelete.Size = new System.Drawing.Size(75, 38);
            this.admindelete.TabIndex = 20;
            this.admindelete.Text = "Delete";
            this.admindelete.UseVisualStyleBackColor = true;
            this.admindelete.Click += new System.EventHandler(this.admindelete_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(108, 414);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(736, 150);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // adminRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 625);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.admindelete);
            this.Controls.Add(this.adminupdate);
            this.Controls.Add(this.adminsave);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.adminaddlbl);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.adminDOB);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.adminEIDlbl);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.adminemaillbl);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.adminmbllbl);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.adminpinlbl);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.adminpasswordlbl);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.adminnamelbl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.adminidlbl);
            this.Name = "adminRegister";
            this.Text = "adminRegister";
            this.Load += new System.EventHandler(this.adminRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adminidlbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label adminnamelbl;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label adminpasswordlbl;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label adminpinlbl;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label adminmbllbl;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label adminemaillbl;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label adminEIDlbl;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label adminDOB;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label adminaddlbl;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button adminsave;
        private System.Windows.Forms.Button adminupdate;
        private System.Windows.Forms.Button admindelete;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}