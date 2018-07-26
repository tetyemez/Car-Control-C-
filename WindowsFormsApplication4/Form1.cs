using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
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
            foreach (string portlar in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(portlar);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = 9600;
                serialPort1.Open();
                
            }
            catch (Exception)
            {
            }

            if (serialPort1.IsOpen)
            {
                groupBox1.Visible = true;
                MessageBox.Show("Connected");
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort1.Close();
        }
        byte[] gidenVeri;

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string kontrol = serialPort1.ReadExisting().ToString();
            switch (kontrol) {
                case "a": MessageBox.Show("Önde engel var", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
                case "b": MessageBox.Show("Sağda engel var", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
                case "c": MessageBox.Show("Solda engel var", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
          
            }
            /*
            if (kontrol == "a")
            { MessageBox.Show("Önde engel var","Uyarı!", MessageBoxButtons.OK,MessageBoxIcon.Warning); }
            else if (kontrol == "b")
            { MessageBox.Show("Sağda engel var", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else if (kontrol == "c")
            { MessageBox.Show("Solda engel var", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else if (kontrol == "d")
            { MessageBox.Show("Önde ve sağda engel var", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else if (kontrol == "e")
            { MessageBox.Show("Önde ve solda engel var", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else if (kontrol == "f")
            { MessageBox.Show("Sağda ve solda engel var", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else if (kontrol == "g")
            { MessageBox.Show("Önde,sağda ve solda engel var", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }*/
        }

       

        private void ileri_MouseUp(object sender, MouseEventArgs e)
        {
                gidenVeri = BitConverter.GetBytes(83);
                serialPort1.Write(gidenVeri, 0, 1);
        }
        private void ileri_MouseDown(object sender, MouseEventArgs e)
        {            
                gidenVeri = BitConverter.GetBytes(70);
                serialPort1.Write(gidenVeri, 0, 1);
        }

        private void Sol_MouseDown(object sender, MouseEventArgs e)
        {
            gidenVeri = BitConverter.GetBytes(76);
            serialPort1.Write(gidenVeri, 0, 1);
        }

        private void Sol_MouseUp(object sender, MouseEventArgs e)
        {
            gidenVeri = BitConverter.GetBytes(83);
            serialPort1.Write(gidenVeri, 0, 1);
        }

        private void sag_MouseDown(object sender, MouseEventArgs e)
        {
            gidenVeri = BitConverter.GetBytes(82);
            serialPort1.Write(gidenVeri, 0, 1);
        }

        private void sag_MouseUp(object sender, MouseEventArgs e)
        {
            gidenVeri = BitConverter.GetBytes(83);
            serialPort1.Write(gidenVeri, 0, 1);
        }

        private void geri_MouseDown(object sender, MouseEventArgs e)
        {
            gidenVeri = BitConverter.GetBytes(90);
            serialPort1.Write(gidenVeri, 0, 1);
        }

        private void geri_MouseUp(object sender, MouseEventArgs e)
        {
            gidenVeri = BitConverter.GetBytes(83);
            serialPort1.Write(gidenVeri, 0, 1);
        }

       
        private void dc_btn_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            if (!(serialPort1.IsOpen))
            {
                groupBox1.Visible = true;
                MessageBox.Show("Disconnected");
            }
        }    
       
    }
}
