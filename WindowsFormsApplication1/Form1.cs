using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {    
            //defino tipo de PIPE
            cmboxtipo.Items.Add("1-EPIPE");
            cmboxtipo.Items.Add("2-CPIPE");
            cmboxtipo.Items.Add("3-APIPE");
            cmboxtipo.Items.Add("4-Small Cell");
            cmboxtipo.Items.Add("5-CAC");
            cmboxtipo.Items.Add("6-LTE");
            //defino País Origen
            cmboxpais.Items.Add("1-Argentina");
            cmboxpais.Items.Add("2-Uruguay");
            cmboxpais.Items.Add("3-Paraguay");
            //defino País Destino
            cmboxpais_dest.Items.Add("1-Argentina");
            cmboxpais_dest.Items.Add("2-Uruguay");
            cmboxpais_dest.Items.Add("3-Paraguay");
          
            cmboxpais.Visible = false;
            lbl2.Visible = false;
            
            cmboxzona.Visible = false;
            lbl3.Visible = false;

            cmboxpais_dest.Visible = false;
            lbl2.Visible = false;

            cmboxzona_dest.Visible = false;
            lbl3.Visible = false;

            cmboxorigen.Visible = false;
            lbl4.Visible = false;

            txtdestino.Visible = false;
            lbl5.Visible = false;
            
            txtport.Visible = false;
            lbl7.Visible = false;

            richTextBox1.Visible = false;
            
            txtdsc.Visible = false;
            lbl9.Visible = false;

            numericUpDownpipebase.Visible = false;
            lbl10.Visible = false;
            label3.Visible = false;
         
            txtVLANCPE.Visible = false;
            lbl12.Visible = false;

            txtVLANBPE.Visible = false;
            lbl13.Visible = false;

            txtstatic.Visible = false;
            lbl14.Visible = false;

            txtnext.Visible = false;
            lbl15.Visible = false;

            txtipcpe.Visible = false;
            lbl16.Visible = false;

            txtipbpe.Visible = false;
            lbl17.Visible = false;

            checkRuta.Visible = false;
            checkvprnexistente.Visible = false;

            btn2.Visible = false;

            groupBox2.Visible = false;

            txtCT.Visible = false;
            txtCT_RPV.Visible = false;            
            txtCT_TIP.Visible = false;            
            txtCT_LTT.Visible = false;

            check_Inet.Visible = false;
            check_RPV.Visible = false;
            check_TIP.Visible = false;
            check_LTT.Visible = false;

            button1.Visible = false;
            btn1.BackColor = Color.Azure;
            
        }
        private void cmboxtipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboxtipo.SelectedItem == "4-Small Cell") // Llamo al nuevo formulario
            {
                txtdsc.Enabled = false;
                groupBox4.Enabled = false;
                groupBox5.Enabled = false;
                SmallCell nuevo = new SmallCell();               
                nuevo.ShowDialog();
            }
            else
            {
                groupBox4.Enabled = true;
                groupBox5.Enabled = true;
                txtdsc.Enabled = true;
            }

            if (cmboxtipo.SelectedItem == "5-CAC") // Llamo al nuevo formulario
            {
                txtdsc.Enabled = false;
                groupBox4.Enabled = false;
                groupBox5.Enabled = false;
                CAC nuevo = new CAC();
                nuevo.ShowDialog();
            }
            else
            {
                groupBox4.Enabled = true;
                groupBox5.Enabled = true;
                txtdsc.Enabled = true;
            }

            if (cmboxtipo.SelectedItem == "6-LTE") // Llamo al nuevo formulario
            {
                txtdsc.Enabled = false;
                groupBox4.Enabled = false;
                groupBox5.Enabled = false;
                LTE nuevo = new LTE();
                nuevo.ShowDialog();
            }
            else
            {
                groupBox4.Enabled = true;
                groupBox5.Enabled = true;
                txtdsc.Enabled = true;
            }

            cmboxpais.Visible = true;
            lbl2.Visible = true;

            cmboxzona.Visible = true;
            lbl3.Visible = true;
            ///
            /// Sin espacios
            /// 
            txtdsc.Visible = true; 
            lbl9.Visible = true;
            
            cmboxpais_dest.Visible = true;
            lbl2.Visible = true;

            cmboxzona_dest.Visible = true;
            lbl3.Visible = true;
        }
        private void cmboxpais_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmboxpais.SelectedIndex)
            {                
                case 0:
                    {
                        cmboxzona.Items.Clear();
                        cmboxzona.Items.Add("1-Amba");
                        cmboxzona.Items.Add("2-Norte");
                        cmboxzona.Items.Add("3-Sur");
                        cmboxzona.Items.Add("4-Oeste");
                        cmboxorigen.Items.Clear();
                        cmboxorigen.Items.Add("ME298_1/3/7_10.2.21.199");
                        cmboxorigen.Items.Add("SF898_1/9/7_10.2.21.198");
                        cmboxorigen.Items.Add("CO895_1/10/7_10.2.21.186");
                        cmboxorigen.Items.Add("RPV-OLS70-C2470_2/1/15_10.2.20.209");
                        cmboxorigen.Items.Add("Inet-OLS70-C2470_2/2/15_10.2.20.209");
                        cmboxorigen.Items.Add("Inet-CF296_2/1/15_10.2.20.210");
                        cmboxorigen.Items.Add("RPV-CF296_1/2/15_10.2.20.210");
                        cmboxorigen.Items.Add("C1900_lag-3_10.2.20.10");                                                
                        break;
                    }
                case 1:
                    {
                        cmboxzona.Items.Clear();
                        cmboxzona.Items.Add("1-Montevideo");
                        cmboxzona.Items.Add("2-Canalones");
                        cmboxzona.Items.Add("3-Maldonado");
                        break;
                    }
                case 2:
                    {
                        cmboxzona.Items.Clear();
                        cmboxzona.Items.Add("1-Asunción");
                        cmboxzona.Items.Add("2-Ciudad del Este");
                        cmboxzona.Items.Add("3-Encarnación");
                        cmboxorigen.Items.Clear();
                        cmboxorigen.Items.Add("AS023-DUAL-SR7_2/2/2_10.2.23.130");
                        cmboxorigen.Items.Add("AS023-KRC70-SR7_3/1/6_10.2.23.129");
                        cmboxorigen.Items.Add("AS023-KRC70-SR7_1/1/15_10.2.23.129");
                        cmboxorigen.Items.Add("AP030-MSC70-SR7_lag-5_10.2.23.225");
                        cmboxorigen.Items.Add("AP030-MSC70-SR7-DUAL_lag-5_10.2.72.125");
                        break;
                    }
            }
        }
        private void cmboxpais_dest_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (cmboxpais_dest.SelectedIndex)
            {
                case 0:
                    {
                        cmboxzona_dest.Items.Clear();
                        cmboxzona_dest.Items.Add("1-Amba");
                        cmboxzona_dest.Items.Add("2-Norte");
                        cmboxzona_dest.Items.Add("3-Sur");
                        cmboxzona_dest.Items.Add("4-Oeste");
                        break;
                    }
                case 1:
                    {
                        cmboxzona_dest.Items.Clear();
                        cmboxzona_dest.Items.Add("1-Montevideo");
                        cmboxzona_dest.Items.Add("2-Canalones");
                        cmboxzona_dest.Items.Add("3-Maldonado");
                        break;
                    }
                case 2:
                    {
                        cmboxzona_dest.Items.Clear();
                        cmboxzona_dest.Items.Add("1-Asunción");
                        cmboxzona_dest.Items.Add("2-Ciudad del Este");
                        cmboxzona_dest.Items.Add("3-Encarnación");
                        break;
                    }
            }
        }
        private void cmboxzona_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmboxorigen.Visible = true;
            lbl4.Visible = true;

            numericUpDownpipebase.Visible = true;
            lbl10.Visible = true;
            label3.Visible = false;
                     
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear(); // limpia los errores cada vez que ocurre el evento btn1_Click
            bool ERROR = false;
            //VALIDACIONES!!!!!!!!!!!!!
            if (IsAllDigits(txtCT.Text) == false) // valido VLAN_Inet
            {
                errorProvider1.SetError(txtCT, "Debe ser valor númerico");
                ERROR = true;
            }
            if (IsAllDigits(txtCT_RPV.Text) == false) // valido VLAN_RPV
            {
                errorProvider1.SetError(txtCT_RPV, "Debe ser valor númerico");
                ERROR = true;
            }
            if (IsAllDigits(txtCT_TIP.Text) == false) // valido VLAN_TIP
            {
                errorProvider1.SetError(txtCT_TIP, "Debe ser valor númerico");
                ERROR = true;
            }
            if (IsAllDigits(txtCT_LTT.Text) == false) // valido VLAN_LTT
            {
                errorProvider1.SetError(txtCT_LTT, "Debe ser valor númerico");
                ERROR = true;
            }
            if (CheckIPValid(txtdestino.Text) == false) // valido destino
            {
                errorProvider1.SetError(txtdestino, "Debe ser una IP válida");
                ERROR = true;
            }
            if (cmboxorigen.SelectedItem == null) // valido Origen
            {
                errorProvider1.SetError(cmboxorigen, "Campo obligatorio");
                ERROR = true;
            }
            if (txtdsc.Text == "" ||IsAllLettersOrDigits(txtdsc.Text) == false) // valido descripción
            {
                errorProvider1.SetError(txtdsc, "Campo obligatorio y sin espacios");
                ERROR = true;
            }
            
            if (cmboxtipo.SelectedItem == null) // valido tipo de EPIPE
            {
                errorProvider1.SetError(cmboxtipo, "Campo obligatorio");
                ERROR = true;
            }
            if (cmboxpais.SelectedItem == null) // valido País
            {
                errorProvider1.SetError(cmboxpais, "Campo obligatorio");
                ERROR = true;
            }
            if (cmboxpais_dest.SelectedItem == null) // valido País Destino
            {
                errorProvider1.SetError(cmboxpais_dest, "Campo obligatorio");
                ERROR = true;
            }
            if (cmboxzona.SelectedItem == null) // valido Zona
            {
                errorProvider1.SetError(cmboxzona, "Campo obligatorio");
                ERROR = true;
            }
            if (cmboxzona_dest.SelectedItem == null) // valido Zona Destino
            {
                errorProvider1.SetError(cmboxzona_dest, "Campo obligatorio");
                ERROR = true;
            }
            if (txtport.Text == "") // valido puerto
            {
                if (checkport.Checked == true)
                { 
                }
                else
                {
                 errorProvider1.SetError(txtport, "Campo obligatorio");
                 ERROR = true;
                }
            }
            if (IsAllDigits(textcust.Text) == false) // valido customer
            {
                errorProvider1.SetError(textcust, "Debe ser valor númerico");
                ERROR = true;
            }
            if (IsAllDigits(textSDPfront.Text) == false) // valido SDP frontera
            {
                errorProvider1.SetError(textSDPfront, "Debe ser valor númerico");
                ERROR = true;
            }
            if (IsAllDigits(textSDPdest.Text) == false) // valido SDP destino
            {
                errorProvider1.SetError(textSDPdest, "Debe ser valor númerico");
                ERROR = true;
            }
            if (ERROR == false)            
            {
                button1.Visible = true;
                btn1.Visible = false;
                btn2.Visible = true;

                //Cargo variables
                string PIPE = cmboxtipo.SelectedItem.ToString().Substring(0, 1);
                string Pais = cmboxpais.SelectedItem.ToString().Substring(0, 1);
                string Zona = cmboxzona.SelectedItem.ToString().Substring(0, 1);
                string Pais_dest = cmboxpais_dest.SelectedItem.ToString().Substring(0, 1);
                string Zona_dest = cmboxzona_dest.SelectedItem.ToString().Substring(0, 1);

                string IPori = cmboxorigen.SelectedItem.ToString();
                string[] separarIP = cmboxorigen.SelectedItem.ToString().Split('_'); // me guardo la IP de origen
                string[] octeto = separarIP[2].Split('.'); // separo la IPorigen(Frontera) en octetos
                string puertori = separarIP[1]; // me guardo el puerto origen

                string IPdestino = txtdestino.Text; // variable   
                string octetodest = IPdestino.Split('.')[3]; // guardo el último octeto de IPdestino(Remoto) 
                string octetodest2 = octetodest;
                // válido unicamente para el calculo del SDP
                if (octetodest.Length == 1) // le agrego un 0 en caso de que el ultimo octeto sea un solo dígito
                    octetodest = "0" + octetodest;

                if (octetodest.Length == 3) // quito un dígito en caso de que el ultimo octeto sean tres dígitos
                    octetodest = ""+octetodest[1] + octetodest[2];
                //
                string ultiocte = octeto[3];

                string subZ = IPori.Substring(IPori.Length - 2, 2); //sub-variable guardo la el ultimo octeto de la IP Origen
                string subX = separarIP[2]; // sub-variable 
                string cust = textcust.Text;
                string SDPexFront = textSDPfront.Text;
                string SDPexdest = textSDPdest.Text;

                
                //ARMO LOS SDP

                string SDPori = (Zona + octetodest + Zona_dest); // variable SDP en destino
                string SDPdest = (Zona + subZ + Zona_dest); //variable SDP en frontera

                string port = txtport.Text;
                string desc = txtdsc.Text;                
                int PIPEBASE = Convert.ToInt16(numericUpDownpipebase.Value) - 1;
                string PIPEBASE_INET = "";
                string PIPEBASE_RPV = "";
                string PIPEBASE_TIP = "";
                string PIPEBASE_LTT = "";
                
             
                
                string SAP = txtport.Text + ":" + txtCT.Text; //variable SAP_Inet (puerto + VLAN)
                string SAPORI = puertori + ":" + txtCT.Text; //variable SAP_Inet en equipo frontera (puerto + VLAN)
                string SAP_RPV = txtport.Text + ":" + txtCT_RPV.Text; //variable SAP_RPV (puerto + VLAN)
                string SAPORI_RPV = puertori + ":" + txtCT_RPV.Text; //variable SAP_RPV en equipo frontera (puerto + VLAN)
                string SAP_TIP = txtport.Text + ":" + txtCT_TIP.Text; //variable SAP_TIP (puerto + VLAN)
                string SAPORI_TIP = puertori + ":" + txtCT_TIP.Text; //variable SAP_TIP en equipo frontera (puerto + VLAN)
                string SAP_LTT = txtport.Text + ":" + txtCT_LTT.Text; //variable SAP_LTT (puerto + VLAN)
                string SAPORI_LTT = puertori + ":" + txtCT_LTT.Text; //variable SAP_LTT en equipo frontera (puerto + VLAN)                
                                              
                string IPCPE = txtipcpe.Text;
                string VLANCPE = txtVLANCPE.Text;
                string VLANBPE = txtVLANBPE.Text;
                string IPBPE = txtipbpe.Text;
                string prefijo_de_gestion = txtstatic.Text;
                string Next_Hop = txtnext.Text;
                string EPIPE_Inet = "";
                string EPIPE_RPV = "";
                string EPIPE_TIP = "";
                string EPIPE_LTT = "";
                
                // CONFIGURACION LADO FRONTERA
                ////////////////////////////////
                // válido para calcular el EPIPE 
                if (octetodest2.Length == 1)
                    octetodest2 = "00" + octetodest2;
                if (octetodest2.Length == 2)
                    octetodest2 = "0" + octetodest2;
                // configuro el EPIPE_inet
                if (check_Inet.Checked == true)
                {                   
                    PIPEBASE=PIPEBASE+1;
                    if (PIPEBASE < 10)
                    {
                        EPIPE_Inet = Pais + "0" + Zona + PIPE + octetodest2 + "0" + PIPEBASE; //variable EPIPE_Inet   
                    }
                    else
                    {
                        EPIPE_Inet = Pais + "0" + Zona + PIPE + octetodest2 + PIPEBASE; //variable EPIPE_Inet   
                    }
                    if (Pais == "3")
                    {
                        PIPEBASE_INET = PIPEBASE_INET + "-----CONFIGURO EL EPIPE_Inet----" + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "-----------------------------" + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "AVERIGUAR EL CUSTOMER CREADO EN EL EQUIPO Y REEMPLAZAR POR XX " + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "Con el comando: show service customer, averiguamos el Customer creado" + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "configure service epipe " + EPIPE_Inet + " customer XX create" + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "description " + desc + "_Inet" + "\r\n";                        
                        PIPEBASE_INET = PIPEBASE_INET + "sap " + SAPORI + " create" + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "exit" + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "spoke-sdp " + SDPori + ":" + EPIPE_Inet + " create" + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "exit" + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "no shutdown" + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "exit all" + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "\r\n";
                    }
                    else
                    {
                        PIPEBASE_INET = PIPEBASE_INET + "-----CONFIGURO EL EPIPE_Inet----" + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "-----------------------------" + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "AVERIGUAR EL CUSTOMER CREADO EN EL EQUIPO Y REEMPLAZAR POR XX " + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "Con el comando: show service customer, averiguamos el Customer creado" + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "configure service epipe " + EPIPE_Inet + " customer XX create" + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "description " + desc + "_Inet" + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "service-mtu 1574" + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "sap " + SAPORI + " create" + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "ingress qos 201" + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "egress qos 201" + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "exit" + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "spoke-sdp " + SDPori + ":" + EPIPE_Inet + " create" + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "exit" + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "no shutdown" + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "exit all" + "\r\n";
                        PIPEBASE_INET = PIPEBASE_INET + "\r\n";
                    }
                }
                // configuro el EPIPE_RPV
                if (check_RPV.Checked == true)
                {
                    PIPEBASE=PIPEBASE+1;
                    if (PIPEBASE < 10)
                    {
                        EPIPE_RPV = Pais + "0" + Zona + PIPE + octetodest2 + "0" + PIPEBASE; //variable EPIPE_RPV
                    }
                    else
                    {
                        EPIPE_RPV = Pais + "0" + Zona + PIPE + octetodest2 + PIPEBASE; //variable EPIPE_RPV
                    }
                    if (Pais == "3")
                    {
                    PIPEBASE_RPV = PIPEBASE_RPV + "-----CONFIGURO EL EPIPE_RPV----" + "\r\n";
                        PIPEBASE_RPV = PIPEBASE_RPV + "-----------------------------" + "\r\n";
                        PIPEBASE_RPV = PIPEBASE_RPV + "\r\n";                       
                        PIPEBASE_RPV = PIPEBASE_RPV + "\r\n";
                        PIPEBASE_RPV = PIPEBASE_RPV + "configure service epipe " + EPIPE_RPV + "customer " + cust+ " create" + "\r\n";
                        PIPEBASE_RPV = PIPEBASE_RPV + "description " + desc + "_RPV" + "\r\n";                        
                        PIPEBASE_RPV = PIPEBASE_RPV + "sap " + SAPORI_RPV + " create" + "\r\n";
                        PIPEBASE_RPV = PIPEBASE_RPV + "\r\n";
                        PIPEBASE_RPV = PIPEBASE_RPV + "\r\n";                       
                        PIPEBASE_RPV = PIPEBASE_RPV + "exit" + "\r\n";
                        PIPEBASE_RPV = PIPEBASE_RPV + "spoke-sdp " + SDPori + ":" + EPIPE_RPV + " create" + "\r\n";
                        PIPEBASE_RPV = PIPEBASE_RPV + "\r\n";
                        PIPEBASE_RPV = PIPEBASE_RPV + "\r\n";
                        PIPEBASE_RPV = PIPEBASE_RPV + "exit" + "\r\n";
                        PIPEBASE_RPV = PIPEBASE_RPV + "no shutdown" + "\r\n";
                        PIPEBASE_RPV = PIPEBASE_RPV + "exit all" + "\r\n";
                        PIPEBASE_RPV = PIPEBASE_RPV + "\r\n";
                    }
                    else
                        {
                        PIPEBASE_RPV = PIPEBASE_RPV + "-----CONFIGURO EL EPIPE_RPV----" + "\r\n";
                        PIPEBASE_RPV = PIPEBASE_RPV + "-----------------------------" + "\r\n";
                        PIPEBASE_RPV = PIPEBASE_RPV + "\r\n";                        
                        PIPEBASE_RPV = PIPEBASE_RPV + "\r\n";
                        PIPEBASE_RPV = PIPEBASE_RPV + "configure service epipe " + EPIPE_RPV + "customer " + cust + " create" + "\r\n";
                        PIPEBASE_RPV = PIPEBASE_RPV + "description " + desc + "_RPV" + "\r\n";
                        PIPEBASE_RPV = PIPEBASE_RPV + "service-mtu 1574" + "\r\n";
                        PIPEBASE_RPV = PIPEBASE_RPV + "sap " + SAPORI_RPV + " create" + "\r\n";
                        PIPEBASE_RPV = PIPEBASE_RPV + "\r\n";
                        PIPEBASE_RPV = PIPEBASE_RPV + "\r\n";
                        PIPEBASE_RPV = PIPEBASE_RPV + "ingress qos 300" + "\r\n";
                        PIPEBASE_RPV = PIPEBASE_RPV + "egress qos 300" + "\r\n";
                        PIPEBASE_RPV = PIPEBASE_RPV + "exit" + "\r\n";
                        PIPEBASE_RPV = PIPEBASE_RPV + "spoke-sdp " + SDPori + ":" + EPIPE_RPV + " create" + "\r\n";
                        PIPEBASE_RPV = PIPEBASE_RPV + "\r\n";
                        PIPEBASE_RPV = PIPEBASE_RPV + "\r\n";
                        PIPEBASE_RPV = PIPEBASE_RPV + "exit" + "\r\n";
                        PIPEBASE_RPV = PIPEBASE_RPV + "no shutdown" + "\r\n";
                        PIPEBASE_RPV = PIPEBASE_RPV + "exit all" + "\r\n";
                        PIPEBASE_RPV = PIPEBASE_RPV + "\r\n";                    
                        }
                }
                // configuro el EPIPE_TIP
                if (check_TIP.Checked == true)
                {
                    PIPEBASE=PIPEBASE+1;
                    if (PIPEBASE < 10)
                    {
                        EPIPE_TIP = Pais + "0" + Zona + PIPE + octetodest2 + "0" + PIPEBASE; //variable EPIPE_TIP
                    }
                    else
                    {
                        EPIPE_TIP = Pais + "0" + Zona + PIPE + octetodest2 + PIPEBASE; //variable EPIPE_TIP
                    }                   
                    PIPEBASE_TIP = PIPEBASE_TIP + "-----CONFIGURO VPLS_TIP----" + "\r\n";
                    PIPEBASE_TIP = PIPEBASE_TIP + "-----------------------------" + "\r\n";
                    PIPEBASE_TIP = PIPEBASE_TIP + "\r\n";
                    PIPEBASE_TIP = PIPEBASE_TIP + "\r\n";
                    PIPEBASE_TIP = PIPEBASE_TIP + "configure service vpls 2012" + "\r\n";
                    PIPEBASE_TIP = PIPEBASE_TIP + "\r\n";
                    PIPEBASE_TIP = PIPEBASE_TIP + "\r\n";
                    PIPEBASE_TIP = PIPEBASE_TIP + "spoke-sdp " + SDPori + ":2012 create" + "\r\n";
                    PIPEBASE_TIP = PIPEBASE_TIP + "\r\n";
                    PIPEBASE_TIP = PIPEBASE_TIP + "\r\n";
                    PIPEBASE_TIP = PIPEBASE_TIP + "exit all" + "\r\n";
                    PIPEBASE_TIP = PIPEBASE_TIP + "\r\n";
                }
                // configuro el EPIPE_LTT
                if (check_LTT.Checked == true)
                {
                    PIPEBASE=PIPEBASE+1;
                    if (PIPEBASE < 10)
                    {
                        EPIPE_LTT = Pais + "0" + Zona + PIPE + octetodest2 + "0" + PIPEBASE; //variable EPIPE_LTT
                    }
                    else
                    {
                        EPIPE_LTT = Pais + "0" + Zona + PIPE + octetodest2 + PIPEBASE; //variable EPIPE_LTT
                    }                    
                    PIPEBASE_LTT = PIPEBASE_LTT + "-----CONFIGURO VPLS_LTT----" + "\r\n";
                    PIPEBASE_LTT = PIPEBASE_LTT + "-----------------------------" + "\r\n";
                    PIPEBASE_LTT = PIPEBASE_LTT + "\r\n";                    
                    PIPEBASE_LTT = PIPEBASE_LTT + "\r\n";
                    PIPEBASE_LTT = PIPEBASE_LTT + "configure service vpls 2013"+"\r\n";
                    PIPEBASE_LTT = PIPEBASE_LTT + "\r\n";
                    PIPEBASE_LTT = PIPEBASE_LTT + "\r\n";                                       
                    PIPEBASE_LTT = PIPEBASE_LTT + "spoke-sdp " + SDPori + ":2013 create" + "\r\n";
                    PIPEBASE_LTT = PIPEBASE_LTT + "\r\n";
                    PIPEBASE_LTT = PIPEBASE_LTT + "\r\n";
                    PIPEBASE_LTT = PIPEBASE_LTT + "exit all" + "\r\n";
                    PIPEBASE_LTT = PIPEBASE_LTT + "\r\n";
                }
                // RELEVAMIENTO
                /////////////////////////////////////////////////////////////////////////////////

                richTextBox1.Text = richTextBox1.Text + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "COMANDOS DE RELEVAMIENTO" + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "show service sap-using" + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "show service sap-using | match " + SAP + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "show service service-using" + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "show service service-using epipe" + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "¡IMPORTANTE!" + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "¡¡VERIFICAR QUE LOS SDP NO SE ENCUENTREN UTILIZADOS!!" + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "-------------------------------" + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "show service sdp" + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "Comando lado destino:" + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "show service sdp | match " + SDPdest + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "Comandos lado frontera:" + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "-------------------------------" + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "show service sdp | match " + SDPori + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "show service sdp-using" + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "Comando lado frontera:" + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "-------------------------------" + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "show service sdp-using | match " + IPdestino + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "Comandos lado destino:" + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "-------------------------------" + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "show service sdp-using | match " + separarIP[2] + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "Para ver los customer configurados en un equipo:" + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "show service customer" + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "PARA CREAR UN CUSTOMER EN CASO DE QUE SE NECESITE" + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "configure service customer xx create" + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "description (La descripcion va entre comillas dobles)" + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "\r\n";

                if (check_Inet.Checked == true)
                {
                    richTextBox1.Text = richTextBox1.Text + "show service id " + EPIPE_Inet + " base" + "\r\n";
                }
                if (check_RPV.Checked == true)
                {
                    richTextBox1.Text = richTextBox1.Text + "show service id " + EPIPE_RPV + " base" + "\r\n";
                }
                if (check_TIP.Checked == true)
                {
                    richTextBox1.Text = richTextBox1.Text + "show service id " + EPIPE_TIP + " base" + "\r\n";
                }
                if (check_LTT.Checked == true)
                {
                    richTextBox1.Text = richTextBox1.Text + "show service id " + EPIPE_LTT + " base" + "\r\n";
                }
                richTextBox1.Text = richTextBox1.Text + "admin display-config" + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "\r\n";
             
                // CONFIGURACION LADO FRONTERA
                /////////////////
                richTextBox1.Text = richTextBox1.Text + "-----LADO EQUIPO FRONTERA----" + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "-----------------------------" + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "-----------------------------" + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "telnet " + separarIP[2] + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "\r\n";              
                // configuro el SDP
                richTextBox1.Text = richTextBox1.Text + "-----CONFIGURO EL SDP----" + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "-------------------------" + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "configure service sdp " + SDPori + " mpls create" + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "far-end " + IPdestino + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "ldp" + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "no shutdown" + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "exit all" + "\r\n";
                richTextBox1.Text = richTextBox1.Text + "\r\n";

                richTextBox1.Text = richTextBox1.Text + PIPEBASE_INET;
                richTextBox1.Text = richTextBox1.Text + PIPEBASE_RPV;
                richTextBox1.Text = richTextBox1.Text + PIPEBASE_TIP;
                richTextBox1.Text = richTextBox1.Text + PIPEBASE_LTT;
               
                // LADO EQUIPO REMOTO
                //////////////////////////////////////////////////////////////////////////////

                    richTextBox1.Text = richTextBox1.Text + "-----LADO EQUIPO REMOTO----" + "\r\n";
                    richTextBox1.Text = richTextBox1.Text + "-----------------------------" + "\r\n";
                    richTextBox1.Text = richTextBox1.Text + "-----------------------------" + "\r\n";
                    richTextBox1.Text = richTextBox1.Text + "\r\n";
                    richTextBox1.Text = richTextBox1.Text + "telnet " + IPdestino + "\r\n";
                    richTextBox1.Text = richTextBox1.Text + "\r\n";
                    // configuro el puerto fisico
                    if (checkport.Checked == true)
                    {
                    }
                    else
                    {
                        richTextBox1.Text = richTextBox1.Text + "-----CONFIGURO EL PUERTO FISICO----" + "\r\n";
                        richTextBox1.Text = richTextBox1.Text + "-----------------------------------" + "\r\n";
                        richTextBox1.Text = richTextBox1.Text + "\r\n";
                        richTextBox1.Text = richTextBox1.Text + "configure port " + port + "\r\n";
                        richTextBox1.Text = richTextBox1.Text + "description " + desc + "\r\n";
                        richTextBox1.Text = richTextBox1.Text + "ethernet mode access" + "\r\n";
                        richTextBox1.Text = richTextBox1.Text + "ethernet encap-type dot1q" + "\r\n";
                        richTextBox1.Text = richTextBox1.Text + "ethernet mtu 1578" + "\r\n";
                        richTextBox1.Text = richTextBox1.Text + "ethernet duplex full" + "\r\n";
                        richTextBox1.Text = richTextBox1.Text + "--configurar velocidad, según la interfaz: 100 o 1000--" + "\r\n";
                        richTextBox1.Text = richTextBox1.Text + "ethernet speed 1000" + "\r\n";
                        richTextBox1.Text = richTextBox1.Text + "no shutdown" + "\r\n";
                        richTextBox1.Text = richTextBox1.Text + "exit" + "\r\n";
                        richTextBox1.Text = richTextBox1.Text + "\r\n";
                    }
                    // configuro el SDPdest
                    richTextBox1.Text = richTextBox1.Text + "-----CONFIGURO EL SDP----" + "\r\n";
                    richTextBox1.Text = richTextBox1.Text + "-------------------------" + "\r\n";
                    richTextBox1.Text = richTextBox1.Text + "configure service sdp " + SDPdest + " mpls create" + "\r\n";
                    richTextBox1.Text = richTextBox1.Text + "\r\n";                    
                    richTextBox1.Text = richTextBox1.Text + "far-end " + subX + "\r\n";
                    richTextBox1.Text = richTextBox1.Text + "ldp" + "\r\n";
                    richTextBox1.Text = richTextBox1.Text + "no shutdown" + "\r\n";
                    richTextBox1.Text = richTextBox1.Text + "exit all" + "\r\n";
                    richTextBox1.Text = richTextBox1.Text + "\r\n";
                    // configuro el EPIPE_Inet
                    if (check_Inet.Checked == true)
                    {
                        if (Pais == "3")
                        {
                            richTextBox1.Text = richTextBox1.Text + "-----CONFIGURO EL EPIPE_Inet----" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "--------------------------------" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "--------------------------------" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "--------------------------------" + "\r\n";  
                            richTextBox1.Text = richTextBox1.Text + "configure service epipe " + EPIPE_Inet + " customer " + cust + " create" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "description " + desc + "_Inet" + "\r\n";                            
                            richTextBox1.Text = richTextBox1.Text + "sap " + SAP + " create" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";                            
                            richTextBox1.Text = richTextBox1.Text + "exit" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "spoke-sdp " + SDPdest + ":" + EPIPE_Inet + " create" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "exit" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "no shutdown" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "exit all" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                        }
                        else
                            {
                            richTextBox1.Text = richTextBox1.Text + "-----CONFIGURO EL EPIPE_Inet----" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "--------------------------------" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "--------------------------------" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "--------------------------------" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "configure service epipe " + EPIPE_Inet + " customer " + cust + " create" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "description " + desc + "_Inet" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "service-mtu 1574" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "sap " + SAP + " create" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "ingress qos 201" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "egress qos 201" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "exit" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "spoke-sdp " + SDPdest + ":" + EPIPE_Inet + " create" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "exit" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "no shutdown" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "exit all" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                            }
                    }
                    if (check_RPV.Checked == true)
                    {
                        if (Pais == "3")
                        {
                            richTextBox1.Text = richTextBox1.Text + "-----CONFIGURO EL EPIPE_RPV----" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "-------------------------------" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "-------------------------------" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "configure service epipe " + EPIPE_RPV + " customer " + cust + " create" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "description " + desc + "_RPV" + "\r\n";                            
                            richTextBox1.Text = richTextBox1.Text + "sap " + SAP_RPV + " create" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";                            
                            richTextBox1.Text = richTextBox1.Text + "exit" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "spoke-sdp " + SDPdest + ":" + EPIPE_RPV + " create" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "exit" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "no shutdown" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "exit all" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                        }
                        else
                            {
                            richTextBox1.Text = richTextBox1.Text + "-----CONFIGURO EL EPIPE_RPV----" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "-------------------------------" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "-------------------------------" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "configure service epipe " + EPIPE_RPV + " customer " + cust + " create" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "description " + desc + "_RPV" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "service-mtu 1574" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "sap " + SAP_RPV + " create" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "ingress qos 300" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "egress qos 300" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "exit" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "spoke-sdp " + SDPdest + ":" + EPIPE_RPV + " create" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "exit" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "no shutdown" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "exit all" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                            }

                    }
                    if (check_TIP.Checked == true)
                    {
                        if (Pais == "3")
                        {
                            richTextBox1.Text = richTextBox1.Text + "-----CONFIGURO EL EPIPE_TIP----" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "-----------------------------" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "-----------------------------" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "configure service epipe " + EPIPE_TIP + " customer " + cust + " create" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "description " + desc + "_TIP" + "\r\n";                           
                            richTextBox1.Text = richTextBox1.Text + "sap " + SAP_TIP + " create" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "exit" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "spoke-sdp " + SDPdest + ":2012 create" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "exit" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "no shutdown" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "exit all" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                        }
                        else
                        {
                            richTextBox1.Text = richTextBox1.Text + "-----CONFIGURO EL EPIPE_TIP----" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "-----------------------------" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "-----------------------------" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "configure service epipe " + EPIPE_TIP + " customer " + cust + " create" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "description " + desc + "_TIP" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "service-mtu 1574" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "sap " + SAP_TIP + " create" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "exit" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "spoke-sdp " + SDPdest + ":2012 create" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "exit" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "no shutdown" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "exit all" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                        }
                    }
                    if (check_LTT.Checked == true)
                    {
                        if (Pais == "3")
                        {
                            richTextBox1.Text = richTextBox1.Text + "-----CONFIGURO EL EPIPE_LTT----" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "-----------------------------" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "-----------------------------" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "configure service epipe " + EPIPE_LTT + " customer " + cust + " create" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "description " + desc + "_LTT" + "\r\n";                           
                            richTextBox1.Text = richTextBox1.Text + "sap " + SAP_LTT + " create" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "exit" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "spoke-sdp " + SDPdest + ":2013 create" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "exit" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "no shutdown" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "exit all" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                        }
                        else
                        {
                            richTextBox1.Text = richTextBox1.Text + "-----CONFIGURO EL EPIPE_LTT----" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "-----------------------------" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "-----------------------------" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "configure service epipe " + EPIPE_LTT + " customer " + cust + " create" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "description " + desc + "_LTT" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "service-mtu 1574" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "sap " + SAP_LTT + " create" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "exit" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "spoke-sdp " + SDPdest + ":2013 create" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "exit" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "no shutdown" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "exit all" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                        }
                    }
                    // configuro el VPRN
                    if (checkBox1Gestión.Checked == true)
                    {
                        if (checkvprnexistente.Checked == true)
                        {
                            richTextBox1.Text = richTextBox1.Text + "--AGREGO OTRO CLIENTE AL VPRN--";
                            richTextBox1.Text = richTextBox1.Text + "---------------------------------" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                            // CONFIGURO IF DE MANAGEMENT DE RADIOS
                            richTextBox1.Text = richTextBox1.Text + "reemplazar el x por un Nº que NO este ocupado!!!";
                            richTextBox1.Text = richTextBox1.Text + "configure service vprn 4006" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "interface Management_Radios_x create" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "description " + desc + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "address " + IPBPE + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "sap " + port + ":" + VLANBPE + " create" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "exit" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "exit" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "no shutdown" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "exit all" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                            // CONFIGURO IF DE MANAGEMENT DEL SWITCH
                            richTextBox1.Text = richTextBox1.Text + "reemplazar el x por un Nº que NO este ocupado!!!";
                            richTextBox1.Text = richTextBox1.Text + "configure service vprn 4007" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "interface Management_CPEs_x create" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "description " + desc + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "address " + IPCPE + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "sap " + port + ":" + VLANCPE + " create" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "exit" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "exit" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "no shutdown" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "exit all" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                        }
                        else
                        {
                            richTextBox1.Text = richTextBox1.Text + "--CONFIGURO VPRN--";
                            richTextBox1.Text = richTextBox1.Text + "---------------------" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                            // CONFIGURO IF DE MANAGEMENT DE RADIOS
                            richTextBox1.Text = richTextBox1.Text + "configure service vprn 4006 customer 17 create" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "description Management-Radios" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "snmp-community vprn_4006 version both" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "router-id " + IPdestino + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "route-distinguisher 11664:99" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "auto-bind ldp" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "vrf-target target:11664:99" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "interface Management_Radios create" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "description " + desc + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "address " + IPBPE + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "sap " + port + ":" + VLANBPE + " create" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "exit" + "\r\n";                            
                            richTextBox1.Text = richTextBox1.Text + "exit" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "no shutdown" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "exit all" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                            // CONFIGURO IF DE MANAGEMENT DEL SWITCH
                            richTextBox1.Text = richTextBox1.Text + "configure service vprn 4007 customer 17 create" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "description Management-CPEs" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "snmp-community vprn_4007 version both" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "router-id " + IPdestino + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "route-distinguisher 11664:98" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "auto-bind ldp" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "vrf-target target:11664:98" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "interface Management_CPEs create" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "description " + desc + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "address " + IPCPE + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "sap " + port + ":" + VLANCPE + " create" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "exit" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "exit" + "\r\n";

                            if (checkRuta.Checked == true) // en caso de que se necesite cargar una ruta estatica
                            {
                                richTextBox1.Text = richTextBox1.Text + "static-route " + prefijo_de_gestion + " next-hop " + Next_Hop + "\r\n";
                            }
                            richTextBox1.Text = richTextBox1.Text + "no shutdown" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "exit all" + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "\r\n";
                            richTextBox1.Text = richTextBox1.Text + "admin save" + "\r\n"; // grabar la config
                        }
                        //
                        // FIN DE CONFIGURACION
                        //
                        //-TROUBLESHOOTING-//
                        /////////////////
                        richTextBox1.Text = richTextBox1.Text + "\r\n";
                        richTextBox1.Text = richTextBox1.Text + "COMANDOS DE TROUBLESHOOTING" + "\r\n";
                        richTextBox1.Text = richTextBox1.Text + "\r\n";
                        richTextBox1.Text = richTextBox1.Text + "EQUIPO FRONTERA" + "\r\n"; ;
                        if (check_Inet.Checked == true)                
                        {      
                         richTextBox1.Text = richTextBox1.Text + "oam svc-ping " + IPdestino + " service " + EPIPE_Inet + "\r\n";        
                        }
                        if (check_RPV.Checked == true)                
                        {
                        richTextBox1.Text = richTextBox1.Text + "oam svc-ping " + IPdestino + " service " + EPIPE_RPV + "\r\n";        
                        }
                        if (check_TIP.Checked == true)                
                        {
                        richTextBox1.Text = richTextBox1.Text + "oam svc-ping " + IPdestino + " service " + EPIPE_TIP + "\r\n";
                        richTextBox1.Text = richTextBox1.Text + "show service 2012 fdb detail" + "\r\n";
                        }
                        if (check_LTT.Checked == true)  
                        {
                        richTextBox1.Text = richTextBox1.Text + "oam svc-ping " + IPdestino + " service " + EPIPE_LTT + "\r\n";
                        richTextBox1.Text = richTextBox1.Text + "show service 2013 fdb detail" + "\r\n";
                        }
                        richTextBox1.Text = richTextBox1.Text + "EQUIPO DESTINO" + "\r\n"; ;
                        richTextBox1.Text = richTextBox1.Text + "ping router 4006 " + IPBPE + "\r\n";
                        richTextBox1.Text = richTextBox1.Text + "show router 4006 arp" + "\r\n";
                        richTextBox1.Text = richTextBox1.Text + "ping router 4007 " + Next_Hop + "\r\n";
                        richTextBox1.Text = richTextBox1.Text + "show router 4007 arp" + "\r\n";                                               
                        richTextBox1.Text = richTextBox1.Text + "show port " + port + "\r\n";
                        richTextBox1.Text = richTextBox1.Text + "show port description" + "\r\n";
                        richTextBox1.Text = richTextBox1.Text + "\r\n";
                    }
                richTextBox1.Visible = true;
                }
                //btn2.Visible = true;
        }
        private void checkBox1Gestión_CheckedChanged(object sender, EventArgs e)
        {            
            if (checkBox1Gestión.Checked == true)
            {
                txtVLANCPE.Visible = true;
                lbl12.Visible = true;
                txtVLANBPE.Visible = true;
                lbl13.Visible = true;
                txtipcpe.Visible = true;
                lbl16.Visible = true;
                txtipbpe.Visible = true;
                lbl17.Visible = true;
                checkRuta.Visible = true;
                groupBox2.Visible = true;
                checkvprnexistente.Visible = true;
            }
            else
            {
                txtVLANCPE.Visible = false;
                lbl12.Visible = false;
                txtVLANBPE.Visible = false;
                lbl13.Visible = false;
                txtipcpe.Visible = false;
                lbl16.Visible = false;
                txtipbpe.Visible = false;
                lbl17.Visible = false;
                checkRuta.Visible = false;
                groupBox2.Visible = false;
            }
        }
        private void checkRuta_CheckedChanged(object sender, EventArgs e)
        {
            if (checkRuta.Checked == true)
            {
                txtstatic.Visible = true; 
                lbl14.Visible = true;
                txtnext.Visible = true;
                lbl15.Visible = true;                
            }
            else 
            {
                txtstatic.Visible = false;
                lbl14.Visible = false;
                txtnext.Visible = false;
                lbl15.Visible = false;
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            btn2.BackColor = Color.Lavender;
            DateTime time = DateTime.Now;
            string format = "d MMM yyyy";
            // Text from the rich textbox rtfMain
            string str = richTextBox1.Text;
            // Create a new SaveFileDialog object
            using (SaveFileDialog dlgSave = new SaveFileDialog())
                try
                {
                    // Available file extensions
                    dlgSave.Filter = "Text Files (*.txt)|*.txt";
                    // SaveFileDialog title
                    dlgSave.Title = "Save";
                    // SaveFileDialog Ext
                    dlgSave.DefaultExt = "txt";
                    dlgSave.FileName = txtdsc.Text + time.ToString(format) + "_.TXT";
                    // Show SaveFileDialog
                    if (dlgSave.ShowDialog() == DialogResult.OK && dlgSave.FileName.Length > 0)
                    {
                        StreamWriter sw = new StreamWriter(dlgSave.FileName);

                        for (int i = 0; i < richTextBox1.Lines.Length; i++)
                        {
                            sw.WriteLine(richTextBox1.Lines[i]);
                        }
                        //sw.Write(str);
                        sw.Flush();
                        sw.Close();
                    }
                }
                catch (Exception errorMsg)
                {
                    MessageBox.Show(errorMsg.Message);
                }
        }
        public static bool IsAllLettersOrDigits(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetterOrDigit(c))
                    if( c.ToString() != "-")
                    return false;
            }
            return true;
        }
        public static bool IsAllDigits(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        public Boolean CheckIPValid(String strIP)
        {
            //  Split string by ".", check that array length is 3
            char chrFullStop = '.';
            string[] arrOctets = strIP.Split(chrFullStop);
            if (arrOctets.Length != 4)
            {
                return false;
            }
            //  Check each substring checking that the int value is less than 255 and that is char[] length is !> 2
            Int16 MAXVALUE = 255;
            Int32 temp; // Parse returns Int32
            foreach (String strOctet in arrOctets)
            {
                if (strOctet.Length > 3)
                {
                    return false;
                }
                temp = int.Parse(strOctet);
                if (temp > MAXVALUE)
                {
                    return false;
                }
            }
            return true;
        }
        private void checkVLAN_CheckedChanged(object sender, EventArgs e)
        {
            if (checkVLAN.Checked == true)
            {                
                check_Inet.Visible = true;               
                check_RPV.Visible = true;                                
                check_TIP.Visible = true;                                
                check_LTT.Visible = true;
            }
            else
            {
                check_Inet.Visible = false;               
                check_RPV.Visible = false;                
                check_TIP.Visible = false;                
                check_LTT.Visible = false;
                txtCT.Visible = false;
                txtCT_RPV.Visible = false;
                txtCT_TIP.Visible = false;
                txtCT_LTT.Visible = false;
            }
        }
        private void cmboxzona_dest_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtdestino.Visible = true;
            lbl5.Visible = true;
            txtport.Visible = true;
            lbl7.Visible = true;
        }
        private void check_Inet_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Inet.Checked == true)
            {
                txtCT.Visible = true;
            }
            else
            {
                txtCT.Visible = false;
            }            
        }
        private void check_RPV_CheckedChanged(object sender, EventArgs e)
        {
            if (check_RPV.Checked == true)
            {
                txtCT_RPV.Visible = true;
            }
            else
            {
                txtCT_RPV.Visible = false;
            }
        }
        private void check_TIP_CheckedChanged(object sender, EventArgs e)
        {
            if (check_TIP.Checked == true)
            {
                txtCT_TIP.Visible = true;
            }
            else
            {
                txtCT_TIP.Visible = false;
            }
        }
        private void check_LTT_CheckedChanged(object sender, EventArgs e)
        {
            if (check_LTT.Checked == true)
            {
                txtCT_LTT.Visible = true;
            }
            else
            {
                txtCT_LTT.Visible = false;
            }
        }
        private void button1_Click(object sender, EventArgs e) // limpio los datos ingresados con el boton Reset
        {
            button1.BackColor = Color.Red;
            cmboxtipo.SelectedItem = null; // limpio el tipo de EPIPE
            cmboxpais.SelectedItem = null; // limpio pais origen
            cmboxzona.SelectedItem = null; // limpio zona origen
            cmboxorigen.SelectedItem = null; // limpio equipo origen
            cmboxpais_dest.SelectedItem = null; // limpio pais destino
            cmboxzona_dest.SelectedItem = null; // limpio zona destino
            richTextBox1.Text = ""; // limpio el textbox
            richTextBox1.Visible = false;
            txtdestino.Text = ""; // limpio IP Destino
            txtport.Text = ""; // limpio Puerto
            txtdsc.Text = ""; // limpio descripción            
            txtCT.Text = ""; // limpio VLAN_INET
            txtCT_RPV.Text = ""; // limpio VLAN_RPV
            txtCT_TIP.Text = ""; // limpio VLAN_TIP
            txtCT_LTT.Text = ""; // limpio VLAN_LTT
            txtVLANCPE.Text = ""; // limpio VLAN de Mgmt del switch
            txtipcpe.Text = ""; // limpio IP de Mgmt del switch
            txtVLANBPE.Text = ""; // limpio VLAN de Mgmt del radio
            txtipbpe.Text = ""; // limpio IP de Mgmt del radio
            txtstatic.Text = ""; // limpio ruta estatica
            txtnext.Text = ""; // limpio el next-hop
            textcust.Text = ""; // limpio el campo customer
            textSDPfront.Text = ""; // limpio el campo SDP Frontera
            textSDPdest.Text = ""; // // limpio el campo SDP destino
            checkRuta.Checked = false; // limpio el check de la ruta estática
            checkBox1Gestión.Checked = false; // limpio el check de los datos de gestión
            checkvprnexistente.Checked = false; // limpio el check de VPRN existente
            checkVLAN.Checked = false; // limpio el check de las vlans
            check_Inet.Checked = false; // limpio el check de la vlan Inet
            check_RPV.Checked = false; // limpio el check de la vlan RPV
            check_TIP.Checked = false; // limpio el check de la vlan TIP
            check_LTT.Checked = false; // limpio el check de la vlan LTT
            button1.Visible = false;
            btn1.Visible = true;
            btn2.Visible = false;
            errorProvider1.Clear(); // limpia los errores cada vez que ocurre el evento btn1_Click     
        }
        private void btn1_MouseHover(object sender, EventArgs e)
        {
            btn1.BackColor = Color.SteelBlue;
        }
        private void btn1_MouseLeave(object sender, EventArgs e)
        {
            btn1.BackColor = Color.Azure;
        }
        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkRed;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }
        private void btn2_MouseHover(object sender, EventArgs e)
        {
            btn2.BackColor = Color.LavenderBlush;
        }
        private void btn2_MouseLeave(object sender, EventArgs e)
        {
            btn2.BackColor = Color.Lavender;
        }
    }
}