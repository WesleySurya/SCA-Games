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

        int Katasalahount = 0;

        public GameForm()
        {
            InitializeComponent();
            this.ltr += new CheckLetter(Form1_ltr);

            //Membuat kata baru
            BuatListKata();

            //Memulai game baru
            RestartTheGame();
        }
        private void BuatListKata()
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
        private string GetNewWordFromPool()
        {
            bool IsNewWord = false;
            //Default word
            string temp = "HANGMAN";

            try
            {
                while (IsNewWord == false)
                {
                    //Untuk mendapatkan kata secara acak dari kumpulan kata
                    int index = rndm.Next();

                    index = index % Daftarkata.Count;

                    if (!Indekskatasudahdimainkan.Exists(e => e == index))
                    {
                        temp = Daftarkata[index];
                        Indekskatasudahdimainkan.Add(index);
                        IsNewWord = true;
                        break;
                    }
                    else
                    {
                        IsNewWord = false;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            return temp.ToUpper();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            this.Hide();
            form.Show();
        }
    }
}
