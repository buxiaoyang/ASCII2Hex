using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASCII2Hex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClearASCII_Click(object sender, EventArgs e)
        {
            this.textBoxASCII.Text = "";
        }

        private void buttonClearHex_Click(object sender, EventArgs e)
        {
            try
            {
                
                String ASCIIString = this.textBoxASCII.Text;
                StringBuilder sb = new StringBuilder();
                int StringCharCount = ASCIIString.Length;
                String UpdateString = "AT+UpDate=" + StringCharCount + "\r\n";
                sb.Append(UpdateString);
                sb.Append(ASCII2Hex(UpdateString));
                sb.Append("\r\n\r\n\r\n");
                sb.Append(ASCIIString);
                sb.Append(ASCII2Hex(ASCIIString));
                this.textBoxHex.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonASCII2Hex_Click(object sender, EventArgs e)
        {
            try
            {
                String ASCIIString = this.textBoxASCII.Text;
                this.textBoxHex.Text = ASCII2Hex(ASCIIString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private String ASCII2Hex(String ASCII)
        {
            if (ASCII.Length > 0)
            {
                byte[] data = new ASCIIEncoding().GetBytes(ASCII);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sb.AppendFormat("{0:x2} ", data[i]);
                }
                return sb.ToString();
            }
            else
            {
                return "";
            }
        }

        private void buttonHex2ASCII_Click(object sender, EventArgs e)
        {
            try
            {
                Regex regex = new Regex(@"\s+", RegexOptions.Multiline);
                String hexString = regex.Replace(this.textBoxHex.Text, " ");
                if (hexString.Trim().Length > 0)
                {
                    string[] HexStr = hexString.Trim().Split(' ');
                    byte[] data = new byte[HexStr.Length];
                    for (int i = 0; i < HexStr.Length; i++)
                    {
                        data[i] = (byte)(Convert.ToInt32(HexStr[i], 16));
                    }
                    this.textBoxASCII.Text = new ASCIIEncoding().GetString(data);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
