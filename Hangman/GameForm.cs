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
        const int MAX_NUMBER_OF_CHANCE = 5;
        //coding dimana jika setiap kali kata berhasil yang ditebak
        event CheckLetter ChkLtr;

        string input;
        string KataSalah = "";

        //untuk menemukan kata
        string WordToFind = "";

        //menunjukkan kata yang telah didapat
        string WordToDisplay = "";

        //Array karakter kata
        char[] WordToFindArray;
        int[] WordToFindLettersPosition;
        bool IsLetterFound = false;

        //mengrandom kata dari word list
        Random rndm = new Random(0);

        //mengumpulkan kata
        List<string> WordList = new List<string>();

        //Daftar posisi indeks untuk melacak kata mana yang sudah dimainkan
        List<int> WordsIndexAlreadyPlayed = new List<int>();

        int KataSalahCount = 0;

        public GameForm()
        {
            InitializeComponent();
            this.ChkLtr += new CheckLetter(Form1_ChkLtr);

            //Membuat kata baru
            CreateWordList();

            //Memulai game baru
            RestartTheGame();
        }
        private void CreateWordList()
        {
            //daftar kata yang di tebak ada 10
            WordList.Add("Jakarta");
            WordList.Add("Tambang");
            WordList.Add("Sekolah");
            WordList.Add("Barack Obama");
            WordList.Add("Paris");
            WordList.Add("Zoo");
            WordList.Add("Mahasiswa");
            WordList.Add("Musik");
            WordList.Add("Cuaca");
            WordList.Add("Baju");
        }
        private void RestartTheGame()
        {

        }
    }
}
