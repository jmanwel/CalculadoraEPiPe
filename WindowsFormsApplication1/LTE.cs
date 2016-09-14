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
    public partial class LTE : Form
    {
        public LTE()
        {
            InitializeComponent();
        }
        private void LTE_Load(object sender, EventArgs e)
        {
        checkVPRN.Visible = false;
        }
        private void buttonCalc_Click(object sender, EventArgs e)
        {            
            errorProvider1.Clear(); // limpia los errores cada vez que ocurre el evento btn1_Click
            bool ERROR = false;

            if (IsAllDigits(textcust1.Text) == false) // valido Customer 1
            {
                errorProvider1.SetError(textcust1, "Debe ser valor númerico");
                ERROR = true;
            }
            if (IsAllDigits(textcust2.Text) == false) // valido Customer 2
            {
                errorProvider1.SetError(textcust2, "Debe ser valor númerico");
                ERROR = true;
            }
            if (IsAllDigits(textcust3.Text) == false) // valido Customer 3
            {
                errorProvider1.SetError(textcust3, "Debe ser valor númerico");
                ERROR = true;
            }
            if (IsAllDigits(textvprn1.Text) == false) // valido VPRN 1
            {
                errorProvider1.SetError(textvprn1, "Debe ser valor númerico");
                ERROR = true;
            }
            if (IsAllDigits(textvprn2.Text) == false) // valido VPRN 2
            {
                errorProvider1.SetError(textvprn2, "Debe ser valor númerico");
                ERROR = true;
            }
            if (IsAllDigits(textvprn3.Text) == false) // valido VPRN 3
            {
                errorProvider1.SetError(textvprn3, "Debe ser valor númerico");
                ERROR = true;
            }
            if (CheckIPValid(textip1.Text) == false) // valido IP1
            {
                errorProvider1.SetError(textip1, "Debe ser valor númerico");
                ERROR = true;
            }
            if (CheckIPValid(textip2.Text) == false) // valido IP2
            {
                errorProvider1.SetError(textip2, "Debe ser valor númerico");
                ERROR = true;
            }
            if (CheckIPValid(textip3.Text) == false) // valido IP3
            {
                errorProvider1.SetError(textip3, "Debe ser valor númerico");
                ERROR = true;
            }
            if (IsAllDigits(textvlan1.Text) == false) // valido VLAN1
            {
                errorProvider1.SetError(textvlan1, "Debe ser valor númerico");
                ERROR = true;
            }
            if (IsAllDigits(textvlan2.Text) == false) // valido VLAN2
            {
                errorProvider1.SetError(textvlan2, "Debe ser valor númerico");
                ERROR = true;
            }   
            if (IsAllDigits(textvlan3.Text) == false) // valido VLAN3
            {
                errorProvider1.SetError(textvlan3, "Debe ser valor númerico");
                ERROR = true;
            }
            if (textport.Text == "") // valido puerto
            {
                if (checkportexiste.Checked == true)
                { 
                }
                else
                {
                 errorProvider1.SetError(textport, "Campo obligatorio");
                 ERROR = true;
                }
             }
            if (textIR.Text == "" || IsAllLettersOrDigits(textIR.Text) == false) // valido descripción
            {
                errorProvider1.SetError(textIR, "Campo obligatorio y sin espacios");
                ERROR = true;
            }
            if (ERROR == false)
            {
                if (checkcust.Checked == true)
                {
                    string customer1 = textcust1.Text;
                    string customer2 = textcust2.Text;
                    string customer3 = textcust3.Text;

                    if (checkVPRN.Checked == true)
                    {
                        string VPRN1 = textvprn1.Text;
                        string VPRN2 = textvprn2.Text;
                        string VPRN3 = textvprn3.Text;

                        string IP1 = textip1.Text;
                        string IP2 = textip2.Text;
                        string IP3 = textip3.Text;

                        string VLAN1 = textvlan1.Text;
                        string VLAN2 = textvlan2.Text;
                        string VLAN3 = textvlan3.Text;

                        string IR = textIR.Text;
                        string port = textport.Text;
                        string IPSAR = textipsar.Text;

                        output.Text = output.Text + "telnet "+ IPSAR + "\r\n";
                        output.Text = output.Text + "\r\n";
                        output.Text = output.Text + "Comandos de verificación"+"\r\n";
                        output.Text = output.Text + "------------------" + "\r\n";
                        output.Text = output.Text + "------------------" + "\r\n";
                        output.Text = output.Text + "Verificar VPRN" + "\r\n";
                        output.Text = output.Text + "show service service-using vprn" + "\r\n";
                        output.Text = output.Text + "\r\n";
                        output.Text = output.Text + "Verificar customers" + "\r\n";
                        output.Text = output.Text + "show service customer" + "\r\n";
                        output.Text = output.Text + "\r\n";
                        output.Text = output.Text + "Verificar IP del SAR" + "\r\n";
                        output.Text = output.Text + "show router interface" + "\r\n";
                        output.Text = output.Text + "\r\n";
                        output.Text = output.Text + "Verificar port" + "\r\n";
                        output.Text = output.Text + "configure port " + port + "\r\n";
                        output.Text = output.Text + "info" + "\r\n";
                        output.Text = output.Text + "\r\n";
                        output.Text = output.Text + "------------------" + "\r\n";
                        output.Text = output.Text + "------------------" + "\r\n";

                        if (checkportexiste.Checked == true)
                        { 
                        }
                        else
                        {
                            output.Text = output.Text + "\r\n";
                            output.Text = output.Text + "Configuro el puerto" + "\r\n";
                            output.Text = output.Text + "------------------" + "\r\n";
                            output.Text = output.Text + "description \"LTE_3.5-FIJA_"+IR+"\""+"\r\n";
                            output.Text = output.Text + "ethernet" + "\r\n";
                            output.Text = output.Text + "encap-type dot1q" + "\r\n";
                            output.Text = output.Text + "no autonegotiate"  + "\r\n";
                            output.Text = output.Text + "exit" + "\r\n";
                            output.Text = output.Text + "no shutdown" + "\r\n";
                            output.Text = output.Text + "\r\n";
                        }
                            output.Text = output.Text + "Crear las interfaces + SAP" + "\r\n";
                            output.Text = output.Text + "------------------" + "\r\n";
                            output.Text = output.Text + "\r\n";
                            output.Text = output.Text + "configure service vprn " + VPRN1 + "\r\n";
                            output.Text = output.Text + "interface \"" + IR + "\" create" + "\r\n";
                            output.Text = output.Text + "description \"" + IR + "\"" + "\r\n";
                            output.Text = output.Text + "address " + IP1 + "\r\n";
                            output.Text = output.Text + "sap " + port + ":" + VLAN1 + " create" + "\r\n";
                            output.Text = output.Text + "no shutdown" + "\r\n";
                            output.Text = output.Text + "exit" + "\r\n";
                            output.Text = output.Text + "no shutdown" + "\r\n";
                            output.Text = output.Text + "exit all" + "\r\n";
                            output.Text = output.Text + "\r\n";

                            output.Text = output.Text + "configure service vprn " + VPRN2 + "\r\n";
                            output.Text = output.Text + "interface \"" + IR + "\" create" + "\r\n";
                            output.Text = output.Text + "description \"" + IR + "\"" + "\r\n";
                            output.Text = output.Text + "address " + IP2 + "\r\n";
                            output.Text = output.Text + "sap " + port + ":" + VLAN2 + " create" + "\r\n";
                            output.Text = output.Text + "no shutdown" + "\r\n";
                            output.Text = output.Text + "exit" + "\r\n";
                            output.Text = output.Text + "no shutdown" + "\r\n";
                            output.Text = output.Text + "exit all" + "\r\n";
                            output.Text = output.Text + "\r\n";

                            output.Text = output.Text + "configure service vprn " + VPRN3 + "\r\n";
                            output.Text = output.Text + "interface \"" + IR + "\" create" + "\r\n";
                            output.Text = output.Text + "description \"" + IR + "\"" + "\r\n";
                            output.Text = output.Text + "address " + IP3 + "\r\n";
                            output.Text = output.Text + "sap " + port + ":" + VLAN3 + " create" + "\r\n";
                            output.Text = output.Text + "no shutdown" + "\r\n";
                            output.Text = output.Text + "exit" + "\r\n";
                            output.Text = output.Text + "no shutdown" + "\r\n";
                            output.Text = output.Text + "exit all" + "\r\n";
                            output.Text = output.Text + "\r\n";                        
                    }
                }
                else
                {
                    checkVPRN.Visible = false;

                    string customer1 = textcust1.Text;
                    string customer2 = textcust2.Text;
                    string customer3 = textcust3.Text;

                    string VPRN1 = textvprn1.Text;
                    string VPRN2 = textvprn2.Text;
                    string VPRN3 = textvprn3.Text;

                    string IP1 = textip1.Text;
                    string IP2 = textip2.Text;
                    string IP3 = textip3.Text;

                    string VLAN1 = textvlan1.Text;
                    string VLAN2 = textvlan2.Text;
                    string VLAN3 = textvlan3.Text;

                    string IR = textIR.Text;
                    string port = textport.Text;
                    string IPSAR = textipsar.Text;

                    output.Text = output.Text + "telnet " + IPSAR + "\r\n";
                    output.Text = output.Text + "\r\n";
                    output.Text = output.Text + "Comandos de verificación" + "\r\n";
                    output.Text = output.Text + "------------------" + "\r\n";
                    output.Text = output.Text + "------------------" + "\r\n";
                    output.Text = output.Text + "Verificar VPRN" + "\r\n";
                    output.Text = output.Text + "show service service-using vprn" + "\r\n";
                    output.Text = output.Text + "\r\n";
                    output.Text = output.Text + "Verificar customers" + "\r\n";
                    output.Text = output.Text + "show service customer" + "\r\n";
                    output.Text = output.Text + "\r\n";
                    output.Text = output.Text + "Verificar IP del SAR" + "\r\n";
                    output.Text = output.Text + "show router interface" + "\r\n";
                    output.Text = output.Text + "\r\n";
                    output.Text = output.Text + "Verificar port" + "\r\n";
                    output.Text = output.Text + "configure port " + port + "\r\n";
                    output.Text = output.Text + "info" + "\r\n";
                    output.Text = output.Text + "\r\n";
                    output.Text = output.Text + "------------------" + "\r\n";
                    output.Text = output.Text + "------------------" + "\r\n";
                    output.Text = output.Text + "\r\n";

                    output.Text = output.Text + "Crear los customer"+"\r\n";
                    output.Text = output.Text + "------------------" + "\r\n";
                    output.Text = output.Text + "------------------" + "\r\n";
                    output.Text = output.Text + "\r\n";
                    output.Text = output.Text + "configure service customer " + customer1 + " create" + "\r\n";
                    output.Text = output.Text + "description VPRN_" + VPRN1 +"-CP-LTE3.5" + "\r\n";
                    output.Text = output.Text + "\r\n";
                    output.Text = output.Text + "configure service customer " + customer2 + " create" + "\r\n";
                    output.Text = output.Text + "description VPRN_" + VPRN2 + "-UP-LTE3.5" + "\r\n";
                    output.Text = output.Text + "\r\n";
                    output.Text = output.Text + "configure service customer " + customer3 + " create" + "\r\n";
                    output.Text = output.Text + "description VPRN_" + VPRN3 + "-O&M-LTE3.5" + "\r\n";
                    output.Text = output.Text + "\r\n";
                    output.Text = output.Text + "Crear los VPRN" + "\r\n";
                    output.Text = output.Text + "------------------" + "\r\n";
                    output.Text = output.Text + "------------------" + "\r\n";
                    output.Text = output.Text + "\r\n";
                    output.Text = output.Text + "configure service vprn " + VPRN1 + " customer " + customer1 + " create" + "\r\n";
                    output.Text = output.Text + "description \"VPRN_"+VPRN1+"_LTE_FIJA_CP\"" + "\r\n";
                    output.Text = output.Text + "snmp-community \"x5VFtthT8B0ccyvEC0j7cU\" hash2 version both" + "\r\n";
                    output.Text = output.Text + "router-id " + IPSAR + "\r\n";
                    output.Text = output.Text + "11664:"+ customer1 + "\r\n";
                    output.Text = output.Text + "auto-bind ldp " + "\r\n";
                    output.Text = output.Text + "vrf-target target:11664:" +customer1 + "\r\n";
                    output.Text = output.Text + "interface \"" + IR + "\" create" + "\r\n";
                    output.Text = output.Text + "description \"" + IR + "\"" + "\r\n";
                    output.Text = output.Text + "address " + IP1 + "\r\n";
                    output.Text = output.Text + "sap " + port + ":" + VLAN1 + " create" + "\r\n";
                    output.Text = output.Text + "no shutdown" + "\r\n";
                    output.Text = output.Text + "exit" + "\r\n";
                    output.Text = output.Text + "no shutdown" + "\r\n";
                    output.Text = output.Text + "exit all" + "\r\n";
                    output.Text = output.Text + "\r\n";
                    output.Text = output.Text + "no shutdown" + "\r\n";
                    output.Text = output.Text + "------------------" + "\r\n";
                    output.Text = output.Text + "\r\n";
                    output.Text = output.Text + "configure service vprn " + VPRN2 + " customer " + customer2 + " create" + "\r\n";
                    output.Text = output.Text + "description \"VPRN_" + VPRN2 + "_LTE_FIJA_UP\"" + "\r\n";
                    output.Text = output.Text + "snmp-community \"x5VFtthT8B0ccyvEC0j7cU\" hash2 version both" + "\r\n";
                    output.Text = output.Text + "router-id " +IPSAR + "\r\n";
                    output.Text = output.Text + "11664:" + customer2 + "\r\n";
                    output.Text = output.Text + "auto-bind ldp " + "\r\n";
                    output.Text = output.Text + "vrf-target target:11664:" + customer2 + "\r\n";
                    output.Text = output.Text + "interface \"" + IR + "\" create" + "\r\n";
                    output.Text = output.Text + "description \"" + IR + "\"" + "\r\n";
                    output.Text = output.Text + "address " + IP2 + "\r\n";
                    output.Text = output.Text + "sap " + port + ":" + VLAN2 + " create" + "\r\n";
                    output.Text = output.Text + "no shutdown" + "\r\n";
                    output.Text = output.Text + "exit" + "\r\n";
                    output.Text = output.Text + "no shutdown" + "\r\n";
                    output.Text = output.Text + "exit all" + "\r\n";
                    output.Text = output.Text + "\r\n";
                    output.Text = output.Text + "no shutdown" + "\r\n";
                    output.Text = output.Text + "------------------" + "\r\n";
                    output.Text = output.Text + "\r\n";
                    output.Text = output.Text + "configure service vprn " + VPRN3 + " customer " + customer3 + " create" + "\r\n";
                    output.Text = output.Text + "description \"VPRN_" + VPRN3 + "_LTE_FIJA_O&M\"" + "\r\n";
                    output.Text = output.Text + "snmp-community \"x5VFtthT8B0ccyvEC0j7cU\" hash2 version both" + "\r\n";
                    output.Text = output.Text + "router-id " + IPSAR + "\r\n";
                    output.Text = output.Text + "11664:" + customer3 + "\r\n";
                    output.Text = output.Text + "auto-bind ldp " + "\r\n";
                    output.Text = output.Text + "vrf-target target:11664:" + customer3 + "\r\n";
                    output.Text = output.Text + "interface \"" + IR + "\" create" + "\r\n";
                    output.Text = output.Text + "description \"" + IR + "\"" + "\r\n";
                    output.Text = output.Text + "address " + IP3 + "\r\n";
                    output.Text = output.Text + "sap " + port + ":" + VLAN3 + " create" + "\r\n";
                    output.Text = output.Text + "no shutdown" + "\r\n";
                    output.Text = output.Text + "exit" + "\r\n";
                    output.Text = output.Text + "no shutdown" + "\r\n";
                    output.Text = output.Text + "exit all" + "\r\n";
                    output.Text = output.Text + "\r\n";
                    output.Text = output.Text + "no shutdown" + "\r\n";
                    output.Text = output.Text + "------------------" + "\r\n";
                    output.Text = output.Text + "\r\n";                
                }
            }
        }    
        public static bool IsAllDigits(string s) // valído números
        {
            foreach (char c in s)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        public static bool IsAllLettersOrDigits(string s) // valído letras
        {
            foreach (char c in s)
            {
                if (!Char.IsLetterOrDigit(c))
                    if (c.ToString() != "-")
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
            private void buttonReset_Click(object sender, EventArgs e) // evento botón reset
            {
                textcust1.Text = "";
                textcust2.Text = "";
                textcust3.Text = "";
                textvprn1.Text = "";
                textvprn2.Text = "";
                textvprn3.Text = "";
                textip1.Text = "";
                textip2.Text = "";
                textip3.Text = "";
                textvlan1.Text = "";
                textvlan2.Text = "";
                textvlan3.Text = "";
                textIR.Text = "";
                textport.Text = "";
                textipsar.Text = "";
                checkportexiste.Checked = false;
                checkcust.Checked = false;
                checkVPRN.Checked = false;
                output.Text = ""; 
                errorProvider1.Clear(); // limpia los errores cada vez que ocurre el evento btn1_Click 
            }
            private void buttonGuardar_Click(object sender, EventArgs e) // guardo el template
            {
                DateTime time = DateTime.Now;
                string format = "d MMM yyyy";
                // Text from the rich textbox rtfMain
                string str = output.Text;
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
                        dlgSave.FileName = textIR.Text + time.ToString(format) + "_.TXT";
                        // Show SaveFileDialog
                        if (dlgSave.ShowDialog() == DialogResult.OK && dlgSave.FileName.Length > 0)
                        {
                            StreamWriter sw = new StreamWriter(dlgSave.FileName);

                            for (int i = 0; i < output.Lines.Length; i++)
                            {
                                sw.WriteLine(output.Lines[i]);
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
            private void checkcust_CheckedChanged(object sender, EventArgs e)
            {
                if (checkcust.Checked == true)
                checkVPRN.Visible = true;
                else
                checkVPRN.Visible = false;
            } 
    }
}


