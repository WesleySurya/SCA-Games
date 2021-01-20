
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_MissedLtrCnt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_KataSalah = new System.Windows.Forms.Label();
            this.button_LoadNewWord = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label_Kata = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_M = new System.Windows.Forms.Button();
            this.button_E = new System.Windows.Forms.Button();
            this.button_A = new System.Windows.Forms.Button();
            this.button_N = new System.Windows.Forms.Button();
            this.button_B = new System.Windows.Forms.Button();
            this.button_F = new System.Windows.Forms.Button();
            this.button_O = new System.Windows.Forms.Button();
            this.button_K = new System.Windows.Forms.Button();
            this.button_Q = new System.Windows.Forms.Button();
            this.button_R = new System.Windows.Forms.Button();
            this.button_P = new System.Windows.Forms.Button();
            this.button_C = new System.Windows.Forms.Button();
            this.button_S = new System.Windows.Forms.Button();
            this.button_T = new System.Windows.Forms.Button();
            this.button_L = new System.Windows.Forms.Button();
            this.button_J = new System.Windows.Forms.Button();
            this.button_I = new System.Windows.Forms.Button();
            this.button_G = new System.Windows.Forms.Button();
            this.button_U = new System.Windows.Forms.Button();
            this.button_V = new System.Windows.Forms.Button();
            this.button_W = new System.Windows.Forms.Button();
            this.button_X = new System.Windows.Forms.Button();
            this.button_D = new System.Windows.Forms.Button();
            this.button_Y = new System.Windows.Forms.Button();
            this.button_H = new System.Windows.Forms.Button();
            this.button_Z = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label_MissedLtrCnt);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(421, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 139);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giliran Tersisa";
            // 
            // label_MissedLtrCnt
            // 
            this.label_MissedLtrCnt.AutoSize = true;
            this.label_MissedLtrCnt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_MissedLtrCnt.Font = new System.Drawing.Font("Calibri", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MissedLtrCnt.ForeColor = System.Drawing.Color.Black;
            this.label_MissedLtrCnt.Location = new System.Drawing.Point(44, 34);
            this.label_MissedLtrCnt.Name = "label_MissedLtrCnt";
            this.label_MissedLtrCnt.Size = new System.Drawing.Size(69, 82);
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
            this.label_KataSalah.Location = new System.Drawing.Point(103, 139);
            this.label_KataSalah.Name = "label_KataSalah";
            this.label_KataSalah.Size = new System.Drawing.Size(19, 25);
            this.label_KataSalah.TabIndex = 33;
            this.label_KataSalah.Text = "-";
            this.label_KataSalah.Click += new System.EventHandler(this.label_KataSalah_Click);
            // 
            // button_LoadNewWord
            // 
            this.button_LoadNewWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LoadNewWord.Location = new System.Drawing.Point(20, 343);
            this.button_LoadNewWord.Name = "button_LoadNewWord";
            this.button_LoadNewWord.Size = new System.Drawing.Size(146, 43);
            this.button_LoadNewWord.TabIndex = 60;
            this.button_LoadNewWord.Text = "Start a new game";
            this.button_LoadNewWord.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(412, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 43);
            this.button1.TabIndex = 61;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_Kata
            // 
            this.label_Kata.AutoSize = true;
            this.label_Kata.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Kata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Kata.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Kata.Location = new System.Drawing.Point(102, 33);
            this.label_Kata.Name = "label_Kata";
            this.label_Kata.Size = new System.Drawing.Size(151, 31);
            this.label_Kata.TabIndex = 0;
            this.label_Kata.Text = "________";
            this.label_Kata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hangman";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label_Kata);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 100);
            this.panel1.TabIndex = 27;
            // 
            // button_M
            // 
            this.button_M.Location = new System.Drawing.Point(322, 97);
            this.button_M.Name = "button_M";
            this.button_M.Size = new System.Drawing.Size(38, 23);
            this.button_M.TabIndex = 75;
            this.button_M.Text = "M";
            this.button_M.UseVisualStyleBackColor = true;
            this.button_M.Click += new System.EventHandler(this.button_M_Click_1);
            // 
            // button_E
            // 
            this.button_E.Location = new System.Drawing.Point(125, 39);
            this.button_E.Name = "button_E";
            this.button_E.Size = new System.Drawing.Size(38, 23);
            this.button_E.TabIndex = 67;
            this.button_E.Text = "E";
            this.button_E.UseVisualStyleBackColor = true;
            this.button_E.Click += new System.EventHandler(this.button_E_Click_1);
            // 
            // button_A
            // 
            this.button_A.Location = new System.Drawing.Point(40, 68);
            this.button_A.Name = "button_A";
            this.button_A.Size = new System.Drawing.Size(38, 23);
            this.button_A.TabIndex = 60;
            this.button_A.Text = "A";
            this.button_A.UseVisualStyleBackColor = true;
            this.button_A.Click += new System.EventHandler(this.button_A_Click_1);
            // 
            // button_N
            // 
            this.button_N.Location = new System.Drawing.Point(278, 97);
            this.button_N.Name = "button_N";
            this.button_N.Size = new System.Drawing.Size(38, 23);
            this.button_N.TabIndex = 74;
            this.button_N.Text = "N";
            this.button_N.UseVisualStyleBackColor = true;
            this.button_N.Click += new System.EventHandler(this.button_N_Click_1);
            // 
            // button_B
            // 
            this.button_B.Location = new System.Drawing.Point(234, 97);
            this.button_B.Name = "button_B";
            this.button_B.Size = new System.Drawing.Size(38, 23);
            this.button_B.TabIndex = 61;
            this.button_B.Text = "B";
            this.button_B.UseVisualStyleBackColor = true;
            this.button_B.Click += new System.EventHandler(this.button_B_Click_1);
            // 
            // button_F
            // 
            this.button_F.Location = new System.Drawing.Point(172, 68);
            this.button_F.Name = "button_F";
            this.button_F.Size = new System.Drawing.Size(38, 23);
            this.button_F.TabIndex = 66;
            this.button_F.Text = "F";
            this.button_F.UseVisualStyleBackColor = true;
            this.button_F.Click += new System.EventHandler(this.button_F_Click_1);
            // 
            // button_O
            // 
            this.button_O.Location = new System.Drawing.Point(387, 39);
            this.button_O.Name = "button_O";
            this.button_O.Size = new System.Drawing.Size(38, 23);
            this.button_O.TabIndex = 73;
            this.button_O.Text = "O";
            this.button_O.UseVisualStyleBackColor = true;
            this.button_O.Click += new System.EventHandler(this.button_O_Click_1);
            // 
            // button_K
            // 
            this.button_K.Location = new System.Drawing.Point(348, 68);
            this.button_K.Name = "button_K";
            this.button_K.Size = new System.Drawing.Size(38, 23);
            this.button_K.TabIndex = 71;
            this.button_K.Text = "K";
            this.button_K.UseVisualStyleBackColor = true;
            this.button_K.Click += new System.EventHandler(this.button_K_Click_1);
            // 
            // button_Q
            // 
            this.button_Q.Location = new System.Drawing.Point(30, 39);
            this.button_Q.Name = "button_Q";
            this.button_Q.Size = new System.Drawing.Size(38, 23);
            this.button_Q.TabIndex = 76;
            this.button_Q.Text = "Q";
            this.button_Q.UseVisualStyleBackColor = true;
            this.button_Q.Click += new System.EventHandler(this.button_Q_Click_1);
            // 
            // button_R
            // 
            this.button_R.Location = new System.Drawing.Point(169, 39);
            this.button_R.Name = "button_R";
            this.button_R.Size = new System.Drawing.Size(38, 23);
            this.button_R.TabIndex = 77;
            this.button_R.Text = "R";
            this.button_R.UseVisualStyleBackColor = true;
            this.button_R.Click += new System.EventHandler(this.button_R_Click_1);
            // 
            // button_P
            // 
            this.button_P.Location = new System.Drawing.Point(431, 39);
            this.button_P.Name = "button_P";
            this.button_P.Size = new System.Drawing.Size(38, 23);
            this.button_P.TabIndex = 72;
            this.button_P.Text = "P";
            this.button_P.UseVisualStyleBackColor = true;
            this.button_P.Click += new System.EventHandler(this.button_P_Click_1);
            // 
            // button_C
            // 
            this.button_C.Location = new System.Drawing.Point(146, 97);
            this.button_C.Name = "button_C";
            this.button_C.Size = new System.Drawing.Size(38, 23);
            this.button_C.TabIndex = 63;
            this.button_C.Text = "C";
            this.button_C.UseVisualStyleBackColor = true;
            this.button_C.Click += new System.EventHandler(this.button_C_Click_1);
            // 
            // button_S
            // 
            this.button_S.Location = new System.Drawing.Point(84, 68);
            this.button_S.Name = "button_S";
            this.button_S.Size = new System.Drawing.Size(38, 23);
            this.button_S.TabIndex = 79;
            this.button_S.Text = "S";
            this.button_S.UseVisualStyleBackColor = true;
            this.button_S.Click += new System.EventHandler(this.button_S_Click_1);
            // 
            // button_T
            // 
            this.button_T.Location = new System.Drawing.Point(213, 39);
            this.button_T.Name = "button_T";
            this.button_T.Size = new System.Drawing.Size(38, 23);
            this.button_T.TabIndex = 78;
            this.button_T.Text = "T";
            this.button_T.UseVisualStyleBackColor = true;
            this.button_T.Click += new System.EventHandler(this.button_T_Click_1);
            // 
            // button_L
            // 
            this.button_L.Location = new System.Drawing.Point(392, 68);
            this.button_L.Name = "button_L";
            this.button_L.Size = new System.Drawing.Size(38, 23);
            this.button_L.TabIndex = 70;
            this.button_L.Text = "L";
            this.button_L.UseVisualStyleBackColor = true;
            this.button_L.Click += new System.EventHandler(this.button_L_Click_1);
            // 
            // button_J
            // 
            this.button_J.Location = new System.Drawing.Point(304, 68);
            this.button_J.Name = "button_J";
            this.button_J.Size = new System.Drawing.Size(38, 23);
            this.button_J.TabIndex = 69;
            this.button_J.Text = "J";
            this.button_J.UseVisualStyleBackColor = true;
            this.button_J.Click += new System.EventHandler(this.button_J_Click_1);
            // 
            // button_I
            // 
            this.button_I.Location = new System.Drawing.Point(343, 39);
            this.button_I.Name = "button_I";
            this.button_I.Size = new System.Drawing.Size(38, 23);
            this.button_I.TabIndex = 68;
            this.button_I.Text = "I";
            this.button_I.UseVisualStyleBackColor = true;
            this.button_I.Click += new System.EventHandler(this.button_I_Click_1);
            // 
            // button_G
            // 
            this.button_G.Location = new System.Drawing.Point(216, 68);
            this.button_G.Name = "button_G";
            this.button_G.Size = new System.Drawing.Size(38, 23);
            this.button_G.TabIndex = 65;
            this.button_G.Text = "G";
            this.button_G.UseVisualStyleBackColor = true;
            this.button_G.Click += new System.EventHandler(this.button_G_Click_1);
            // 
            // button_U
            // 
            this.button_U.Location = new System.Drawing.Point(299, 39);
            this.button_U.Name = "button_U";
            this.button_U.Size = new System.Drawing.Size(38, 23);
            this.button_U.TabIndex = 83;
            this.button_U.Text = "U";
            this.button_U.UseVisualStyleBackColor = true;
            this.button_U.Click += new System.EventHandler(this.button_U_Click_1);
            // 
            // button_V
            // 
            this.button_V.Location = new System.Drawing.Point(190, 97);
            this.button_V.Name = "button_V";
            this.button_V.Size = new System.Drawing.Size(38, 23);
            this.button_V.TabIndex = 82;
            this.button_V.Text = "V";
            this.button_V.UseVisualStyleBackColor = true;
            this.button_V.Click += new System.EventHandler(this.button_V_Click_1);
            // 
            // button_W
            // 
            this.button_W.Location = new System.Drawing.Point(79, 39);
            this.button_W.Name = "button_W";
            this.button_W.Size = new System.Drawing.Size(38, 23);
            this.button_W.TabIndex = 81;
            this.button_W.Text = "W";
            this.button_W.UseVisualStyleBackColor = true;
            this.button_W.Click += new System.EventHandler(this.button_W_Click_1);
            // 
            // button_X
            // 
            this.button_X.Location = new System.Drawing.Point(102, 97);
            this.button_X.Name = "button_X";
            this.button_X.Size = new System.Drawing.Size(38, 23);
            this.button_X.TabIndex = 80;
            this.button_X.Text = "X";
            this.button_X.UseVisualStyleBackColor = true;
            this.button_X.Click += new System.EventHandler(this.button_X_Click_1);
            // 
            // button_D
            // 
            this.button_D.Location = new System.Drawing.Point(128, 68);
            this.button_D.Name = "button_D";
            this.button_D.Size = new System.Drawing.Size(38, 23);
            this.button_D.TabIndex = 62;
            this.button_D.Text = "D";
            this.button_D.UseVisualStyleBackColor = true;
            this.button_D.Click += new System.EventHandler(this.button_D_Click_1);
            // 
            // button_Y
            // 
            this.button_Y.Location = new System.Drawing.Point(255, 39);
            this.button_Y.Name = "button_Y";
            this.button_Y.Size = new System.Drawing.Size(38, 23);
            this.button_Y.TabIndex = 84;
            this.button_Y.Text = "Y";
            this.button_Y.UseVisualStyleBackColor = true;
            this.button_Y.Click += new System.EventHandler(this.button_Y_Click_1);
            // 
            // button_H
            // 
            this.button_H.Location = new System.Drawing.Point(260, 68);
            this.button_H.Name = "button_H";
            this.button_H.Size = new System.Drawing.Size(38, 23);
            this.button_H.TabIndex = 64;
            this.button_H.Text = "H";
            this.button_H.UseVisualStyleBackColor = true;
            this.button_H.Click += new System.EventHandler(this.button_H_Click_1);
            // 
            // button_Z
            // 
            this.button_Z.Location = new System.Drawing.Point(58, 97);
            this.button_Z.Name = "button_Z";
            this.button_Z.Size = new System.Drawing.Size(38, 23);
            this.button_Z.TabIndex = 85;
            this.button_Z.Text = "Z";
            this.button_Z.UseVisualStyleBackColor = true;
            this.button_Z.Click += new System.EventHandler(this.button_Z_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_Z);
            this.groupBox2.Controls.Add(this.button_H);
            this.groupBox2.Controls.Add(this.button_Y);
            this.groupBox2.Controls.Add(this.button_D);
            this.groupBox2.Controls.Add(this.button_X);
            this.groupBox2.Controls.Add(this.button_W);
            this.groupBox2.Controls.Add(this.button_V);
            this.groupBox2.Controls.Add(this.button_U);
            this.groupBox2.Controls.Add(this.button_G);
            this.groupBox2.Controls.Add(this.button_I);
            this.groupBox2.Controls.Add(this.button_J);
            this.groupBox2.Controls.Add(this.button_L);
            this.groupBox2.Controls.Add(this.button_T);
            this.groupBox2.Controls.Add(this.button_S);
            this.groupBox2.Controls.Add(this.button_C);
            this.groupBox2.Controls.Add(this.button_P);
            this.groupBox2.Controls.Add(this.button_R);
            this.groupBox2.Controls.Add(this.button_Q);
            this.groupBox2.Controls.Add(this.button_K);
            this.groupBox2.Controls.Add(this.button_O);
            this.groupBox2.Controls.Add(this.button_F);
            this.groupBox2.Controls.Add(this.button_B);
            this.groupBox2.Controls.Add(this.button_N);
            this.groupBox2.Controls.Add(this.button_A);
            this.groupBox2.Controls.Add(this.button_E);
            this.groupBox2.Controls.Add(this.button_M);
            this.groupBox2.Location = new System.Drawing.Point(20, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 129);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Keypad";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 394);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_LoadNewWord);
            this.Controls.Add(this.label_KataSalah);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_MissedLtrCnt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_KataSalah;
        private System.Windows.Forms.Button button_LoadNewWord;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_Kata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_M;
        private System.Windows.Forms.Button button_E;
        private System.Windows.Forms.Button button_A;
        private System.Windows.Forms.Button button_N;
        private System.Windows.Forms.Button button_B;
        private System.Windows.Forms.Button button_F;
        private System.Windows.Forms.Button button_O;
        private System.Windows.Forms.Button button_K;
        private System.Windows.Forms.Button button_Q;
        private System.Windows.Forms.Button button_R;
        private System.Windows.Forms.Button button_P;
        private System.Windows.Forms.Button button_C;
        private System.Windows.Forms.Button button_S;
        private System.Windows.Forms.Button button_T;
        private System.Windows.Forms.Button button_L;
        private System.Windows.Forms.Button button_J;
        private System.Windows.Forms.Button button_I;
        private System.Windows.Forms.Button button_G;
        private System.Windows.Forms.Button button_U;
        private System.Windows.Forms.Button button_V;
        private System.Windows.Forms.Button button_W;
        private System.Windows.Forms.Button button_X;
        private System.Windows.Forms.Button button_D;
        private System.Windows.Forms.Button button_Y;
        private System.Windows.Forms.Button button_H;
        private System.Windows.Forms.Button button_Z;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}