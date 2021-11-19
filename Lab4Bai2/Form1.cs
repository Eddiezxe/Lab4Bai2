using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;


namespace Lab4Bai2
{
    public partial class Form1 : Form
    {
        static string message = "";
        static bool check = true; // dùng để điều hướng button hash, nếu true thì thực hiện hash và ngược lại
        public Form1()
        {
            InitializeComponent();
        }
        public bool isHexString(string test)
        {
            // For C-style hex notation (0xFF) you can use @"\A\b(0[xX])?[0-9a-fA-F]+\b\Z"
            return System.Text.RegularExpressions.Regex.IsMatch(test, @"\A\b[0-9a-fA-F]+\b\Z");
        }
        void boxClear()
        {
            textBoxMD5.Clear();
            textBoxSHA1.Clear();
            textBoxSHA256.Clear();
            textBoxSHA384.Clear();
            textBoxSHA512.Clear();
        }
        void takeInput()
        {
            message = textBoxInput.Text.ToString();
            if (message == "")
            {
                MessageBox.Show("Không có dữ liệu, hash khoảng trắng", "Thông báo");
            }
            else
            {
                string dataType = comboBoxType.Text;
                if (dataType == "")
                {
                    MessageBox.Show("Vui lòng chọn kiểu dữ liệu", "Thông báo");
                    check = false;
                }
                else
                {
                    if (dataType == "Hex")
                    {
                            if (isHexString(message) == false)
                            {
                                MessageBox.Show("Hex string sai định dạng", "Lỗi");
                                check = false;
                            }
                            else
                            {
                                check = true;
                            }                                   
                    }
                    else
                    {
                        message = textBoxInput.Text.ToString();
                        check = true;
                    }
                }
            }

        }
        private void buttonInputFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            try
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                string pathName = @ofd.FileName.ToString(); // lấy đường dẫn
                string extension = Path.GetExtension(pathName).ToString();  // lấy extension của file
                if(extension != ".bin")
                {
                    MessageBox.Show("Chỉ nhận file .bin", "Lỗi");
                    boxClear();
                } 
                else
                {
                    labelFilePath.Text = pathName;
                    StreamReader sr = new StreamReader(fs);
                    message = sr.ReadToEnd();
                }    
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Lỗi");
            }
            
            
        }
        void hashMD5()
        {
            MD5 mh = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(message);

            byte[] hash = mh.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            textBoxMD5.Text = sb.ToString();
        }
        void hashSHA1()
        {
            SHA1 sha1 = SHA1.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(message);

            byte[] hash = sha1.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            textBoxSHA1.Text = sb.ToString();
        }
        void hashSHA256()
        {
            SHA256 sha256 = SHA256.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(message);

            byte[] hash = sha256.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            textBoxSHA256.Text = sb.ToString();
        }
        void hashSHA384()
        {
            SHA384 sha384 = SHA384.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(message);

            byte[] hash = sha384.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            textBoxSHA384.Text = sb.ToString();
        }
        void hashSHA512()
        {
            SHA512 sha512 = SHA512.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(message);

            byte[] hash = sha512.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            textBoxSHA512.Text = sb.ToString();
        }


        private void buttonHash_Click(object sender, EventArgs e)
        {
            if(message != "") // chọn bằng file
            {
                hashMD5();
                hashSHA1();
                hashSHA256();
                hashSHA384();
                hashSHA512();
            }
            else // chọn từ các textBox
            {
                takeInput();
                if (check == true)
                {
                    hashMD5();
                    hashSHA1();
                    hashSHA256();
                    hashSHA384();
                    hashSHA512();
                }
                else
                {
                    //MessageBox.Show("Có gì đó sai sai", "Lỗi");
                    boxClear();
                }
            }
            message = "";
               
            
        }

        private void buttonCopyMD5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxMD5.Text);
        }

        private void buttonCopySHA1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxSHA1.Text);
        }
        private void buttonSHA256_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxSHA256.Text);
        }

        private void buttonSHA384_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxSHA384.Text);
        }

        private void buttonSHA512_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxSHA512.Text);
        }

        
    }
}