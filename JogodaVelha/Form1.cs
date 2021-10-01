using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogodaVelha
{
    public partial class Form1 : Form
    {
        public int turno;

        int[,] matriz = new int[3, 3];
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(matriz[0,0] == 0)
            {
                if (turno % 2 == 0)
                {
                    turno++;
                    matriz[0, 0] = 1;
                    ganhar(1);
                    btn1.BackColor = Color.FromArgb(243, 105, 94);
                }
                else if (turno % 2 != 0)
                {
                    turno++;
                    matriz[0, 0] = 2;
                    ganhar(2);
                    btn1.BackColor = Color.FromArgb(84, 168, 241);
                }
                turnoMensagem();
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (matriz[0, 1] == 0)
            {
                if (turno % 2 == 0)
                {
                    turno++;
                    matriz[0, 1] = 1;
                    ganhar(1);
                    btn2.BackColor = Color.FromArgb(243, 105, 94);
                }
                else if (turno % 2 != 0)
                {
                    turno++;
                    matriz[0, 1] = 2;
                    ganhar(2);
                    btn2.BackColor = Color.FromArgb(84, 168, 241);

                }
                turnoMensagem();
            }
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (matriz[0, 2] == 0)
            {
                if (turno % 2 == 0)
                {
                    turno++;
                    matriz[0,2] = 1;
                    ganhar(1);
                    btn3.BackColor = Color.FromArgb(243, 105, 94);
                }
                else if (turno % 2 != 0)
                {
                    turno++;
                    matriz[0, 2] = 2;
                    ganhar(2);
                    btn3.BackColor = Color.FromArgb(84, 168, 241);
                }
                turnoMensagem();
            }
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            if (matriz[1, 0] == 0)
            {
                if (turno % 2 == 0)
                {
                    turno++;
                    matriz[1, 0] = 1;
                    ganhar(1);
                    btn4.BackColor = Color.FromArgb(243, 105, 94);
                }
                else if (turno % 2 != 0)
                {
                    turno++;
                    matriz[1, 0] = 2;
                    ganhar(2);
                    btn4.BackColor = Color.FromArgb(84, 168, 241);
                }
                turnoMensagem();
            }
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            if (matriz[1, 1] == 0)
            {
                if (turno % 2 == 0)
                {
                    turno++;
                    matriz[1, 1] = 1;
                    ganhar(1);
                    btn5.BackColor = Color.FromArgb(243, 105, 94);

                }
                else if (turno % 2 != 0)
                {
                    turno++;
                    matriz[1, 1] = 2;
                    ganhar(2);
                    btn5.BackColor = Color.FromArgb(84, 168, 241);
                }
                turnoMensagem();
            }
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            if (matriz[1, 2] == 0)
            {
                if (turno % 2 == 0)
                {
                    turno++;
                    matriz[1, 2] = 1;
                    ganhar(1);
                    btn6.BackColor = Color.FromArgb(243, 105, 94);
                }
                else if (turno % 2 != 0)
                {
                    turno++;
                    matriz[1, 2] = 2;
                    ganhar(2);
                    btn6.BackColor = Color.FromArgb(84, 168, 241);
                }
                turnoMensagem();
            }
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (matriz[2, 0] == 0)
            {
                if (turno % 2 == 0)
                {
                    turno++;
                    matriz[2, 0] = 1;
                    ganhar(1);
                    btn7.BackColor = Color.FromArgb(243, 105, 94);

                }
                else if (turno % 2 != 0)
                {
                    turno++;
                    matriz[2, 0] = 2;
                    ganhar(2);
                    btn7.BackColor = Color.FromArgb(84, 168, 241);
                }
                turnoMensagem();
            }
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            if (matriz[2, 1] == 0)
            {
                if (turno % 2 == 0)
                {
                    turno++;
                    matriz[2, 1] = 1;
                    ganhar(1);
                    btn8.BackColor = Color.FromArgb(243, 105, 94);
                }
                else if (turno % 2 != 0)
                {
                    turno++;
                    matriz[2, 1] = 2;
                    ganhar(2);
                    btn8.BackColor = Color.FromArgb(84, 168, 241);
                }
                turnoMensagem();
            }
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            if (matriz[2, 2] == 0)
            {
                if (turno % 2 == 0)
                {
                    turno++;
                    matriz[2, 2] = 1;
                    ganhar(1);
                    btn9.BackColor = Color.FromArgb(243, 105, 94);
                }
                else if (turno % 2 != 0)
                {
                    turno++;
                    matriz[2, 2] = 2;
                    ganhar(2);
                    btn9.BackColor = Color.FromArgb(84, 168, 241);
                }
                turnoMensagem();
            }
        }
    
        public void turnoMensagem()
        {
            if(turno % 2 == 0)
            {
                lbl_turno.Text = "Jogador Vermelho";
            }else if(turno % 2 != 0)
            {
                lbl_turno.Text = "Jogador Azul";
            }   
        }
        public void ganhar(int num)
        {
            if (matriz[0,0] == num && matriz[0, 1]== num && matriz[0, 2] == num)
            {
                MessageBox.Show("Jogador  " + num + "  Ganhou!!");
            }else if (matriz[0, 0] == num && matriz[1, 0] == num && matriz[2, 0] == num)
            {
                MessageBox.Show("Jogador  " + num + "  Ganhou!!");
            }else if(matriz[2, 0] == num && matriz[2,1] == num && matriz[2, 2] == num)
            {
                MessageBox.Show("Jogador  " + num + "  Ganhou!!");
            }else if(matriz[0, 2] == num && matriz[1, 2] == num && matriz[2, 2] == num)
            {
                MessageBox.Show("Jogador  " + num + "  Ganhou!!");
            }else if (matriz[1, 0] == num && matriz[1, 1] == num && matriz[1, 2] == num)
            {
                MessageBox.Show("Jogador  " + num + "  Ganhou!!");
            }else if (matriz[0, 1] == num && matriz[1, 1] == num && matriz[2, 2] == num)
            {
                MessageBox.Show("Jogador  " + num + "  Ganhou!!");
            }else if(matriz[0, 0] == num && matriz[1, 1] == num && matriz[2, 2] == num)
            {
                MessageBox.Show("Jogador  " + num + "  Ganhou!!");
            }
            else if (matriz[0, 2] == num && matriz[1, 1] == num && matriz[2, 0] == num)
            {
                MessageBox.Show("Jogador  " + num + "  Ganhou!!");
            }
        }
        private void btn_reiniciar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    matriz[i, j] = 0;
                }
            }
            turno = 0;
            Cores();

        }
        private void Cores()
        {
            btn1.BackColor = Color.White;
            btn2.BackColor = Color.White;
            btn3.BackColor = Color.White;
            btn4.BackColor = Color.White;
            btn5.BackColor = Color.White;
            btn6.BackColor = Color.White;
            btn7.BackColor = Color.White;
            btn8.BackColor = Color.White;
            btn9.BackColor = Color.White;
        }

    }
}