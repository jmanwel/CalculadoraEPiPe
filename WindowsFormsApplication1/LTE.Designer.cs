namespace WindowsFormsApplication1
{
    partial class LTE
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
            this.textcust1 = new System.Windows.Forms.TextBox();
            this.textcust2 = new System.Windows.Forms.TextBox();
            this.textcust3 = new System.Windows.Forms.TextBox();
            this.Customer = new System.Windows.Forms.Label();
            this.checkcust = new System.Windows.Forms.CheckBox();
            this.checkVPRN = new System.Windows.Forms.CheckBox();
            this.textvprn3 = new System.Windows.Forms.TextBox();
            this.textvprn2 = new System.Windows.Forms.TextBox();
            this.textvprn1 = new System.Windows.Forms.TextBox();
            this.VPRN = new System.Windows.Forms.Label();
            this.VLAN = new System.Windows.Forms.Label();
            this.IP = new System.Windows.Forms.Label();
            this.textvlan3 = new System.Windows.Forms.TextBox();
            this.textip3 = new System.Windows.Forms.TextBox();
            this.textvlan2 = new System.Windows.Forms.TextBox();
            this.textip2 = new System.Windows.Forms.TextBox();
            this.textvlan1 = new System.Windows.Forms.TextBox();
            this.textip1 = new System.Windows.Forms.TextBox();
            this.Int = new System.Windows.Forms.Label();
            this.textIR = new System.Windows.Forms.TextBox();
            this.textport = new System.Windows.Forms.TextBox();
            this.IR = new System.Windows.Forms.Label();
            this.Puerto = new System.Windows.Forms.Label();
            this.checkportexiste = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.RichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textipsar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textcust1
            // 
            this.textcust1.Location = new System.Drawing.Point(6, 18);
            this.textcust1.Name = "textcust1";
            this.textcust1.Size = new System.Drawing.Size(100, 20);
            this.textcust1.TabIndex = 0;
            this.textcust1.Text = "Customer1";
            // 
            // textcust2
            // 
            this.textcust2.Location = new System.Drawing.Point(6, 48);
            this.textcust2.Name = "textcust2";
            this.textcust2.Size = new System.Drawing.Size(100, 20);
            this.textcust2.TabIndex = 1;
            this.textcust2.Text = "Customer2";
            // 
            // textcust3
            // 
            this.textcust3.Location = new System.Drawing.Point(6, 74);
            this.textcust3.Name = "textcust3";
            this.textcust3.Size = new System.Drawing.Size(100, 20);
            this.textcust3.TabIndex = 2;
            this.textcust3.Text = "Customer3";
            // 
            // Customer
            // 
            this.Customer.AutoSize = true;
            this.Customer.Location = new System.Drawing.Point(89, 0);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(56, 13);
            this.Customer.TabIndex = 3;
            this.Customer.Text = "Customers";
            // 
            // checkcust
            // 
            this.checkcust.AutoSize = true;
            this.checkcust.Location = new System.Drawing.Point(120, 48);
            this.checkcust.Name = "checkcust";
            this.checkcust.Size = new System.Drawing.Size(74, 17);
            this.checkcust.TabIndex = 3;
            this.checkcust.Text = "Existentes";
            this.checkcust.UseVisualStyleBackColor = true;
            this.checkcust.CheckedChanged += new System.EventHandler(this.checkcust_CheckedChanged);
            // 
            // checkVPRN
            // 
            this.checkVPRN.AutoSize = true;
            this.checkVPRN.Location = new System.Drawing.Point(114, 44);
            this.checkVPRN.Name = "checkVPRN";
            this.checkVPRN.Size = new System.Drawing.Size(74, 17);
            this.checkVPRN.TabIndex = 5;
            this.checkVPRN.Text = "Existentes";
            this.checkVPRN.UseVisualStyleBackColor = true;
            // 
            // textvprn3
            // 
            this.textvprn3.Location = new System.Drawing.Point(8, 74);
            this.textvprn3.Name = "textvprn3";
            this.textvprn3.Size = new System.Drawing.Size(100, 20);
            this.textvprn3.TabIndex = 8;
            this.textvprn3.Text = "Vprn3";
            // 
            // textvprn2
            // 
            this.textvprn2.Location = new System.Drawing.Point(6, 48);
            this.textvprn2.Name = "textvprn2";
            this.textvprn2.Size = new System.Drawing.Size(100, 20);
            this.textvprn2.TabIndex = 7;
            this.textvprn2.Text = "Vprn2";
            // 
            // textvprn1
            // 
            this.textvprn1.Location = new System.Drawing.Point(5, 18);
            this.textvprn1.Name = "textvprn1";
            this.textvprn1.Size = new System.Drawing.Size(100, 20);
            this.textvprn1.TabIndex = 6;
            this.textvprn1.Text = "Vprn1";
            // 
            // VPRN
            // 
            this.VPRN.AutoSize = true;
            this.VPRN.Location = new System.Drawing.Point(285, 0);
            this.VPRN.Name = "VPRN";
            this.VPRN.Size = new System.Drawing.Size(37, 13);
            this.VPRN.TabIndex = 7;
            this.VPRN.Text = "VPRN";
            // 
            // VLAN
            // 
            this.VLAN.AutoSize = true;
            this.VLAN.Location = new System.Drawing.Point(146, 105);
            this.VLAN.Name = "VLAN";
            this.VLAN.Size = new System.Drawing.Size(35, 13);
            this.VLAN.TabIndex = 7;
            this.VLAN.Text = "VLAN";
            // 
            // IP
            // 
            this.IP.AutoSize = true;
            this.IP.Location = new System.Drawing.Point(6, 105);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(17, 13);
            this.IP.TabIndex = 6;
            this.IP.Text = "IP";
            // 
            // textvlan3
            // 
            this.textvlan3.Location = new System.Drawing.Point(149, 46);
            this.textvlan3.Name = "textvlan3";
            this.textvlan3.Size = new System.Drawing.Size(68, 20);
            this.textvlan3.TabIndex = 5;
            this.textvlan3.Text = "Vlan2";
            // 
            // textip3
            // 
            this.textip3.Location = new System.Drawing.Point(6, 74);
            this.textip3.Name = "textip3";
            this.textip3.Size = new System.Drawing.Size(123, 20);
            this.textip3.TabIndex = 4;
            this.textip3.Text = "IP/Mask";
            // 
            // textvlan2
            // 
            this.textvlan2.Location = new System.Drawing.Point(149, 74);
            this.textvlan2.Name = "textvlan2";
            this.textvlan2.Size = new System.Drawing.Size(68, 20);
            this.textvlan2.TabIndex = 3;
            this.textvlan2.Text = "Vlan2";
            // 
            // textip2
            // 
            this.textip2.Location = new System.Drawing.Point(6, 48);
            this.textip2.Name = "textip2";
            this.textip2.Size = new System.Drawing.Size(123, 20);
            this.textip2.TabIndex = 2;
            this.textip2.Text = "IP/Mask";
            // 
            // textvlan1
            // 
            this.textvlan1.Location = new System.Drawing.Point(149, 18);
            this.textvlan1.Name = "textvlan1";
            this.textvlan1.Size = new System.Drawing.Size(68, 20);
            this.textvlan1.TabIndex = 1;
            this.textvlan1.Text = "Vlan1";
            // 
            // textip1
            // 
            this.textip1.Location = new System.Drawing.Point(6, 18);
            this.textip1.Name = "textip1";
            this.textip1.Size = new System.Drawing.Size(123, 20);
            this.textip1.TabIndex = 0;
            this.textip1.Text = "IP/Mask";
            // 
            // Int
            // 
            this.Int.AutoSize = true;
            this.Int.Location = new System.Drawing.Point(492, 0);
            this.Int.Name = "Int";
            this.Int.Size = new System.Drawing.Size(54, 13);
            this.Int.TabIndex = 9;
            this.Int.Text = "Interfaces";
            // 
            // textIR
            // 
            this.textIR.Location = new System.Drawing.Point(36, 142);
            this.textIR.Name = "textIR";
            this.textIR.Size = new System.Drawing.Size(124, 20);
            this.textIR.TabIndex = 10;
            this.textIR.Text = "IR+Celda";
            // 
            // textport
            // 
            this.textport.Location = new System.Drawing.Point(3, 11);
            this.textport.Name = "textport";
            this.textport.Size = new System.Drawing.Size(100, 20);
            this.textport.TabIndex = 11;
            this.textport.Text = "x/x/x";
            // 
            // IR
            // 
            this.IR.AutoSize = true;
            this.IR.Location = new System.Drawing.Point(9, 149);
            this.IR.Name = "IR";
            this.IR.Size = new System.Drawing.Size(18, 13);
            this.IR.TabIndex = 12;
            this.IR.Text = "IR";
            // 
            // Puerto
            // 
            this.Puerto.AutoSize = true;
            this.Puerto.Location = new System.Drawing.Point(175, 149);
            this.Puerto.Name = "Puerto";
            this.Puerto.Size = new System.Drawing.Size(38, 13);
            this.Puerto.TabIndex = 13;
            this.Puerto.Text = "Puerto";
            // 
            // checkportexiste
            // 
            this.checkportexiste.AutoSize = true;
            this.checkportexiste.Location = new System.Drawing.Point(105, 14);
            this.checkportexiste.Name = "checkportexiste";
            this.checkportexiste.Size = new System.Drawing.Size(83, 17);
            this.checkportexiste.TabIndex = 14;
            this.checkportexiste.Text = "Configurado";
            this.checkportexiste.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textport);
            this.panel4.Controls.Add(this.checkportexiste);
            this.panel4.Location = new System.Drawing.Point(219, 131);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(192, 41);
            this.panel4.TabIndex = 15;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(562, 178);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(88, 34);
            this.buttonCalc.TabIndex = 16;
            this.buttonCalc.Text = "Calular";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(562, 218);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(88, 34);
            this.buttonReset.TabIndex = 17;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(562, 258);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(88, 38);
            this.buttonGuardar.TabIndex = 18;
            this.buttonGuardar.Text = "Guardar Config";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(3, 178);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(553, 184);
            this.output.TabIndex = 19;
            this.output.Text = "";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "IP del SAR";
            // 
            // textipsar
            // 
            this.textipsar.Location = new System.Drawing.Point(488, 146);
            this.textipsar.Name = "textipsar";
            this.textipsar.Size = new System.Drawing.Size(110, 20);
            this.textipsar.TabIndex = 21;
            this.textipsar.Text = "IP";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textcust1);
            this.groupBox1.Controls.Add(this.checkcust);
            this.groupBox1.Controls.Add(this.textcust2);
            this.groupBox1.Controls.Add(this.textcust3);
            this.groupBox1.Location = new System.Drawing.Point(13, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 109);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textvprn1);
            this.groupBox2.Controls.Add(this.checkVPRN);
            this.groupBox2.Controls.Add(this.textvprn2);
            this.groupBox2.Controls.Add(this.textvprn3);
            this.groupBox2.Location = new System.Drawing.Point(214, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 109);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textvlan1);
            this.groupBox3.Controls.Add(this.VLAN);
            this.groupBox3.Controls.Add(this.textvlan3);
            this.groupBox3.Controls.Add(this.textvlan2);
            this.groupBox3.Controls.Add(this.IP);
            this.groupBox3.Controls.Add(this.textip1);
            this.groupBox3.Controls.Add(this.textip3);
            this.groupBox3.Controls.Add(this.textip2);
            this.groupBox3.Location = new System.Drawing.Point(417, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 121);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // LTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 374);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textipsar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Puerto);
            this.Controls.Add(this.IR);
            this.Controls.Add(this.textIR);
            this.Controls.Add(this.Int);
            this.Controls.Add(this.VPRN);
            this.Controls.Add(this.Customer);
            this.Name = "LTE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LTE";
            this.Load += new System.EventHandler(this.LTE_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textcust1;
        private System.Windows.Forms.TextBox textcust2;
        private System.Windows.Forms.TextBox textcust3;
        private System.Windows.Forms.Label Customer;
        private System.Windows.Forms.CheckBox checkcust;
        private System.Windows.Forms.CheckBox checkVPRN;
        private System.Windows.Forms.TextBox textvprn3;
        private System.Windows.Forms.TextBox textvprn2;
        private System.Windows.Forms.TextBox textvprn1;
        private System.Windows.Forms.Label VPRN;
        private System.Windows.Forms.Label VLAN;
        private System.Windows.Forms.Label IP;
        private System.Windows.Forms.TextBox textvlan3;
        private System.Windows.Forms.TextBox textip3;
        private System.Windows.Forms.TextBox textvlan2;
        private System.Windows.Forms.TextBox textip2;
        private System.Windows.Forms.TextBox textvlan1;
        private System.Windows.Forms.TextBox textip1;
        private System.Windows.Forms.Label Int;
        private System.Windows.Forms.TextBox textIR;
        private System.Windows.Forms.TextBox textport;
        private System.Windows.Forms.Label IR;
        private System.Windows.Forms.Label Puerto;
        private System.Windows.Forms.CheckBox checkportexiste;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox textipsar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}