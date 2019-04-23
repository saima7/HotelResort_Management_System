namespace SystemManagement.Forms
{
    partial class Form_total
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbpaymentmethod = new System.Windows.Forms.ComboBox();
            this.lblchange = new System.Windows.Forms.Label();
            this.txtpaid = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltax = new System.Windows.Forms.Label();
            this.btnreset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btntotal = new System.Windows.Forms.Button();
            this.lblsubtotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtcharge = new System.Windows.Forms.TextBox();
            this.txtbeds = new System.Windows.Forms.TextBox();
            this.txtfamily = new System.Windows.Forms.TextBox();
            this.txtdouble = new System.Windows.Forms.TextBox();
            this.txtsingle = new System.Windows.Forms.TextBox();
            this.chksingle = new System.Windows.Forms.CheckBox();
            this.chkdouble = new System.Windows.Forms.CheckBox();
            this.chkfamily = new System.Windows.Forms.CheckBox();
            this.chkbeds = new System.Windows.Forms.CheckBox();
            this.chkcharge = new System.Windows.Forms.CheckBox();
            this.dtpcheckin = new System.Windows.Forms.DateTimePicker();
            this.dtpcheckout = new System.Windows.Forms.DateTimePicker();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(920, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cmbpaymentmethod);
            this.panel3.Controls.Add(this.lblchange);
            this.panel3.Controls.Add(this.txtpaid);
            this.panel3.Controls.Add(this.lbltotal);
            this.panel3.Controls.Add(this.btnexit);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lbltax);
            this.panel3.Controls.Add(this.btnreset);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btntotal);
            this.panel3.Controls.Add(this.lblsubtotal);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(497, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(333, 344);
            this.panel3.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Payment Method";
            // 
            // cmbpaymentmethod
            // 
            this.cmbpaymentmethod.FormattingEnabled = true;
            this.cmbpaymentmethod.Location = new System.Drawing.Point(125, 25);
            this.cmbpaymentmethod.Name = "cmbpaymentmethod";
            this.cmbpaymentmethod.Size = new System.Drawing.Size(121, 21);
            this.cmbpaymentmethod.TabIndex = 13;
            // 
            // lblchange
            // 
            this.lblchange.BackColor = System.Drawing.Color.White;
            this.lblchange.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblchange.Location = new System.Drawing.Point(134, 217);
            this.lblchange.Name = "lblchange";
            this.lblchange.Size = new System.Drawing.Size(100, 23);
            this.lblchange.TabIndex = 28;
            // 
            // txtpaid
            // 
            this.txtpaid.Location = new System.Drawing.Point(125, 62);
            this.txtpaid.Name = "txtpaid";
            this.txtpaid.Size = new System.Drawing.Size(100, 20);
            this.txtpaid.TabIndex = 14;
            // 
            // lbltotal
            // 
            this.lbltotal.BackColor = System.Drawing.Color.White;
            this.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltotal.Location = new System.Drawing.Point(134, 176);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(100, 23);
            this.lbltotal.TabIndex = 27;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(226, 263);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 12;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Paid";
            // 
            // lbltax
            // 
            this.lbltax.BackColor = System.Drawing.Color.White;
            this.lbltax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltax.Location = new System.Drawing.Point(131, 146);
            this.lbltax.Name = "lbltax";
            this.lbltax.Size = new System.Drawing.Size(100, 23);
            this.lbltax.TabIndex = 26;
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(134, 263);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 23);
            this.btnreset.TabIndex = 11;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Subtotal";
            // 
            // btntotal
            // 
            this.btntotal.Location = new System.Drawing.Point(37, 263);
            this.btntotal.Name = "btntotal";
            this.btntotal.Size = new System.Drawing.Size(75, 23);
            this.btntotal.TabIndex = 10;
            this.btntotal.Text = "Total";
            this.btntotal.UseVisualStyleBackColor = true;
            // 
            // lblsubtotal
            // 
            this.lblsubtotal.BackColor = System.Drawing.Color.White;
            this.lblsubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblsubtotal.Location = new System.Drawing.Point(131, 114);
            this.lblsubtotal.Name = "lblsubtotal";
            this.lblsubtotal.Size = new System.Drawing.Size(100, 23);
            this.lblsubtotal.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tax";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Change";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Total";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtcharge);
            this.panel2.Controls.Add(this.txtbeds);
            this.panel2.Controls.Add(this.txtfamily);
            this.panel2.Controls.Add(this.txtdouble);
            this.panel2.Controls.Add(this.txtsingle);
            this.panel2.Controls.Add(this.chksingle);
            this.panel2.Controls.Add(this.chkdouble);
            this.panel2.Controls.Add(this.chkfamily);
            this.panel2.Controls.Add(this.chkbeds);
            this.panel2.Controls.Add(this.chkcharge);
            this.panel2.Controls.Add(this.dtpcheckin);
            this.panel2.Controls.Add(this.dtpcheckout);
            this.panel2.Location = new System.Drawing.Point(77, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 344);
            this.panel2.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 270);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Check Out";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 224);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Check In";
            // 
            // txtcharge
            // 
            this.txtcharge.Location = new System.Drawing.Point(135, 173);
            this.txtcharge.Name = "txtcharge";
            this.txtcharge.Size = new System.Drawing.Size(100, 20);
            this.txtcharge.TabIndex = 16;
            // 
            // txtbeds
            // 
            this.txtbeds.Location = new System.Drawing.Point(135, 136);
            this.txtbeds.Name = "txtbeds";
            this.txtbeds.Size = new System.Drawing.Size(100, 20);
            this.txtbeds.TabIndex = 15;
            // 
            // txtfamily
            // 
            this.txtfamily.Location = new System.Drawing.Point(135, 96);
            this.txtfamily.Name = "txtfamily";
            this.txtfamily.Size = new System.Drawing.Size(100, 20);
            this.txtfamily.TabIndex = 14;
            // 
            // txtdouble
            // 
            this.txtdouble.Location = new System.Drawing.Point(135, 59);
            this.txtdouble.Name = "txtdouble";
            this.txtdouble.Size = new System.Drawing.Size(100, 20);
            this.txtdouble.TabIndex = 13;
            // 
            // txtsingle
            // 
            this.txtsingle.Location = new System.Drawing.Point(135, 26);
            this.txtsingle.Name = "txtsingle";
            this.txtsingle.Size = new System.Drawing.Size(100, 20);
            this.txtsingle.TabIndex = 12;
            // 
            // chksingle
            // 
            this.chksingle.AutoSize = true;
            this.chksingle.Location = new System.Drawing.Point(26, 24);
            this.chksingle.Name = "chksingle";
            this.chksingle.Size = new System.Drawing.Size(55, 17);
            this.chksingle.TabIndex = 5;
            this.chksingle.Text = "Single";
            this.chksingle.UseVisualStyleBackColor = true;
            // 
            // chkdouble
            // 
            this.chkdouble.AutoSize = true;
            this.chkdouble.Location = new System.Drawing.Point(26, 59);
            this.chkdouble.Name = "chkdouble";
            this.chkdouble.Size = new System.Drawing.Size(60, 17);
            this.chkdouble.TabIndex = 6;
            this.chkdouble.Text = "Double";
            this.chkdouble.UseVisualStyleBackColor = true;
            // 
            // chkfamily
            // 
            this.chkfamily.AutoSize = true;
            this.chkfamily.Location = new System.Drawing.Point(26, 96);
            this.chkfamily.Name = "chkfamily";
            this.chkfamily.Size = new System.Drawing.Size(55, 17);
            this.chkfamily.TabIndex = 7;
            this.chkfamily.Text = "Family";
            this.chkfamily.UseVisualStyleBackColor = true;
            // 
            // chkbeds
            // 
            this.chkbeds.AutoSize = true;
            this.chkbeds.Location = new System.Drawing.Point(26, 139);
            this.chkbeds.Name = "chkbeds";
            this.chkbeds.Size = new System.Drawing.Size(77, 17);
            this.chkbeds.TabIndex = 8;
            this.chkbeds.Text = "Extra Beds";
            this.chkbeds.UseVisualStyleBackColor = true;
            // 
            // chkcharge
            // 
            this.chkcharge.AutoSize = true;
            this.chkcharge.Location = new System.Drawing.Point(26, 173);
            this.chkcharge.Name = "chkcharge";
            this.chkcharge.Size = new System.Drawing.Size(99, 17);
            this.chkcharge.TabIndex = 9;
            this.chkcharge.Text = "Service Charge";
            this.chkcharge.UseVisualStyleBackColor = true;
            // 
            // dtpcheckin
            // 
            this.dtpcheckin.Location = new System.Drawing.Point(135, 218);
            this.dtpcheckin.Name = "dtpcheckin";
            this.dtpcheckin.Size = new System.Drawing.Size(200, 20);
            this.dtpcheckin.TabIndex = 10;
            // 
            // dtpcheckout
            // 
            this.dtpcheckout.Location = new System.Drawing.Point(135, 264);
            this.dtpcheckout.Name = "dtpcheckout";
            this.dtpcheckout.Size = new System.Drawing.Size(200, 20);
            this.dtpcheckout.TabIndex = 11;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DodgerBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(262, 479);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 37);
            this.button5.TabIndex = 35;
            this.button5.Text = "Total";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(397, 479);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 37);
            this.button2.TabIndex = 36;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(515, 479);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 37);
            this.button3.TabIndex = 37;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Form_total
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(964, 561);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_total";
            this.Text = "Form_total";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbpaymentmethod;
        private System.Windows.Forms.Label lblchange;
        private System.Windows.Forms.TextBox txtpaid;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltax;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btntotal;
        private System.Windows.Forms.Label lblsubtotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtcharge;
        private System.Windows.Forms.TextBox txtbeds;
        private System.Windows.Forms.TextBox txtfamily;
        private System.Windows.Forms.TextBox txtdouble;
        private System.Windows.Forms.TextBox txtsingle;
        private System.Windows.Forms.CheckBox chksingle;
        private System.Windows.Forms.CheckBox chkdouble;
        private System.Windows.Forms.CheckBox chkfamily;
        private System.Windows.Forms.CheckBox chkbeds;
        private System.Windows.Forms.CheckBox chkcharge;
        private System.Windows.Forms.DateTimePicker dtpcheckin;
        private System.Windows.Forms.DateTimePicker dtpcheckout;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}