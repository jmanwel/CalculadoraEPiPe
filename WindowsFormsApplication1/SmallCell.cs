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
    public partial class SmallCell : Form
    {
        public SmallCell()
        {
            InitializeComponent();
            textDest.Visible = true;
            textPort.Visible = true;           
            // variables origen
            comboFront.Items.Add("Rosario_66000_SF898_COR70_SAR18_10.2.21.198_2_1/9/7");
            comboFront.Items.Add("Cordoba_66010_CO895_OFC70_SAR18_10.2.21.186_2_1/10/7");
            comboFront.Items.Add("Cordoba_66050_CO008_CRV70_SR7_10.2.21.1_2_1/10/7");
            comboFront.Items.Add("Mendoza_66020_ME298_MTS70_SAR18_10.2.21.199_3_1/3/7");
            comboFront.Items.Add("Olleros_66030_C2470_OLS70_SR7_10.2.20.209_1_lag-1");
            comboFront.Items.Add("Olleros_66031_C2470_OLS70_SR7_10.2.20.209_1_lag-1");
            comboFront.Items.Add("Garay_66040_CF296_GRY0_SR7_10.2.20.210_1_lag-1");
            comboFront.Items.Add("Garay_66041_CF296_GRY0_SR7_10.2.20.210_1_lag-1"); 
           // variables zona
            comboZona.Items.Add("1-Amba");
            comboZona.Items.Add("2-Norte");
            comboZona.Items.Add("3-Sur");
            comboZona.Items.Add("4-Oeste");
        }
        private void checkMeth_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMeth.Checked == true)
            {
                textDest.Visible = false;
                textPort.Visible = false;
                comboZona.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label6.Visible = false;
                UpDownbase.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
            }
                else
                {
                textDest.Visible = true;
                textPort.Visible = true;
                comboZona.Visible = true;
                label6.Visible = true;
                UpDownbase.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                }              
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string IP = comboFront.SelectedItem.ToString().Split('_')[5];
            string VPLS = comboFront.SelectedItem.ToString().Split('_')[1];
            string PortFront = comboFront.SelectedItem.ToString().Split('_')[7];
            string TAG = textVlan.Text;
            string DESC = textDesc.Text;                       
            if (checkMeth.Checked == true)
            {
                richTextresult.Text = richTextresult.Text + "\r\n";
                richTextresult.Text = richTextresult.Text + "Frontera MetroEthernet" + "\r\n";
                richTextresult.Text = richTextresult.Text + "\r\n";
                richTextresult.Text = richTextresult.Text + "\r\n";
                richTextresult.Text = richTextresult.Text + "Revisar que el SAP no este configurado!!"+"\r\n";
                richTextresult.Text = richTextresult.Text + "\r\n";
                richTextresult.Text = richTextresult.Text + "telnet " + IP + "\r\n";
                richTextresult.Text = richTextresult.Text + "configure service vpls " + VPLS + "\r\n";
                richTextresult.Text = richTextresult.Text + "info" + "\r\n";
                richTextresult.Text = richTextresult.Text + "\r\n";
                richTextresult.Text = richTextresult.Text + "Configuro VPLS en equipo Frontera" + "\r\n";
                richTextresult.Text = richTextresult.Text + "\r\n";
                richTextresult.Text = richTextresult.Text + "telnet " + IP + "\r\n";
                richTextresult.Text = richTextresult.Text + "\r\n";
                richTextresult.Text = richTextresult.Text + "configure service vpls " + VPLS + "\r\n";
                if (PortFront == "lag-1")
                richTextresult.Text = richTextresult.Text + "sap " + PortFront + ":" + TAG + ".* split-horizon-group \"sc\" create" + "\r\n";
                else
                richTextresult.Text = richTextresult.Text + "sap " + PortFront + ":" + TAG + " split-horizon-group \"sc\" create" + "\r\n";
                richTextresult.Text = richTextresult.Text + "description \"" + DESC + "\"" + "\r\n";
                richTextresult.Text = richTextresult.Text + "\r\n";
                richTextresult.Text = richTextresult.Text + "exit all" + "\r\n";
                richTextresult.Text = richTextresult.Text + "admin save";
                richTextresult.Text = richTextresult.Text + "\r\n";
                richTextresult.Text = richTextresult.Text + "Para verificar" + "\r\n";
                richTextresult.Text = richTextresult.Text + "\r\n";
                richTextresult.Text = richTextresult.Text + "show service id " + VPLS + " fdb detail" + "\r\n";
            }
            else
            {
                string REM = textDest.Text;
                string PORT = textPort.Text;
                string ZoneOr = comboFront.SelectedItem.ToString().Split('_')[6]; // zona origen               
                string ZoneDest = comboZona.SelectedItem.ToString().Split('-')[0]; // zona destino
                string OctFront = IP.Split('.')[3]; // ultimo octeto de la IP Frontera

                if (OctFront.Length == 1) // si el ultimo octeto de origen tiene solo un digito
                    OctFront = "0" + OctFront;

                string OctDest = REM.Substring(REM.Length - 2, 2); //  ultimo octeto de la IP Remoto
                if (OctDest.Length == 1) // si el ultimo octeto destino tiene solo un digito
                    OctDest = "0" + OctDest;

                string SDPFront = ZoneOr + OctDest + ZoneDest;// SDP a configurar en Frontera
                string SDPRem = ZoneOr + OctFront + ZoneDest;// SDP a configurar en Remoto

                int Base1 = Convert.ToInt16(UpDownbase.Value) - 1;
                if (Base1 <= 0)
                    Base1 = 1;

                string OctFront2 = OctFront;
                // válido para calcular el EPIPE 
                if (OctFront2.Length == 1)
                    OctFront2 = "00" + OctFront2;
                if (OctFront2.Length == 2)
                    OctFront2 = "0" + OctFront2;
                string PIPECell = "10" + ZoneOr + "1" + OctFront2 + Base1;// EPIPE -COMUN A LOS DOS EQUIPOS-

                if (Base1 < 10)
                {
                    PIPECell = "10" + ZoneOr + "1" + OctFront2 + "0" + Base1;
                }
                else
                {
                    PIPECell = "10" + ZoneOr + "1" + OctFront2 + Base1;
                }                
                richTextresult.Text = richTextresult.Text + "Frontera IPRAN" + "\r\n";
                richTextresult.Text = richTextresult.Text + "\r\n";                
                richTextresult.Text = richTextresult.Text + "Configuro VPLS en equipo Frontera" + "\r\n";
                richTextresult.Text = richTextresult.Text + "\r\n";
                richTextresult.Text = richTextresult.Text + "telnet " + IP + "\r\n";
                richTextresult.Text = richTextresult.Text + "\r\n";
                richTextresult.Text = richTextresult.Text + "configure service sdp " + SDPFront + " mpls create" + "\r\n";
                richTextresult.Text = richTextresult.Text + "description "+DESC +"\r\n";
                richTextresult.Text = richTextresult.Text + "far-end "+ REM + "\r\n";
                richTextresult.Text = richTextresult.Text + "ldp"+"\r\n";
                richTextresult.Text = richTextresult.Text + "keep-alive" + "\r\n";
                richTextresult.Text = richTextresult.Text + "shutdown " + "\r\n";
                richTextresult.Text = richTextresult.Text + "exit" + "\r\n";
                richTextresult.Text = richTextresult.Text + "no shutdown " + "\r\n";
                richTextresult.Text = richTextresult.Text + "exit" + "\r\n";
                richTextresult.Text = richTextresult.Text + "\r\n";
                richTextresult.Text = richTextresult.Text + "configure service vpls " + VPLS + "\r\n";
                richTextresult.Text = richTextresult.Text + "spoke-sdp "+SDPFront+":"+ PIPECell + " split-horizon-group \"sc\" create" + "\r\n";
                richTextresult.Text = richTextresult.Text + "exit";
                richTextresult.Text = richTextresult.Text + "\r\n";
                richTextresult.Text = richTextresult.Text + "Configuro EPIPE en equipo Destino" + "\r\n";
                richTextresult.Text = richTextresult.Text + "\r\n";
                richTextresult.Text = richTextresult.Text + "telnet " + REM + "\r\n";
                richTextresult.Text = richTextresult.Text + "\r\n";
                richTextresult.Text = richTextresult.Text + "configure service sdp " + SDPRem + " mpls create" + "\r\n";
                richTextresult.Text = richTextresult.Text + "description " + DESC + "\r\n";
                richTextresult.Text = richTextresult.Text + "far-end " + IP + "\r\n";
                richTextresult.Text = richTextresult.Text + "ldp" + "\r\n";
                richTextresult.Text = richTextresult.Text + "keep-alive" + "\r\n";
                richTextresult.Text = richTextresult.Text + "shutdown " + "\r\n";
                richTextresult.Text = richTextresult.Text + "exit" + "\r\n";
                richTextresult.Text = richTextresult.Text + "no shutdown " + "\r\n";
                richTextresult.Text = richTextresult.Text + "exit" + "\r\n";
                richTextresult.Text = richTextresult.Text + "\r\n";
                richTextresult.Text = richTextresult.Text + "configure service epipe " +PIPECell+ " customer XX create" + "\r\n";
                richTextresult.Text = richTextresult.Text + "description " + DESC + "\r\n";
                richTextresult.Text = richTextresult.Text + "sap " + PORT+":"+ TAG +"create"+"\r\n";
                richTextresult.Text = richTextresult.Text + "exit"+"\r\n";
                richTextresult.Text = richTextresult.Text + "spoke-sdp "+SDPRem+":" + PIPECell +" create"+"\r\n";
                richTextresult.Text = richTextresult.Text + "exit" + "\r\n";
                richTextresult.Text = richTextresult.Text + "no shutdown" + "\r\n";
                richTextresult.Text = richTextresult.Text + "exit" + "\r\n";
                richTextresult.Text = richTextresult.Text + "\r\n";
                richTextresult.Text = richTextresult.Text + "Para verificar" + "\r\n";
                richTextresult.Text = richTextresult.Text + "\r\n";
                richTextresult.Text = richTextresult.Text + "telnet " + IP + "\r\n";
                richTextresult.Text = richTextresult.Text + "show service id " + VPLS + " fdb detail" + "\r\n";
            }
        }
        private void button2_Click(object sender, EventArgs e) // Boton Guardar
        {
            DateTime time = DateTime.Now;
            string format = "d MMM yyyy";
            // Text from the rich textbox rtfMain
            string str = richTextresult.Text;
            // Create a new SaveFileDialog object
            using (SaveFileDialog dlgSave = new SaveFileDialog())
                try
                {
                    dlgSave.Filter = "Text Files (*.txt)|*.txt"; // Available file extensions
                    dlgSave.Title = "Save"; // SaveFileDialog title
                    dlgSave.DefaultExt = "txt"; // SaveFileDialog Ext
                    dlgSave.FileName = textDesc.Text + time.ToString(format) + "_.TXT";
                    if (dlgSave.ShowDialog() == DialogResult.OK && dlgSave.FileName.Length > 0) // Show SaveFileDialog
                    {
                        StreamWriter sw = new StreamWriter(dlgSave.FileName);
                        for (int i = 0; i < richTextresult.Lines.Length; i++)
                        {
                            sw.WriteLine(richTextresult.Lines[i]);
                        }
                        sw.Flush();  //sw.Write(str);
                        sw.Close();
                    }
                }
                catch (Exception errorMsg)
                {
                    MessageBox.Show(errorMsg.Message);
                }
        }

        private void button3_Click(object sender, EventArgs e) // botn reset
        {
            if (checkMeth.Checked == true)
            {
                comboFront.Text = "";
                textVlan.Text = "";
                textDest.Text = "";
                richTextresult.Text = "";
                textDesc.Text = "";
            }
            else
            {
                comboFront.Text = "";
                textVlan.Text = "";
                textDest.Text = "";
                textDest.Text = "";
                textPort.Text = "";
                comboZona.Text = "";
                richTextresult.Text = "";
                textDesc.Text = "";
            }
        }
    }
}
