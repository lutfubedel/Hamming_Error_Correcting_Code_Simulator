using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Hamming_Error_Correcting_Code_Simülatörü
{
    public partial class Form1 : Form
    {
        // Global degiskenler
        List<TextBox> bitList = new List<TextBox>();
        string complexCode = ""; 
        string hammingsCode = "";
        double hammingCodeLenght;
        List<string> bitList1 = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form yuklendiginde bazi bilesenleri gizle
            label_hammingCode.Visible = false;
            label_gonderilen_veri.Visible = false;
            panel_result1.Visible = false;
            panel_result2.Visible = false;
            panel2.Visible = false;
            button_reset.Visible = false;
        }

        private void button_bit_sayisi_Click(object sender, EventArgs e)
        {
            // Bit sayisini al ve dogrula
            int bitSayisi = Convert.ToInt32(textBox_bit_sayisi.Text);

            // Bazi panelleri ve dügmeleri gizle
            panel2.Visible = false;
            panel_result1.Visible = false;
            panel_result2.Visible = false;
            button_reset.Visible = false;

            textBox_veri.Text = "";
            label_info1.Text = "";
            label_info2.Text = "";

            // Gecerli bit sayisi kontrolu
            if (bitSayisi == 4 || bitSayisi == 8 || bitSayisi == 16)
            {
                panel_veri.Visible = true;
                label_error1.Visible = false;
                textBox_veri.MaxLength = bitSayisi;
            }
            else
            {
                panel_veri.Visible = false;
                ShowErrorMessage(label_error1, "!!!Bit sayısını 4, 8 veya 16 olacak şekilde güncelleyiniz!!!");
            }
        }

        private void button_hamming_hesapla_Click(object sender, EventArgs e)
        {
            // Hamming kodu hesapla düğmesine tıklanınca
            bool isContinue = false;
            int checkedBit = 0;
            label_info1.Text = "";
            label_hammingCode.Text = "";
            label_gonderilen_veri.Text = "";
            label_info2.Text = "";

            panel_result1.Visible = true;
            panel_result2.Visible = false;
            button_reset.Visible = false;

            // Veri uzunluğunu kontrol et
            if (textBox_veri.Text.Length == Convert.ToInt32(textBox_bit_sayisi.Text))
            {
                label_error1.Visible = false;
                // Verinin binary olup olmadığını kontrol et
                for (int i = 0; i < textBox_veri.Text.Length; i++)
                {
                    if (textBox_veri.Text[i] == '1' || textBox_veri.Text[i] == '0')
                    {
                        checkedBit++;
                    }
                }
                if (checkedBit == textBox_veri.Text.Length)
                {
                    label_error1.Visible = false;
                    isContinue = true;
                }
                else
                {
                    panel2.Visible = false;
                    panel_result1.Visible = false;
                    ShowErrorMessage(label_error1, "!!!Lütfen verinizi binary olarak tanımlayınız!!!");
                }
            }
            else
            {
                panel2.Visible = false;
                panel_result1.Visible = false;
                ShowErrorMessage(label_error1, "!!!Lütfen verinizin bit sayısını kontrol ediniz!!!");
            }

            // Hamming kodu uzunluğunu hesapla
            hammingCodeLenght = Math.Log(textBox_veri.Text.Length, 2) + 1; 

            if (isContinue)
            {
                int index = 3;
                label_hammingCode.Text = "";
                label_info1.Text = "";
                hammingsCode = "";
                bitList1.Clear();

                // Veriyi tersten al ve hamming kodu hesapla
                for (int i = textBox_veri.Text.Length - 1; i >= 0; i--)
                {
                    if (textBox_veri.Text[i].Equals('1'))
                    {
                        if (IsPowerOfTwo(index)) { index++; }

                        string value = Convert.ToString(index, 2).PadLeft(Convert.ToInt32(hammingCodeLenght), '0');
                        bitList1.Add(value);
                        index++;
                    }
                    else
                    {
                        if (IsPowerOfTwo(index)) { index++; }
                        index++;
                    }
                }

                // Hamming kodunu hesapla
                for (int i = 0; i < hammingCodeLenght; i++)
                {
                    int control = 0;
                    for (int j = 0; j < bitList1.Count; j++)
                    {
                        if (bitList1[j][i] == '1')
                        {
                            control++;
                        }
                    }
                    hammingsCode += (control % 2 == 1) ? "1" : "0";
                }

                // Bilgileri label'a yazdır
                label_info1.Text = "";
                for (int i = 0; i < bitList1.Count; i++)
                {
                    label_info1.Text += "              " + bitList1[i] + "\n";
                }

                label_info1.Text += "XOR____________\n";
                label_info1.Text += "              " + hammingsCode + "\n";

                label_hammingCode.Visible = true;
                label_hammingCode.Text = "Hamming Code : " + hammingsCode;

                // Gönderilen veri ve Hamming kodu birleşimini hesapla
                int veri_index = 0;
                int hammingsCode_index = Convert.ToInt32(hammingCodeLenght) - 1;
                int tempHammingLenght = 0;

                complexCode = "";

                for (int i = textBox_veri.Text.Length + Convert.ToInt32(hammingCodeLenght); i > 0; i--)
                {
                    if (i == Math.Pow(2, hammingsCode_index))
                    {
                        complexCode += hammingsCode[tempHammingLenght];
                        hammingsCode_index--;
                        tempHammingLenght++;
                    }
                    else
                    {
                        complexCode += textBox_veri.Text[veri_index];
                        veri_index++;
                    }
                }

                label_gonderilen_veri.Visible = true;
                label_gonderilen_veri.Text = "Depolanan Veri : " + complexCode;

                panel2.Visible = true;

                // Bitleri formdaki TextBox'lara yerleştir
                for (int i = 1; i <= 21; i++)
                {
                    string textBoxName = "textBox_veri_bit" + i;

                    Control[] controls = groupBox2.Controls.Find(textBoxName, true);

                    if (controls.Length > 0 && controls[0] is TextBox textBox)
                    {
                        bitList.Add(textBox);
                    }
                }

                for (int i = 0; i < complexCode.Length; i++)
                {
                    bitList[i].Visible = true;
                    bitList[i].Text = complexCode[i].ToString();
                }
            }
        }

        private void button_onayla_Click(object sender, EventArgs e)
        {
            // Veriyi onayla düğmesine tıklanınca
            string complexCodeNew = "";
            string sendromWord = "";
            int control = 0;
            int checkBit = 0;
            List<string> bitList2 = new List<string>();

            bitList2.AddRange(bitList1);
            label_error2.Visible = false;
            panel_result2.Visible = true;
            button_reset.Visible = true;

            // Verideki hata sayısını hesaplar
            for (int i = 0; i < complexCode.Length; i++)
            {
                if (complexCode[i].ToString() != bitList[i].Text)
                {
                    string changedBit = Convert.ToString((complexCode.Length - i), 2).PadLeft(Convert.ToInt32(hammingCodeLenght), '0');
                    bitList2.Add(changedBit);

                    control++;
                }
            }

            if (control != 1)
            {
                ShowErrorMessage(label_error2, control == 0 ? "!!!Herhangi bir hata bulunamadı!!!" : "!!!Sadece bir bit değiştirebilirsiniz!!!");

                panel_result2.Visible = false;
                button_reset.Visible = false;
                label_info2.Text = "";
                
            }
            else
            {
                // Yeni veriyi oluştur
                for (int i = 0; i < complexCode.Length; i++)
                {
                    complexCodeNew += bitList[i].Text;
                }

                // Yeni veriyi kontrol et
                for (int i = 0; i < complexCodeNew.Length; i++)
                {
                    if (complexCodeNew[i] == '1' || complexCodeNew[i] == '0')
                    {
                        checkBit++;
                    }
                }

                if (checkBit == complexCodeNew.Length)
                {
                    label_error2.Text = checkBit.ToString();
                    bitList2.Add(hammingsCode);

                    // Sendrom kelimesini hesapla
                    for (int i = 0; i < hammingCodeLenght; i++)
                    {
                        int control2 = 0;
                        for (int j = 0; j < bitList2.Count; j++)
                        {
                            if (bitList2[j][i] == '1')
                            {
                                control2++;
                            }
                        }
                        sendromWord += (control2 % 2 == 1) ? "1" : "0";
                    }

                    // Bilgileri label'a yazdır
                    label_info2.Text = "";
                    for (int i = 0; i < bitList2.Count; i++)
                    {
                        label_info2.Text += "              " + bitList2[i] + "\n";
                    }

                    label_info2.Text += "XOR____________\n";
                    label_info2.Text += "              " + sendromWord + "\n";

                    label_sendrom.Text = "Sendrom Kelimesi : " + sendromWord;
                    label_veri_new.Text = "Hatalı Veri : " + complexCodeNew;
                    label_mistake.Text = "Hata İndisi : " + Convert.ToInt32(sendromWord, 2).ToString();
                }
                else
                {
                    label_error2.Visible = true;
                    label_info2.Text = "";
                    panel_result2.Visible = false;
                    button_reset.Visible = false;
                    ShowErrorMessage(label_error2, "!!!Lütfen verinizi binary olarak tanımlayınız!!!");
                }
            }
        }

        private void ShowErrorMessage(Label label_error, string mesaj)
        {
            // Hata mesajını göster
            label_error.Visible = true;
            label_error.Text = mesaj;
        }

        private bool IsPowerOfTwo(int sayi)
        {
            // İkinin kuvveti olup olmadığını kontrol et
            return (sayi & (sayi - 1)) == 0;
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            // Uygulamayı yeniden başlat
            Application.Restart();
        }

        private void button_Youtube_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/lutfubedel/Hamming_Error_Correcting_Code_Simulator";
            Process.Start(url);
        }

        private void button_Github_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/lutfubedel/Hamming_Error_Correcting_Code_Simulator";
            Process.Start(url);
        }
    }
}
