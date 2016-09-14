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
    public partial class CAC : Form
    {
        public CAC()
        {
            InitializeComponent();
        }
        private void CAC_Load(object sender, EventArgs e)
        {
            comboFrontPais.Items.Add("Argentina");
            comboFrontPais.Items.Add("Paraguay");

            groupBox2.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;

        }
        private void comboFrontPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboFrontPais.SelectedIndex)
            {
                case 0:
                    {
                        comboFront1.Items.Clear();
                        comboFront1.Items.Add("SF898_COR70_SAR18-10.2.21.198-2");
                        comboFront1.Items.Add("C2470_OLS70_SR7-10.2.20.209-1");
                        comboFront1.Items.Add("CF296_GRY_SR7-10.2.20.210-1");
                        comboFront1.Items.Add("CO895_OFC70_SAR18-10.2.21.186-2");
                        comboFront1.Items.Add("ME298_MTS70_SAR18-10.2.21.199-3");
                        comboFront1.Items.Add("C1900_MS270_SR7-10.2.20.10-1");
                        combozona1.Items.Clear();
                        combozona1.Items.Add("1-Amba");
                        combozona1.Items.Add("2-Norte");
                        combozona1.Items.Add("3-Sur");
                        combozona1.Items.Add("4-Oeste");
                        break;
                    }
                    {
                        comboFront2.Items.Clear();
                        comboFront2.Items.Add("SF898_COR70_SAR18-10.2.21.198-2");
                        comboFront2.Items.Add("C2470_OLS70_SR7-10.2.20.209-1");
                        comboFront2.Items.Add("CF296_GRY_SR7-10.2.20.210-1");
                        comboFront2.Items.Add("CO895_OFC70_SAR18-10.2.21.186-2");
                        comboFront2.Items.Add("ME298_MTS70_SAR18-10.2.21.199-3");
                        comboFront2.Items.Add("C1900_MS270_SR7-10.2.20.10-1");


                        break;
                    }
                case 1:
                    {
                        comboFront1.Items.Clear();
                        comboFront1.Items.Add("AS023_DUAL_SR7-10.2.23.130-1");
                        comboFront1.Items.Add("AS023_KRC70_SR7-10.2.23.129-1");
                        comboFront1.Items.Add("AP030_MSC70_SR7-10.2.23.225-1");
                        comboFront1.Items.Add("AP030_MSC70_SR7_DUAL-10.2.72.125-1");

                        comboFront2.Items.Clear();
                        comboFront2.Items.Add("AS023_DUAL_SR7-10.2.23.130-1");
                        comboFront2.Items.Add("AS023_KRC70_SR7-10.2.23.129-1");
                        comboFront2.Items.Add("AP030_MSC70_SR7-10.2.23.225-1");
                        comboFront2.Items.Add("AP030_MSC70_SR7_DUAL-10.2.72.125-1");
                        break;
                    }
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                groupBox2.Visible = true;
            else
                groupBox2.Visible = false;
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                groupBox4.Visible = true;
                textBox5.Visible = false;
                textwan1.Visible = true;
                textwan2.Visible = true;
                textwan3.Visible = true;
                textwan4.Visible = true;
                label8.Visible = false;
                label16.Visible = true;
                label17.Visible = true;
                combozona1.Visible = false;
            }
            else
            {
                groupBox4.Visible = false;
                textBox5.Visible = true;
                textwan1.Visible = false;
                textwan2.Visible = false;
                textwan3.Visible = false;
                textwan4.Visible = false;
                label8.Visible = true;
                label16.Visible = false;
                label17.Visible = false;
                combozona1.Visible = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                groupBox5.Visible = true;
            else
                groupBox5.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
         string Desc = textDesc.Text;                        
         string VLAN1 = VlanFront1.Text;            
         string VLAN2 = VlanFront2.Text;
         string IPdest = textBox4.Text;

        string IPor1 = comboFront1.SelectedItem.ToString().Split('-')[1];
        string IPor2 = comboFront2.SelectedItem.ToString().Split('-')[1];
        string UOO1 =IPor1.Split('.')[3];
        string UOO2 =IPor2.Split('.')[3];
        string UOD =IPdest.Split('.')[3];
        string Zonadst= combozona1.SelectedItem.ToString();
        
            
        // ARMO LOS SDP
        //-------------
        string zonaOR1 = comboFront1.SelectedItem.ToString().Split('-')[2];
        string zonaOR2 = comboFront2.SelectedItem.ToString().Split('-')[2];
        string SDPOR1 = (zonaOR1 + UOD + Zonadst);  // SDP primer frontera hacia el SAR-8
        string SDPOR2 = (zonaOR2 + UOD + Zonadst);  // SDP segunda frontera hacia el SAR-8       
        string SDPDS1 =(Zonadst + UOO1 + zonaOR1);  // SDP desde el SAR-8 hacia la primer frontera
        string SDPDS2 = (Zonadst + UOO2 + zonaOR2); // SDP desde el SAR-8 hacia la segunda frontera

        }
        private void combozona1_SelectedIndexChanged(object sender, EventArgs e)
        {                        
        }
    }
}
