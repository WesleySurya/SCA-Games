using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Hangman
{
    public delegate void CheckLetter(string letter);
    public partial class GameForm : Form
    {
        const int MaksKesempatan = 5;
        //coding dimana jika setiap kali kata berhasil yang ditebak
        event CheckLetter ltr;

        string input;
        string KataSalah = "";

        //untuk menemukan kata
        string KataDitemukan = "";

        //menunjukkan kata yang telah didapat
        string KataDitampilkan = "";

        //Array karakter kata
        char[] Katauntukmenemukanarray;
        int[] Katauntukmenemukanposisikalimat;
        bool JikaKalimatDitemukan = false;

        //mengrandom kata dari word list
        Random rndm = new Random(0);

        //mengumpulkan kata
        List<string> Daftarkata = new List<string>();

        //Daftar posisi indeks untuk melacak kata mana yang sudah dimainkan
        List<int> Indekskatasudahdimainkan = new List<int>();

        int Hitungkatasalah = 0;

        public GameForm()
        {
            InitializeComponent();
            this.ltr += new CheckLetter(Form1_ltr);

            //Membuat kata baru
            BuatDaftarKata();

            //Memulai game baru
            RestartTheGame();
        }
        private void BuatDaftarKata()
        {
            //daftar kata yang di tebak ada 10
            Daftarkata.Add("Jakarta");
            Daftarkata.Add("Tambang");
            Daftarkata.Add("Sekolah");
            Daftarkata.Add("Barack Obama");
            Daftarkata.Add("Paris");
            Daftarkata.Add("Zoo");
            Daftarkata.Add("Mahasiswa");
            Daftarkata.Add("Musik");
            Daftarkata.Add("Cuaca");
            Daftarkata.Add("Baju");
        }
        private string DapatkanKataDariDaftar()
        {
            bool Katabaru = false;
            //Default word
            string temp = "HANGMAN";

            try
            {
                while (Katabaru == false)
                {
                    //Untuk mendapatkan kata secara acak dari kumpulan kata
                    int index = rndm.Next();

                    index = index % Daftarkata.Count;

                    if (!Indekskatasudahdimainkan.Exists(e => e == index))
                    {
                        temp = Daftarkata[index];
                        Indekskatasudahdimainkan.Add(index);
                        Katabaru = true;
                        break;
                    }
                    else
                    {
                        Katabaru = false;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            return temp.ToUpper();
        }
        private void RestartTheGame()
        {
            try
            {
                KataDitemukan = DapatkanKataDariDaftar();
                KataDitemukan = KataDitemukan.ToUpper();
                Katauntukmenemukanarray = KataDitemukan.ToCharArray();

                Katauntukmenemukanposisikalimat = new int[KataDitemukan.Length];

                //Resetting other counters and variables
                input = "";
                KataDitampilkan = "";
                for (int i = 0; i < KataDitemukan.Length; i++)
                {
                    KataDitampilkan += "-";
                }

                KataSalah = "";
                Hitungkatasalah = 0;

                label_Word.Text = KataDitampilkan.ToUpper();
                label_KataSalah.Text = KataSalah;
                label_MissedLtrCnt.Text = MaksKesempatan.ToString();
                Application.DoEvents();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void Form1_ltr(string currentInputletter)
        {
            try
            {
                if (Hitungkatasalah < MaksKesempatan)
                {

                    JikaKalimatDitemukan = false;
                    for (int i = 0; i < Katauntukmenemukanarray.Length; i++)
                    {
                        if (currentInputletter[0] == Katauntukmenemukanarray[i])
                        {
                            Katauntukmenemukanposisikalimat[i] = 1;
                            JikaKalimatDitemukan = true;
                        }
                    }

                    if (JikaKalimatDitemukan == false)
                    {
                        KataSalah += currentInputletter + ", ";
                        Hitungkatasalah++;
                        label_MissedLtrCnt.Text = (MaksKesempatan - Hitungkatasalah).ToString();
                    }

                    KataDitampilkan = "";
                    for (int i = 0; i < Katauntukmenemukanarray.Length; i++)
                    {
                        if (Katauntukmenemukanposisikalimat[i] == 1)
                        {
                            KataDitampilkan += Katauntukmenemukanarray[i].ToString();
                        }
                        else
                        {
                            KataDitampilkan += "-";
                        }
                    }

                    label_Word.Text = KataDitampilkan.ToUpper();
                    label_KataSalah.Text = KataSalah;

                    if (Katauntukmenemukanposisikalimat.All(e => e == 1))
                    {
                        MessageBox.Show("Selamat Anda Menang.", "Hasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RestartTheGame();
                    }
                }
                else
                {
                    MessageBox.Show("Alah Anda Gagal" + "\nJawaban yang benar itu adalah: " + KataDitemukan, "Hasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RestartTheGame();
                }
                Application.DoEvents();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        //membuat alphabet
        private void button_A_Click(object sender, EventArgs e)
        {
            input = "A";

            ltr(input);
        }

        private void button_B_Click(object sender, EventArgs e)
        {
            input = "B";

            ltr(input);
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            input = "C";

            ltr(input);
        }

        private void button_D_Click(object sender, EventArgs e)
        {
            input = "D";

            ltr(input);
        }

        private void button_E_Click(object sender, EventArgs e)
        {
            input = "E";

            ltr(input);
        }
        private void button_F_Click(object sender, EventArgs e)
        {
            input = "F";

            ltr(input);
        }

        private void button_G_Click(object sender, EventArgs e)
        {
            input = "G";

            ltr(input);
        }

        private void button_H_Click(object sender, EventArgs e)
        {
            input = "H";

            ltr(input);
        }

        private void button_I_Click(object sender, EventArgs e)
        {
            input = "I";

            ltr(input);
        }

        private void button_J_Click(object sender, EventArgs e)
        {
            input = "J";

            ltr(input);
        }

        private void button_K_Click(object sender, EventArgs e)
        {
            input = "K";

            ltr(input);
        }

        private void button_L_Click(object sender, EventArgs e)
        {
            input = "L";

            ltr(input);
        }

        private void button_M_Click(object sender, EventArgs e)
        {
            input = "M";

            ltr(input);
        }
        private void button_N_Click(object sender, EventArgs e)
        {
            input = "N";

            ltr(input);
        }

        private void button_O_Click(object sender, EventArgs e)
        {
            input = "O";

            ltr(input);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            this.Hide();
            form.Show();
        }
    }
}
