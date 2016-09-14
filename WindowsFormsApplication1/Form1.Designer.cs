namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.cmboxtipo = new System.Windows.Forms.ComboBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.cmboxpais = new System.Windows.Forms.ComboBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.cmboxzona = new System.Windows.Forms.ComboBox();
            this.cmboxorigen = new System.Windows.Forms.ComboBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txtdestino = new System.Windows.Forms.TextBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.txtCT = new System.Windows.Forms.TextBox();
            this.txtport = new System.Windows.Forms.TextBox();
            this.lbl7 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkvprnexistente = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkport = new System.Windows.Forms.CheckBox();
            this.cmboxzona_dest = new System.Windows.Forms.ComboBox();
            this.cmboxpais_dest = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkRuta = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl14 = new System.Windows.Forms.Label();
            this.lbl15 = new System.Windows.Forms.Label();
            this.txtstatic = new System.Windows.Forms.TextBox();
            this.txtnext = new System.Windows.Forms.TextBox();
            this.txtipbpe = new System.Windows.Forms.TextBox();
            this.lbl17 = new System.Windows.Forms.Label();
            this.lbl12 = new System.Windows.Forms.Label();
            this.lbl16 = new System.Windows.Forms.Label();
            this.txtipcpe = new System.Windows.Forms.TextBox();
            this.txtVLANCPE = new System.Windows.Forms.TextBox();
            this.lbl13 = new System.Windows.Forms.Label();
            this.txtVLANBPE = new System.Windows.Forms.TextBox();
            this.checkBox1Gestión = new System.Windows.Forms.CheckBox();
            this.txtdsc = new System.Windows.Forms.TextBox();
            this.lbl9 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtCT_RPV = new System.Windows.Forms.TextBox();
            this.txtCT_TIP = new System.Windows.Forms.TextBox();
            this.txtCT_LTT = new System.Windows.Forms.TextBox();
            this.checkVLAN = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.check_Inet = new System.Windows.Forms.CheckBox();
            this.check_RPV = new System.Windows.Forms.CheckBox();
            this.check_TIP = new System.Windows.Forms.CheckBox();
            this.check_LTT = new System.Windows.Forms.CheckBox();
            this.numericUpDownpipebase = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkCustomer = new System.Windows.Forms.CheckBox();
            this.textcust = new System.Windows.Forms.TextBox();
            this.checkSDP = new System.Windows.Forms.CheckBox();
            this.textSDPfront = new System.Windows.Forms.TextBox();
            this.textSDPdest = new System.Windows.Forms.TextBox();
            this.labelfront = new System.Windows.Forms.Label();
            this.labeldest = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownpipebase)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmboxtipo
            // 
            this.cmboxtipo.FormattingEnabled = true;
            this.cmboxtipo.Location = new System.Drawing.Point(118, 8);
            this.cmboxtipo.Name = "cmboxtipo";
            this.cmboxtipo.Size = new System.Drawing.Size(98, 21);
            this.cmboxtipo.TabIndex = 0;
            this.cmboxtipo.SelectedIndexChanged += new System.EventHandler(this.cmboxtipo_SelectedIndexChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(3, 12);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(109, 16);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Tipo de servicio";
            // 
            // cmboxpais
            // 
            this.cmboxpais.FormattingEnabled = true;
            this.cmboxpais.Location = new System.Drawing.Point(6, 37);
            this.cmboxpais.Name = "cmboxpais";
            this.cmboxpais.Size = new System.Drawing.Size(121, 24);
            this.cmboxpais.TabIndex = 2;
            this.cmboxpais.SelectedIndexChanged += new System.EventHandler(this.cmboxpais_SelectedIndexChanged);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(6, 21);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(39, 16);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "País";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(130, 18);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(43, 16);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "Zona";
            // 
            // cmboxzona
            // 
            this.cmboxzona.FormattingEnabled = true;
            this.cmboxzona.Location = new System.Drawing.Point(133, 37);
            this.cmboxzona.Name = "cmboxzona";
            this.cmboxzona.Size = new System.Drawing.Size(121, 24);
            this.cmboxzona.TabIndex = 5;
            this.cmboxzona.SelectedIndexChanged += new System.EventHandler(this.cmboxzona_SelectedIndexChanged);
            // 
            // cmboxorigen
            // 
            this.cmboxorigen.FormattingEnabled = true;
            this.cmboxorigen.Location = new System.Drawing.Point(13, 95);
            this.cmboxorigen.Name = "cmboxorigen";
            this.cmboxorigen.Size = new System.Drawing.Size(220, 24);
            this.cmboxorigen.TabIndex = 6;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(18, 72);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(179, 16);
            this.lbl4.TabIndex = 7;
            this.lbl4.Text = "Origen (Equipo Frontera)";
            // 
            // txtdestino
            // 
            this.txtdestino.Location = new System.Drawing.Point(8, 95);
            this.txtdestino.Name = "txtdestino";
            this.txtdestino.Size = new System.Drawing.Size(129, 22);
            this.txtdestino.TabIndex = 8;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(6, 72);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(79, 16);
            this.lbl5.TabIndex = 9;
            this.lbl5.Text = "IP Destino";
            // 
            // txtCT
            // 
            this.txtCT.Location = new System.Drawing.Point(698, 78);
            this.txtCT.Name = "txtCT";
            this.txtCT.Size = new System.Drawing.Size(71, 20);
            this.txtCT.TabIndex = 10;
            // 
            // txtport
            // 
            this.txtport.Location = new System.Drawing.Point(151, 96);
            this.txtport.Name = "txtport";
            this.txtport.Size = new System.Drawing.Size(100, 22);
            this.txtport.TabIndex = 12;
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7.Location = new System.Drawing.Point(148, 72);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(104, 16);
            this.lbl7.TabIndex = 13;
            this.lbl7.Text = "Puerto (X/X/X)";
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(14, 30);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(103, 41);
            this.btn1.TabIndex = 14;
            this.btn1.Text = "Calcular";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            this.btn1.MouseLeave += new System.EventHandler(this.btn1_MouseLeave);
            this.btn1.MouseHover += new System.EventHandler(this.btn1_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkvprnexistente);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.checkBox1Gestión);
            this.groupBox1.Controls.Add(this.txtdsc);
            this.groupBox1.Controls.Add(this.lbl9);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.cmboxtipo);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 306);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PIPE";
            // 
            // checkvprnexistente
            // 
            this.checkvprnexistente.AutoSize = true;
            this.checkvprnexistente.Location = new System.Drawing.Point(149, 170);
            this.checkvprnexistente.Name = "checkvprnexistente";
            this.checkvprnexistente.Size = new System.Drawing.Size(122, 17);
            this.checkvprnexistente.TabIndex = 36;
            this.checkvprnexistente.Text = "VPRN Configurada?";
            this.checkvprnexistente.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkport);
            this.groupBox5.Controls.Add(this.cmboxzona_dest);
            this.groupBox5.Controls.Add(this.cmboxpais_dest);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.lbl7);
            this.groupBox5.Controls.Add(this.txtport);
            this.groupBox5.Controls.Add(this.txtdestino);
            this.groupBox5.Controls.Add(this.lbl5);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(277, 38);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(289, 149);
            this.groupBox5.TabIndex = 37;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Destino";
            // 
            // checkport
            // 
            this.checkport.AutoSize = true;
            this.checkport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkport.Location = new System.Drawing.Point(153, 123);
            this.checkport.Name = "checkport";
            this.checkport.Size = new System.Drawing.Size(122, 19);
            this.checkport.TabIndex = 18;
            this.checkport.Text = "Ya configurado";
            this.checkport.UseVisualStyleBackColor = true;
            // 
            // cmboxzona_dest
            // 
            this.cmboxzona_dest.FormattingEnabled = true;
            this.cmboxzona_dest.Location = new System.Drawing.Point(133, 37);
            this.cmboxzona_dest.Name = "cmboxzona_dest";
            this.cmboxzona_dest.Size = new System.Drawing.Size(121, 24);
            this.cmboxzona_dest.TabIndex = 17;
            this.cmboxzona_dest.SelectedIndexChanged += new System.EventHandler(this.cmboxzona_dest_SelectedIndexChanged);
            // 
            // cmboxpais_dest
            // 
            this.cmboxpais_dest.FormattingEnabled = true;
            this.cmboxpais_dest.Location = new System.Drawing.Point(6, 37);
            this.cmboxpais_dest.Name = "cmboxpais_dest";
            this.cmboxpais_dest.Size = new System.Drawing.Size(121, 24);
            this.cmboxpais_dest.TabIndex = 16;
            this.cmboxpais_dest.SelectedIndexChanged += new System.EventHandler(this.cmboxpais_dest_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Zona";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "País";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmboxpais);
            this.groupBox4.Controls.Add(this.lbl2);
            this.groupBox4.Controls.Add(this.cmboxzona);
            this.groupBox4.Controls.Add(this.lbl3);
            this.groupBox4.Controls.Add(this.cmboxorigen);
            this.groupBox4.Controls.Add(this.lbl4);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(6, 38);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(265, 126);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Frontera";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkRuta);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txtipbpe);
            this.groupBox2.Controls.Add(this.lbl17);
            this.groupBox2.Controls.Add(this.lbl12);
            this.groupBox2.Controls.Add(this.lbl16);
            this.groupBox2.Controls.Add(this.txtipcpe);
            this.groupBox2.Controls.Add(this.txtVLANCPE);
            this.groupBox2.Controls.Add(this.lbl13);
            this.groupBox2.Controls.Add(this.txtVLANBPE);
            this.groupBox2.Location = new System.Drawing.Point(8, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(558, 107);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "VPRN";
            // 
            // checkRuta
            // 
            this.checkRuta.AutoSize = true;
            this.checkRuta.Location = new System.Drawing.Point(331, 9);
            this.checkRuta.Name = "checkRuta";
            this.checkRuta.Size = new System.Drawing.Size(132, 17);
            this.checkRuta.TabIndex = 30;
            this.checkRuta.Text = "Ingrese rutas estáticas";
            this.checkRuta.UseVisualStyleBackColor = true;
            this.checkRuta.CheckedChanged += new System.EventHandler(this.checkRuta_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl14);
            this.groupBox3.Controls.Add(this.lbl15);
            this.groupBox3.Controls.Add(this.txtstatic);
            this.groupBox3.Controls.Add(this.txtnext);
            this.groupBox3.Location = new System.Drawing.Point(252, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 69);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ruta de Gestión";
            // 
            // lbl14
            // 
            this.lbl14.AutoSize = true;
            this.lbl14.Location = new System.Drawing.Point(6, 20);
            this.lbl14.Name = "lbl14";
            this.lbl14.Size = new System.Drawing.Size(82, 13);
            this.lbl14.TabIndex = 26;
            this.lbl14.Text = "Ruta de gestión";
            // 
            // lbl15
            // 
            this.lbl15.AutoSize = true;
            this.lbl15.Location = new System.Drawing.Point(164, 20);
            this.lbl15.Name = "lbl15";
            this.lbl15.Size = new System.Drawing.Size(49, 13);
            this.lbl15.TabIndex = 27;
            this.lbl15.Text = "Nex-Hop";
            // 
            // txtstatic
            // 
            this.txtstatic.Location = new System.Drawing.Point(9, 37);
            this.txtstatic.Name = "txtstatic";
            this.txtstatic.Size = new System.Drawing.Size(142, 20);
            this.txtstatic.TabIndex = 25;
            this.txtstatic.Text = "0.0.0.0/30";
            // 
            // txtnext
            // 
            this.txtnext.Location = new System.Drawing.Point(167, 37);
            this.txtnext.Name = "txtnext";
            this.txtnext.Size = new System.Drawing.Size(100, 20);
            this.txtnext.TabIndex = 28;
            // 
            // txtipbpe
            // 
            this.txtipbpe.Location = new System.Drawing.Point(120, 72);
            this.txtipbpe.Name = "txtipbpe";
            this.txtipbpe.Size = new System.Drawing.Size(126, 20);
            this.txtipbpe.TabIndex = 32;
            this.txtipbpe.Text = "0.0.0.0/27";
            // 
            // lbl17
            // 
            this.lbl17.AutoSize = true;
            this.lbl17.Location = new System.Drawing.Point(119, 56);
            this.lbl17.Name = "lbl17";
            this.lbl17.Size = new System.Drawing.Size(76, 13);
            this.lbl17.TabIndex = 34;
            this.lbl17.Text = "Address/Mask";
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.Location = new System.Drawing.Point(6, 16);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(93, 13);
            this.lbl12.TabIndex = 22;
            this.lbl12.Text = "Management CPE";
            // 
            // lbl16
            // 
            this.lbl16.AutoSize = true;
            this.lbl16.Location = new System.Drawing.Point(6, 59);
            this.lbl16.Name = "lbl16";
            this.lbl16.Size = new System.Drawing.Size(76, 13);
            this.lbl16.TabIndex = 33;
            this.lbl16.Text = "Address/Mask";
            // 
            // txtipcpe
            // 
            this.txtipcpe.Location = new System.Drawing.Point(6, 72);
            this.txtipcpe.Name = "txtipcpe";
            this.txtipcpe.Size = new System.Drawing.Size(108, 20);
            this.txtipcpe.TabIndex = 31;
            this.txtipcpe.Text = "0.0.0.0/27";
            // 
            // txtVLANCPE
            // 
            this.txtVLANCPE.Location = new System.Drawing.Point(9, 36);
            this.txtVLANCPE.Name = "txtVLANCPE";
            this.txtVLANCPE.Size = new System.Drawing.Size(55, 20);
            this.txtVLANCPE.TabIndex = 21;
            // 
            // lbl13
            // 
            this.lbl13.AutoSize = true;
            this.lbl13.Location = new System.Drawing.Point(105, 16);
            this.lbl13.Name = "lbl13";
            this.lbl13.Size = new System.Drawing.Size(93, 13);
            this.lbl13.TabIndex = 23;
            this.lbl13.Text = "Management BPE";
            // 
            // txtVLANBPE
            // 
            this.txtVLANBPE.Location = new System.Drawing.Point(120, 36);
            this.txtVLANBPE.Name = "txtVLANBPE";
            this.txtVLANBPE.Size = new System.Drawing.Size(58, 20);
            this.txtVLANBPE.TabIndex = 24;
            // 
            // checkBox1Gestión
            // 
            this.checkBox1Gestión.AutoSize = true;
            this.checkBox1Gestión.Location = new System.Drawing.Point(8, 170);
            this.checkBox1Gestión.Name = "checkBox1Gestión";
            this.checkBox1Gestión.Size = new System.Drawing.Size(145, 17);
            this.checkBox1Gestión.TabIndex = 20;
            this.checkBox1Gestión.Text = "Datos de gestión (VPRN)";
            this.checkBox1Gestión.UseVisualStyleBackColor = true;
            this.checkBox1Gestión.CheckedChanged += new System.EventHandler(this.checkBox1Gestión_CheckedChanged);
            // 
            // txtdsc
            // 
            this.txtdsc.Location = new System.Drawing.Point(370, 8);
            this.txtdsc.Name = "txtdsc";
            this.txtdsc.Size = new System.Drawing.Size(196, 20);
            this.txtdsc.TabIndex = 15;
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl9.Location = new System.Drawing.Point(273, 12);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(91, 16);
            this.lbl9.TabIndex = 14;
            this.lbl9.Text = "Descripción";
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl10.Location = new System.Drawing.Point(593, 9);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(44, 16);
            this.lbl10.TabIndex = 17;
            this.lbl10.Text = "Base";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(4, 315);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(566, 210);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(14, 77);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(103, 41);
            this.btn2.TabIndex = 18;
            this.btn2.Text = "Guardar";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            this.btn2.MouseLeave += new System.EventHandler(this.btn2_MouseLeave);
            this.btn2.MouseHover += new System.EventHandler(this.btn2_MouseHover);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtCT_RPV
            // 
            this.txtCT_RPV.Location = new System.Drawing.Point(698, 104);
            this.txtCT_RPV.Name = "txtCT_RPV";
            this.txtCT_RPV.Size = new System.Drawing.Size(71, 20);
            this.txtCT_RPV.TabIndex = 21;
            // 
            // txtCT_TIP
            // 
            this.txtCT_TIP.Location = new System.Drawing.Point(698, 130);
            this.txtCT_TIP.Name = "txtCT_TIP";
            this.txtCT_TIP.Size = new System.Drawing.Size(71, 20);
            this.txtCT_TIP.TabIndex = 22;
            // 
            // txtCT_LTT
            // 
            this.txtCT_LTT.Location = new System.Drawing.Point(698, 156);
            this.txtCT_LTT.Name = "txtCT_LTT";
            this.txtCT_LTT.Size = new System.Drawing.Size(71, 20);
            this.txtCT_LTT.TabIndex = 23;
            // 
            // checkVLAN
            // 
            this.checkVLAN.AutoSize = true;
            this.checkVLAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkVLAN.Location = new System.Drawing.Point(595, 55);
            this.checkVLAN.Name = "checkVLAN";
            this.checkVLAN.Size = new System.Drawing.Size(76, 20);
            this.checkVLAN.TabIndex = 27;
            this.checkVLAN.Text = "VLANS";
            this.checkVLAN.UseVisualStyleBackColor = true;
            this.checkVLAN.CheckedChanged += new System.EventHandler(this.checkVLAN_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(635, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 26);
            this.label3.TabIndex = 28;
            this.label3.Text = "Nros consecutivos, \r\ncomenzando  por 00 hasta el 99";
            // 
            // check_Inet
            // 
            this.check_Inet.AutoSize = true;
            this.check_Inet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_Inet.Location = new System.Drawing.Point(595, 78);
            this.check_Inet.Name = "check_Inet";
            this.check_Inet.Size = new System.Drawing.Size(91, 20);
            this.check_Inet.TabIndex = 29;
            this.check_Inet.Text = "Vlan_Inet";
            this.check_Inet.UseVisualStyleBackColor = true;
            this.check_Inet.CheckedChanged += new System.EventHandler(this.check_Inet_CheckedChanged);
            // 
            // check_RPV
            // 
            this.check_RPV.AutoSize = true;
            this.check_RPV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_RPV.Location = new System.Drawing.Point(595, 104);
            this.check_RPV.Name = "check_RPV";
            this.check_RPV.Size = new System.Drawing.Size(97, 20);
            this.check_RPV.TabIndex = 30;
            this.check_RPV.Text = "Vlan_RPV";
            this.check_RPV.UseVisualStyleBackColor = true;
            this.check_RPV.CheckedChanged += new System.EventHandler(this.check_RPV_CheckedChanged);
            // 
            // check_TIP
            // 
            this.check_TIP.AutoSize = true;
            this.check_TIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_TIP.Location = new System.Drawing.Point(595, 130);
            this.check_TIP.Name = "check_TIP";
            this.check_TIP.Size = new System.Drawing.Size(90, 20);
            this.check_TIP.TabIndex = 31;
            this.check_TIP.Text = "Vlan_TIP";
            this.check_TIP.UseVisualStyleBackColor = true;
            this.check_TIP.CheckedChanged += new System.EventHandler(this.check_TIP_CheckedChanged);
            // 
            // check_LTT
            // 
            this.check_LTT.AutoSize = true;
            this.check_LTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_LTT.Location = new System.Drawing.Point(595, 156);
            this.check_LTT.Name = "check_LTT";
            this.check_LTT.Size = new System.Drawing.Size(94, 20);
            this.check_LTT.TabIndex = 32;
            this.check_LTT.Text = "Vlan_LTT";
            this.check_LTT.UseVisualStyleBackColor = true;
            this.check_LTT.CheckedChanged += new System.EventHandler(this.check_LTT_CheckedChanged);
            // 
            // numericUpDownpipebase
            // 
            this.numericUpDownpipebase.Location = new System.Drawing.Point(595, 28);
            this.numericUpDownpipebase.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownpipebase.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownpipebase.Name = "numericUpDownpipebase";
            this.numericUpDownpipebase.Size = new System.Drawing.Size(37, 20);
            this.numericUpDownpipebase.TabIndex = 33;
            this.numericUpDownpipebase.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(14, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 41);
            this.button1.TabIndex = 34;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btn1);
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.btn2);
            this.groupBox6.Location = new System.Drawing.Point(581, 350);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(137, 175);
            this.groupBox6.TabIndex = 35;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Acciones";
            // 
            // checkCustomer
            // 
            this.checkCustomer.AutoSize = true;
            this.checkCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCustomer.Location = new System.Drawing.Point(613, 180);
            this.checkCustomer.Name = "checkCustomer";
            this.checkCustomer.Size = new System.Drawing.Size(91, 64);
            this.checkCustomer.TabIndex = 36;
            this.checkCustomer.Text = "\r\nService\r\nCustomer \r\n\r\n";
            this.checkCustomer.UseVisualStyleBackColor = true;
            // 
            // textcust
            // 
            this.textcust.Location = new System.Drawing.Point(710, 202);
            this.textcust.Name = "textcust";
            this.textcust.Size = new System.Drawing.Size(48, 20);
            this.textcust.TabIndex = 37;
            // 
            // checkSDP
            // 
            this.checkSDP.AutoSize = true;
            this.checkSDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSDP.Location = new System.Drawing.Point(613, 234);
            this.checkSDP.Name = "checkSDP";
            this.checkSDP.Size = new System.Drawing.Size(107, 17);
            this.checkSDP.TabIndex = 38;
            this.checkSDP.Text = "SDP Existente";
            this.checkSDP.UseVisualStyleBackColor = true;
            // 
            // textSDPfront
            // 
            this.textSDPfront.Location = new System.Drawing.Point(583, 288);
            this.textSDPfront.Name = "textSDPfront";
            this.textSDPfront.Size = new System.Drawing.Size(88, 20);
            this.textSDPfront.TabIndex = 39;
            // 
            // textSDPdest
            // 
            this.textSDPdest.Location = new System.Drawing.Point(692, 289);
            this.textSDPdest.Name = "textSDPdest";
            this.textSDPdest.Size = new System.Drawing.Size(80, 20);
            this.textSDPdest.TabIndex = 40;
            // 
            // labelfront
            // 
            this.labelfront.AutoSize = true;
            this.labelfront.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfront.Location = new System.Drawing.Point(582, 264);
            this.labelfront.Name = "labelfront";
            this.labelfront.Size = new System.Drawing.Size(83, 13);
            this.labelfront.TabIndex = 41;
            this.labelfront.Text = "SDP Frontera";
            // 
            // labeldest
            // 
            this.labeldest.AutoSize = true;
            this.labeldest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldest.Location = new System.Drawing.Point(689, 264);
            this.labeldest.Name = "labeldest";
            this.labeldest.Size = new System.Drawing.Size(79, 13);
            this.labeldest.TabIndex = 42;
            this.labeldest.Text = "SDP Destino";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(806, 537);
            this.Controls.Add(this.labeldest);
            this.Controls.Add(this.labelfront);
            this.Controls.Add(this.textSDPdest);
            this.Controls.Add(this.textSDPfront);
            this.Controls.Add(this.checkSDP);
            this.Controls.Add(this.textcust);
            this.Controls.Add(this.checkCustomer);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.numericUpDownpipebase);
            this.Controls.Add(this.check_LTT);
            this.Controls.Add(this.check_TIP);
            this.Controls.Add(this.check_RPV);
            this.Controls.Add(this.check_Inet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkVLAN);
            this.Controls.Add(this.txtCT_LTT);
            this.Controls.Add(this.txtCT_TIP);
            this.Controls.Add(this.txtCT_RPV);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCT);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de EPIPE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownpipebase)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmboxtipo;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ComboBox cmboxpais;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.ComboBox cmboxzona;
        private System.Windows.Forms.ComboBox cmboxorigen;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txtdestino;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.TextBox txtCT;
        private System.Windows.Forms.TextBox txtport;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtdsc;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.CheckBox checkBox1Gestión;
        private System.Windows.Forms.TextBox txtnext;
        private System.Windows.Forms.Label lbl15;
        private System.Windows.Forms.Label lbl14;
        private System.Windows.Forms.TextBox txtstatic;
        private System.Windows.Forms.TextBox txtVLANBPE;
        private System.Windows.Forms.Label lbl13;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.TextBox txtVLANCPE;
        private System.Windows.Forms.CheckBox checkRuta;
        private System.Windows.Forms.Label lbl17;
        private System.Windows.Forms.Label lbl16;
        private System.Windows.Forms.TextBox txtipbpe;
        private System.Windows.Forms.TextBox txtipcpe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cmboxzona_dest;
        private System.Windows.Forms.ComboBox cmboxpais_dest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtCT_LTT;
        private System.Windows.Forms.TextBox txtCT_TIP;
        private System.Windows.Forms.TextBox txtCT_RPV;
        private System.Windows.Forms.CheckBox checkVLAN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox check_LTT;
        private System.Windows.Forms.CheckBox check_TIP;
        private System.Windows.Forms.CheckBox check_RPV;
        private System.Windows.Forms.CheckBox check_Inet;
        private System.Windows.Forms.NumericUpDown numericUpDownpipebase;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkvprnexistente;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox checkport;
        private System.Windows.Forms.TextBox textcust;
        private System.Windows.Forms.CheckBox checkCustomer;
        private System.Windows.Forms.Label labeldest;
        private System.Windows.Forms.Label labelfront;
        private System.Windows.Forms.TextBox textSDPdest;
        private System.Windows.Forms.TextBox textSDPfront;
        private System.Windows.Forms.CheckBox checkSDP;
    }
}

