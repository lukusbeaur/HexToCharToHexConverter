using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace Calibration_Editor
{
    public partial class Form1 : Form
    {
        public static List<String> HexValue = new List<string>();
        public static List<string> HexAddress = new List<string>();
        private static string SerialNum { get; set; }
        private static string NewSerialNum { get; set; }
        private static string Path { get; set; }
        public static string GetFile { get; set; }
        public static char asciirep;
        public static bool find = false;
        public static bool Block { get; set; }
        public static string Type { get; set; }
        public static void Hextoarray(string path)
        {
            var line = File.ReadAllLines(path);
            var Lines = new List<string>(line);

            int count = Lines.Count();
            foreach (var i in Lines)
            {
                HexAddress.Add(i.Substring(0, i.Length - 2));
                if (i.Substring(i.Length - 2).Contains(' '))
                {
                    HexValue.Add(i.Substring(i.Length - 1));
                }
                else
                {
                    HexValue.Add(i.Substring(i.Length - 2));
                }
            }
            Lines.Clear();
        }
        public static void FindAndReplaced(string serialnum, string newSerialnum)
        {
            int count = HexValue.Count;
            List<string> sernum = new List<string>();
            foreach (char x in serialnum)
            {
                sernum.Add(x.ToString());
            }
            List<string> curser = new List<string>();
            foreach (char x in NewSerialNum)
            {
                curser.Add(x.ToString());
            }
             int Length = sernum.Count();
            for (int i = 0; i < count - Length; i++)
            {
                bool check = true;
                for (int x = 0; x <= Length-1; x++)
                {
                    if (Asciirepr(HexValue[i + x]).ToString() == sernum[x] && check == true)
                    {                      
                        check = true;
                    }
                    else
                    {
                        check = false;
                        find = false;
                    }

                }

                // if (Asciirepr(HexValue[i]) == SerialNum[0]
                //  && Asciirepr(HexValue[i + 1]) == SerialNum[1]
                // && Asciirepr(HexValue[i + 2]) == SerialNum[2]
                //&& Asciirepr(HexValue[i + 3]) == SerialNum[3]
                //&& Asciirepr(HexValue[i + 4]) == SerialNum[4])
                //{
                if (check == true)
                {
                    for (int y = 0; y <= Length - 1; y++)
                    {
                        HexValue[i + y] = Hexrepr(Convert.ToChar(sernum[y]));
                    }
                    find = true;
                }
            }
        }
        
        public static char Asciirepr(string x)
        {
            if (x != null)
            {
                int hexrep = int.Parse(x, NumberStyles.AllowHexSpecifier);
                asciirep = (char)hexrep;
            }
            return asciirep;


        }
        public static string Hexrepr(char x)
        {
            int asciivalue = Convert.ToInt32(x);
            string asciiVal = string.Format("{0:X}", asciivalue);
            return asciiVal;
        }
        static void WriteFile(string path)
        {            
            int count = HexValue.Count();
            using (StreamWriter fs = new StreamWriter(path))
            {
                if (Type == "AWS")
                {
                    for (int i = 0; i < count; i++)
                    {
                        fs.WriteLine(HexAddress[i] + HexValue[i]);
                    }
                }
                if (Block == false)
                {
                    for (int i = 0; i < count; i++)
                    {
                        if (HexValue[i].Length >= 2)
                        {
                            fs.WriteLine(HexAddress[i] + HexValue[i]);
                            fs.AutoFlush = true;

                        }
                        else
                        {
                            fs.WriteLine(string.Format(HexAddress[i] + " " + HexValue[i] ));
                            fs.AutoFlush = true;

                        }
                    }
                }
                else if (Block == true)
                {
                    for (int i = 0; i < count; i++)
                    {
                        if (HexValue[i].Length >= 2)
                        {
                            fs.Write(HexAddress[i] + HexValue[i] + (char)10);
                            fs.AutoFlush = true;

                        }
                        else
                        {
                            fs.Write(string.Format(HexAddress[i] + " "+HexValue[i]+(char)10));
                            fs.AutoFlush = true;

                        }
                    }
                }
            }
            HexValue.Clear();
            HexAddress.Clear();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            CurSerlbl.Text = "Current Unit Type";
            NewSerlbl.Text = "New Unit Type";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SerialNumbut_CheckedChanged(object sender, EventArgs e)
        {
            CurSerlbl.Text = "Current Serial Number";
            NewSerlbl.Text = "New Serial Number";
        }

        private void ResetBut_Click(object sender, EventArgs e)
        {
            SerialNumbut.Checked = true;
            CurSertxt.Text = "";
            NewSertxt.Text = "";
            StatusTx.Text = "Status of current Event...";
            Startbut.Enabled = true;
            FileLoctxt.Text = "";
            RadTypeCombox.Text = "Select One...";
            FileLoctxt.Text = "Press Search to find the HEX file you need";


        }

        private void SearchBut_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    GetFile = openFileDialog1.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
            FileLoctxt.Text = GetFile;
        }
        public static int Length { get; set; }
        private void Startbut_Click(object sender, EventArgs e)
        {
            Type = RadTypeCombox.Text;
            if (RadTypeCombox.Text == "AWS")
            {
                NewSerialNum = NewSertxt.Text;
                SerialNum = CurSertxt.Text;
                Length = 12;
                if (UnitTypeBut.Checked == true)
                {
                    Length = 9;
                }
                else if (SerialNumbut.Checked == true)
                {
                    Length = 12;
                }
                Path = GetFile;

                bool check = false;

                if (NewSerialNum.Length == Length)
                {
                    check = true;
                }
                else
                {
                    StatusTx.Text = "Invalid Format, Are you sure you're on the right selection";
                    StatusTx.AppendText(Environment.NewLine);
                    StatusTx.AppendText("Serial Number has to be 12 CHARS, and UNIT TYPE has to be 9 chars");
                }

                if (check == true && GetFile != null)
                {
                    Hextoarray(Path);
                    FindAndReplaced(SerialNum, NewSerialNum);
                    if (find == true)
                    {
                        string pathnew = string.Format("c:/Users/Nokia_LTE/Desktop/EBID_{0}_New.txt", NewSerialNum);
                        WriteFile(pathnew);
                        StatusTx.AppendText(Environment.NewLine);
                        StatusTx.AppendText("All Done");
                    }
                    else
                    {
                        StatusTx.AppendText(Environment.NewLine);
                        StatusTx.AppendText("Did Not find Original Serial Number, Try again");
                    }

                }

            }

            if (RadTypeCombox.Text == "ASSET" || RadTypeCombox.Text == "ASSET(Block Format)")
            {
                NewSerialNum = NewSertxt.Text;
                SerialNum = CurSertxt.Text;
                int Length = 18;
                if (UnitTypeBut.Checked == true)
                {
                    Length = 10;
                }
                else if (SerialNumbut.Checked == true)
                {
                    Length = 18;
                }
                Path = GetFile;

                bool check = false;

                if (NewSerialNum.Length == Length)
                {
                    check = true;
                }
                else
                {
                    StatusTx.Text = "Invalid Format, Are you sure you're on the right selection";
                    StatusTx.AppendText(Environment.NewLine);
                    StatusTx.AppendText("Serial Number has to be 12 CHARS, and UNIT TYPE has to be 9 chars");
                }

                if (check == true && GetFile != null)
                {
                    Hextoarray(Path);
                    FindAndReplaced(SerialNum, NewSerialNum);
                    if (find == true)
                    {
                        string pathnew = "";
                        if (RadTypeCombox.Text == "ASSET(Block Format)")
                        {
                            Block = true;
                            pathnew = string.Format("c:/Users/Nokia_LTE/Desktop/EBID_{0}_New_BlockFormat.txt", NewSerialNum);
                        }
                        else { Block = false; pathnew = string.Format("c:/Users/Nokia_LTE/Desktop/EBID_{0}_New.txt", NewSerialNum); }                       
                        WriteFile(pathnew);
                        StatusTx.AppendText(Environment.NewLine);
                        StatusTx.AppendText("All Done");
                    }
                    else
                    {
                        StatusTx.AppendText(Environment.NewLine);
                        StatusTx.AppendText("Did Not find Original Serial Number, Try again");
                    }

                }
            }
            find = false; Block = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }


