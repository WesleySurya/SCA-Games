
namespace Hangman
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Word = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_MissedLtrCnt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_KataSalah = new System.Windows.Forms.Label();
            this.button_Z = new System.Windows.Forms.Button();
            this.button_H = new System.Windows.Forms.Button();
            this.button_Y = new System.Windows.Forms.Button();
            this.button_D = new System.Windows.Forms.Button();
            this.button_X = new System.Windows.Forms.Button();
            this.button_W = new System.Windows.Forms.Button();
            this.button_V = new System.Windows.Forms.Button();
            this.button_U = new System.Windows.Forms.Button();
            this.button_G = new System.Windows.Forms.Button();
            this.button_I = new System.Windows.Forms.Button();
            this.button_J = new System.Windows.Forms.Button();
            this.button_L = new System.Windows.Forms.Button();
            this.button_T = new System.Windows.Forms.Button();
            this.button_S = new System.Windows.Forms.Button();
            this.button_C = new System.Windows.Forms.Button();
            this.button_P = new System.Windows.Forms.Button();
            this.button_R = new System.Windows.Forms.Button();
            this.button_Q = new System.Windows.Forms.Button();
            this.button_K = new System.Windows.Forms.Button();
            this.button_O = new System.Windows.Forms.Button();
            this.button_F = new System.Windows.Forms.Button();
            this.button_B = new System.Windows.Forms.Button();
            this.button_N = new System.Windows.Forms.Button();
            this.button_A = new System.Windows.Forms.Button();
            this.button_E = new System.Windows.Forms.Button();
            this.button_M = new System.Windows.Forms.Button();
            this.button_LoadNewWord = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label_Word);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 100);
            this.panel1.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Guess the following word";
            // 
            // label_Word
            // 
            this.label_Word.AutoSize = true;
            this.label_Word.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Word.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Word.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Word.Location = new System.Drawing.Point(102, 33);
            this.label_Word.Name = "label_Word";
            this.label_Word.Size = new System.Drawing.Size(151, 31);
            this.label_Word.TabIndex = 0;
            this.label_Word.Text = "________";
            this.label_Word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label_MissedLtrCnt);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(421, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 132);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giliran Tersisa";
            // 
            // label_MissedLtrCnt
            // 
            this.label_MissedLtrCnt.AutoSize = true;
            this.label_MissedLtrCnt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_MissedLtrCnt.Font = new System.Drawing.Font("Stencil", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MissedLtrCnt.ForeColor = System.Drawing.Color.Black;
            this.label_MissedLtrCnt.Location = new System.Drawing.Point(35, 32);
            this.label_MissedLtrCnt.Name = "label_MissedLtrCnt";
            this.label_MissedLtrCnt.Size = new System.Drawing.Size(73, 80);
            this.label_MissedLtrCnt.TabIndex = 0;
            this.label_MissedLtrCnt.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Kata yang Salah:";
            // 
            // label_KataSalah
            // 
            this.label_KataSalah.AutoSize = true;
            this.label_KataSalah.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_KataSalah.ForeColor = System.Drawing.Color.Black;
            this.label_KataSalah.Location = new System.Drawing.Point(119, 148);
            this.label_KataSalah.Name = "label_KataSalah";
            this.label_KataSalah.Size = new System.Drawing.Size(70, 25);
            this.label_KataSalah.TabIndex = 33;
            this.label_KataSalah.Text = "label1";
            // 
            // button_Z
            // 
            this.button_Z.Location = new System.Drawing.Point(245, 307);
            this.button_Z.Name = "button_Z";
            this.button_Z.Size = new System.Drawing.Size(38, 23);
            this.button_Z.TabIndex = 59;
            this.button_Z.Text = "Z";
            this.button_Z.UseVisualStyleBackColor = true;
            // 
            // button_H
            // 
            this.button_H.Location = new System.Drawing.Point(333, 249);
            this.button_H.Name = "button_H";
            this.button_H.Size = new System.Drawing.Size(38, 23);
            this.button_H.TabIndex = 38;
            this.button_H.Text = "H";
            this.button_H.UseVisualStyleBackColor = true;
            // 
            // button_Y
            // 
            this.button_Y.Location = new System.Drawing.Point(201, 307);
            this.button_Y.Name = "button_Y";
            this.button_Y.Size = new System.Drawing.Size(38, 23);
            this.button_Y.TabIndex = 58;
            this.button_Y.Text = "Y";
            this.button_Y.UseVisualStyleBackColor = true;
            // 
            // button_D
            // 
            this.button_D.Location = new System.Drawing.Point(157, 249);
            this.button_D.Name = "button_D";
            this.button_D.Size = new System.Drawing.Size(38, 23);
            this.button_D.TabIndex = 36;
            this.button_D.Text = "D";
            this.button_D.UseVisualStyleBackColor = true;
            // 
            // button_X
            // 
            this.button_X.Location = new System.Drawing.Point(157, 307);
            this.button_X.Name = "button_X";
            this.button_X.Size = new System.Drawing.Size(38, 23);
            this.button_X.TabIndex = 54;
            this.button_X.Text = "X";
            this.button_X.UseVisualStyleBackColor = true;
            // 
            // button_W
            // 
            this.button_W.Location = new System.Drawing.Point(113, 307);
            this.button_W.Name = "button_W";
            this.button_W.Size = new System.Drawing.Size(38, 23);
            this.button_W.TabIndex = 55;
            this.button_W.Text = "W";
            this.button_W.UseVisualStyleBackColor = true;
            // 
            // button_V
            // 
            this.button_V.Location = new System.Drawing.Point(69, 307);
            this.button_V.Name = "button_V";
            this.button_V.Size = new System.Drawing.Size(38, 23);
            this.button_V.TabIndex = 56;
            this.button_V.Text = "V";
            this.button_V.UseVisualStyleBackColor = true;
            // 
            // button_U
            // 
            this.button_U.Location = new System.Drawing.Point(20, 307);
            this.button_U.Name = "button_U";
            this.button_U.Size = new System.Drawing.Size(38, 23);
            this.button_U.TabIndex = 57;
            this.button_U.Text = "U";
            this.button_U.UseVisualStyleBackColor = true;
            // 
            // button_G
            // 
            this.button_G.Location = new System.Drawing.Point(289, 249);
            this.button_G.Name = "button_G";
            this.button_G.Size = new System.Drawing.Size(38, 23);
            this.button_G.TabIndex = 39;
            this.button_G.Text = "G";
            this.button_G.UseVisualStyleBackColor = true;
            // 
            // button_I
            // 
            this.button_I.Location = new System.Drawing.Point(377, 249);
            this.button_I.Name = "button_I";
            this.button_I.Size = new System.Drawing.Size(38, 23);
            this.button_I.TabIndex = 42;
            this.button_I.Text = "I";
            this.button_I.UseVisualStyleBackColor = true;
            // 
            // button_J
            // 
            this.button_J.Location = new System.Drawing.Point(421, 249);
            this.button_J.Name = "button_J";
            this.button_J.Size = new System.Drawing.Size(38, 23);
            this.button_J.TabIndex = 43;
            this.button_J.Text = "J";
            this.button_J.UseVisualStyleBackColor = true;
            // 
            // button_L
            // 
            this.button_L.Location = new System.Drawing.Point(69, 278);
            this.button_L.Name = "button_L";
            this.button_L.Size = new System.Drawing.Size(38, 23);
            this.button_L.TabIndex = 44;
            this.button_L.Text = "L";
            this.button_L.UseVisualStyleBackColor = true;
            // 
            // button_T
            // 
            this.button_T.Location = new System.Drawing.Point(421, 278);
            this.button_T.Name = "button_T";
            this.button_T.Size = new System.Drawing.Size(38, 23);
            this.button_T.TabIndex = 52;
            this.button_T.Text = "T";
            this.button_T.UseVisualStyleBackColor = true;
            // 
            // button_S
            // 
            this.button_S.Location = new System.Drawing.Point(377, 278);
            this.button_S.Name = "button_S";
            this.button_S.Size = new System.Drawing.Size(38, 23);
            this.button_S.TabIndex = 53;
            this.button_S.Text = "S";
            this.button_S.UseVisualStyleBackColor = true;
            // 
            // button_C
            // 
            this.button_C.Location = new System.Drawing.Point(113, 249);
            this.button_C.Name = "button_C";
            this.button_C.Size = new System.Drawing.Size(38, 23);
            this.button_C.TabIndex = 37;
            this.button_C.Text = "C";
            this.button_C.UseVisualStyleBackColor = true;
            // 
            // button_P
            // 
            this.button_P.Location = new System.Drawing.Point(245, 278);
            this.button_P.Name = "button_P";
            this.button_P.Size = new System.Drawing.Size(38, 23);
            this.button_P.TabIndex = 46;
            this.button_P.Text = "P";
            this.button_P.UseVisualStyleBackColor = true;
            // 
            // button_R
            // 
            this.button_R.Location = new System.Drawing.Point(333, 278);
            this.button_R.Name = "button_R";
            this.button_R.Size = new System.Drawing.Size(38, 23);
            this.button_R.TabIndex = 51;
            this.button_R.Text = "R";
            this.button_R.UseVisualStyleBackColor = true;
            // 
            // button_Q
            // 
            this.button_Q.Location = new System.Drawing.Point(289, 278);
            this.button_Q.Name = "button_Q";
            this.button_Q.Size = new System.Drawing.Size(38, 23);
            this.button_Q.TabIndex = 50;
            this.button_Q.Text = "Q";
            this.button_Q.UseVisualStyleBackColor = true;
            // 
            // button_K
            // 
            this.button_K.Location = new System.Drawing.Point(20, 278);
            this.button_K.Name = "button_K";
            this.button_K.Size = new System.Drawing.Size(38, 23);
            this.button_K.TabIndex = 45;
            this.button_K.Text = "K";
            this.button_K.UseVisualStyleBackColor = true;
            // 
            // button_O
            // 
            this.button_O.Location = new System.Drawing.Point(201, 278);
            this.button_O.Name = "button_O";
            this.button_O.Size = new System.Drawing.Size(38, 23);
            this.button_O.TabIndex = 47;
            this.button_O.Text = "O";
            this.button_O.UseVisualStyleBackColor = true;
            // 
            // button_F
            // 
            this.button_F.Location = new System.Drawing.Point(245, 249);
            this.button_F.Name = "button_F";
            this.button_F.Size = new System.Drawing.Size(38, 23);
            this.button_F.TabIndex = 40;
            this.button_F.Text = "F";
            this.button_F.UseVisualStyleBackColor = true;
            // 
            // button_B
            // 
            this.button_B.Location = new System.Drawing.Point(69, 249);
            this.button_B.Name = "button_B";
            this.button_B.Size = new System.Drawing.Size(38, 23);
            this.button_B.TabIndex = 35;
            this.button_B.Text = "B";
            this.button_B.UseVisualStyleBackColor = true;
            // 
            // button_N
            // 
            this.button_N.Location = new System.Drawing.Point(157, 278);
            this.button_N.Name = "button_N";
            this.button_N.Size = new System.Drawing.Size(38, 23);
            this.button_N.TabIndex = 48;
            this.button_N.Text = "N";
            this.button_N.UseVisualStyleBackColor = true;
            // 
            // button_A
            // 
            this.button_A.Location = new System.Drawing.Point(20, 249);
            this.button_A.Name = "button_A";
            this.button_A.Size = new System.Drawing.Size(38, 23);
            this.button_A.TabIndex = 34;
            this.button_A.Text = "A";
            this.button_A.UseVisualStyleBackColor = true;
            // 
            // button_E
            // 
            this.button_E.Location = new System.Drawing.Point(201, 249);
            this.button_E.Name = "button_E";
            this.button_E.Size = new System.Drawing.Size(38, 23);
            this.button_E.TabIndex = 41;
            this.button_E.Text = "E";
            this.button_E.UseVisualStyleBackColor = true;
            // 
            // button_M
            // 
            this.button_M.Location = new System.Drawing.Point(113, 278);
            this.button_M.Name = "button_M";
            this.button_M.Size = new System.Drawing.Size(38, 23);
            this.button_M.TabIndex = 49;
            this.button_M.Text = "M";
            this.button_M.UseVisualStyleBackColor = true;
            // 
            // button_LoadNewWord
            // 
            this.button_LoadNewWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LoadNewWord.Location = new System.Drawing.Point(20, 353);
            this.button_LoadNewWord.Name = "button_LoadNewWord";
            this.button_LoadNewWord.Size = new System.Drawing.Size(146, 43);
            this.button_LoadNewWord.TabIndex = 60;
            this.button_LoadNewWord.Text = "Start a new game";
            this.button_LoadNewWord.UseVisualStyleBackColor = true;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 397);
            this.Controls.Add(this.button_LoadNewWord);
            this.Controls.Add(this.button_Z);
            this.Controls.Add(this.button_H);
            this.Controls.Add(this.button_Y);
            this.Controls.Add(this.button_D);
            this.Controls.Add(this.button_X);
            this.Controls.Add(this.button_W);
            this.Controls.Add(this.button_V);
            this.Controls.Add(this.button_U);
            this.Controls.Add(this.button_G);
            this.Controls.Add(this.button_I);
            this.Controls.Add(this.button_J);
            this.Controls.Add(this.button_L);
            this.Controls.Add(this.button_T);
            this.Controls.Add(this.button_S);
            this.Controls.Add(this.button_C);
            this.Controls.Add(this.button_P);
            this.Controls.Add(this.button_R);
            this.Controls.Add(this.button_Q);
            this.Controls.Add(this.button_K);
            this.Controls.Add(this.button_O);
            this.Controls.Add(this.button_F);
            this.Controls.Add(this.button_B);
            this.Controls.Add(this.button_N);
            this.Controls.Add(this.button_A);
            this.Controls.Add(this.button_E);
            this.Controls.Add(this.button_M);
            this.Controls.Add(this.label_KataSalah);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Word;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_MissedLtrCnt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_KataSalah;
        private System.Windows.Forms.Button button_Z;
        private System.Windows.Forms.Button button_H;
        private System.Windows.Forms.Button button_Y;
        private System.Windows.Forms.Button button_D;
        private System.Windows.Forms.Button button_X;
        private System.Windows.Forms.Button button_W;
        private System.Windows.Forms.Button button_V;
        private System.Windows.Forms.Button button_U;
        private System.Windows.Forms.Button button_G;
        private System.Windows.Forms.Button button_I;
        private System.Windows.Forms.Button button_J;
        private System.Windows.Forms.Button button_L;
        private System.Windows.Forms.Button button_T;
        private System.Windows.Forms.Button button_S;
        private System.Windows.Forms.Button button_C;
        private System.Windows.Forms.Button button_P;
        private System.Windows.Forms.Button button_R;
        private System.Windows.Forms.Button button_Q;
        private System.Windows.Forms.Button button_K;
        private System.Windows.Forms.Button button_O;
        private System.Windows.Forms.Button button_F;
        private System.Windows.Forms.Button button_B;
        private System.Windows.Forms.Button button_N;
        private System.Windows.Forms.Button button_A;
        private System.Windows.Forms.Button button_E;
        private System.Windows.Forms.Button button_M;
        private System.Windows.Forms.Button button_LoadNewWord;
    }
}