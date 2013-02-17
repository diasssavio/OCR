using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCR
{
    public partial class Form1 : Form
    {
        // inputs
        private double[][] inputs;

        public Form1()
        {
            // Allocating inputs matrix
            inputs = new double[9][];
            for (int i = 0; i < inputs.Length; i++)
                inputs[i] = new double[35];

            InitializeComponent();
        }

        /// <summary>
        /// Muda a cor de fundo (preto<->branco) do button passado como parametro
        /// </summary>
        /// <param name="button">botão a ser trocado a cor</param>
        private void ChangeButtonColor(ref Button button)
        {
            if (button.BackColor == Color.White)
                button.BackColor = Color.Black;
            else if (button.BackColor == Color.Black)
                button.BackColor = Color.White;
        }

        /// <summary>
        /// Limpa a grade de padrões
        /// </summary>
        private void CleanGrid()
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
            button10.BackColor = Color.White;
            button11.BackColor = Color.White;
            button12.BackColor = Color.White;
            button13.BackColor = Color.White;
            button14.BackColor = Color.White;
            button15.BackColor = Color.White;
            button16.BackColor = Color.White;
            button17.BackColor = Color.White;
            button18.BackColor = Color.White;
            button19.BackColor = Color.White;
            button20.BackColor = Color.White;
            button21.BackColor = Color.White;
            button22.BackColor = Color.White;
            button23.BackColor = Color.White;
            button24.BackColor = Color.White;
            button25.BackColor = Color.White;
            button26.BackColor = Color.White;
            button27.BackColor = Color.White;
            button28.BackColor = Color.White;
            button29.BackColor = Color.White;
            button30.BackColor = Color.White;
            button31.BackColor = Color.White;
            button32.BackColor = Color.White;
            button33.BackColor = Color.White;
            button34.BackColor = Color.White;
            button35.BackColor = Color.White;
        }

        /// <summary>
        /// Monta o vetor que representa o número index (nessa posição)
        /// </summary>
        /// <param name="index">indice do número representado pela grade</param>
        private void MountMatrix(int index)
        {
            inputs[index][0] = (button5.BackColor == Color.White) ? -1.0 : 1.0;
            inputs[index][1] = (button4.BackColor == Color.White) ? -1.0 : 1.0;
            inputs[index][2] = (button3.BackColor == Color.White) ? -1.0 : 1.0;
            inputs[index][3] = (button2.BackColor == Color.White) ? -1.0 : 1.0;
            inputs[index][4] = (button1.BackColor == Color.White) ? -1.0 : 1.0;
            inputs[index][5] = (button10.BackColor == Color.White) ? -1.0 : 1.0;
            inputs[index][6] = (button9.BackColor == Color.White) ? -1.0 : 1.0;
            inputs[index][7] = (button8.BackColor == Color.White) ? -1.0 : 1.0;
            inputs[index][8] = (button7.BackColor == Color.White) ? -1.0 : 1.0;
            inputs[index][9] = (button6.BackColor == Color.White) ? -1.0 : 1.0;
            inputs[index][10] = (button15.BackColor == Color.White) ? -1.0 : 1.0;
            inputs[index][11] = (button14.BackColor == Color.White) ? -1.0 : 1.0;
            inputs[index][12] = (button13.BackColor == Color.White) ? -1.0 : 1.0;
            inputs[index][13] = (button12.BackColor == Color.White) ? -1.0 : 1.0;
            inputs[index][14] = (button11.BackColor == Color.White) ? -1.0 : 1.0;
            inputs[index][15] = (button20.BackColor == Color.White) ? -1.0 : 1.0;
            inputs[index][16] = (button19.BackColor == Color.White) ? -1.0 : 1.0;
            inputs[index][17] = (button18.BackColor == Color.White) ? -1.0 : 1.0;
            inputs[index][18] = (button17.BackColor == Color.White) ? -1.0 : 1.0;
            inputs[index][19] = (button16.BackColor == Color.White) ? -1.0 : 1.0;
            inputs[index][20] = (button25.BackColor == Color.White) ? -1.0 : 1.0;
            inputs[index][21] = (button24.BackColor == Color.White) ? -1.0 : 1.0;
            inputs[index][22] = (button23.BackColor == Color.White) ? -1.0 : 1.0;
            inputs[index][23] = (button22.BackColor == Color.White) ? -1.0 : 1.0;
            inputs[index][24] = (button21.BackColor == Color.White) ? -1.0 : 1.0;
            inputs[index][25] = (button30.BackColor == Color.White) ? -1.0 : 1.0;
            inputs[index][26] = (button29.BackColor == Color.White) ? -1.0 : 1.0;
            inputs[index][27] = (button28.BackColor == Color.White) ? -1.0 : 1.0;
            inputs[index][28] = (button27.BackColor == Color.White) ? -1.0 : 1.0;
            inputs[index][29] = (button26.BackColor == Color.White) ? -1.0 : 1.0;
            inputs[index][30] = (button35.BackColor == Color.White) ? -1.0 : 1.0;
            inputs[index][31] = (button34.BackColor == Color.White) ? -1.0 : 1.0;
            inputs[index][32] = (button33.BackColor == Color.White) ? -1.0 : 1.0;
            inputs[index][33] = (button32.BackColor == Color.White) ? -1.0 : 1.0;
            inputs[index][34] = (button31.BackColor == Color.White) ? -1.0 : 1.0;
        }

        /// <summary>
        /// Monta o grid de acordo com o vetor presente na posição index da matriz
        /// </summary>
        /// <param name="index">indice do número na matriz de entradas</param>
        private void MountGrid(int index)
        {
            button5.BackColor = (inputs[index][0] == -1.0) ? Color.White : Color.Black;
            button4.BackColor = (inputs[index][1] == -1.0) ? Color.White : Color.Black;
            button3.BackColor = (inputs[index][2] == -1.0) ? Color.White : Color.Black;
            button2.BackColor = (inputs[index][3] == -1.0) ? Color.White : Color.Black;
            button1.BackColor = (inputs[index][4] == -1.0) ? Color.White : Color.Black;
            button10.BackColor = (inputs[index][5] == -1.0) ? Color.White : Color.Black;
            button9.BackColor = (inputs[index][6] == -1.0) ? Color.White : Color.Black;
            button8.BackColor = (inputs[index][7] == -1.0) ? Color.White : Color.Black;
            button7.BackColor = (inputs[index][8] == -1.0) ? Color.White : Color.Black;
            button6.BackColor = (inputs[index][9] == -1.0) ? Color.White : Color.Black;
            button15.BackColor = (inputs[index][10] == -1.0) ? Color.White : Color.Black;
            button14.BackColor = (inputs[index][11] == -1.0) ? Color.White : Color.Black;
            button13.BackColor = (inputs[index][12] == -1.0) ? Color.White : Color.Black;
            button12.BackColor = (inputs[index][13] == -1.0) ? Color.White : Color.Black;
            button11.BackColor = (inputs[index][14] == -1.0) ? Color.White : Color.Black;
            button20.BackColor = (inputs[index][15] == -1.0) ? Color.White : Color.Black;
            button19.BackColor = (inputs[index][16] == -1.0) ? Color.White : Color.Black;
            button18.BackColor = (inputs[index][17] == -1.0) ? Color.White : Color.Black;
            button17.BackColor = (inputs[index][18] == -1.0) ? Color.White : Color.Black;
            button16.BackColor = (inputs[index][19] == -1.0) ? Color.White : Color.Black;
            button25.BackColor = (inputs[index][20] == -1.0) ? Color.White : Color.Black;
            button24.BackColor = (inputs[index][21] == -1.0) ? Color.White : Color.Black;
            button23.BackColor = (inputs[index][22] == -1.0) ? Color.White : Color.Black;
            button22.BackColor = (inputs[index][23] == -1.0) ? Color.White : Color.Black;
            button21.BackColor = (inputs[index][24] == -1.0) ? Color.White : Color.Black;
            button30.BackColor = (inputs[index][25] == -1.0) ? Color.White : Color.Black;
            button29.BackColor = (inputs[index][26] == -1.0) ? Color.White : Color.Black;
            button28.BackColor = (inputs[index][27] == -1.0) ? Color.White : Color.Black;
            button27.BackColor = (inputs[index][28] == -1.0) ? Color.White : Color.Black;
            button26.BackColor = (inputs[index][29] == -1.0) ? Color.White : Color.Black;
            button35.BackColor = (inputs[index][30] == -1.0) ? Color.White : Color.Black;
            button34.BackColor = (inputs[index][31] == -1.0) ? Color.White : Color.Black;
            button33.BackColor = (inputs[index][32] == -1.0) ? Color.White : Color.Black;
            button32.BackColor = (inputs[index][33] == -1.0) ? Color.White : Color.Black;
            button31.BackColor = (inputs[index][34] == -1.0) ? Color.White : Color.Black;
        }

        #region Matrix Clicks
        private void button1_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(ref button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(ref button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(ref button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(ref button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(ref button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(ref button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(ref button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(ref button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(ref button9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(ref button10);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(ref button11);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(ref button12);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(ref button13);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(ref button14);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(ref button15);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(ref button16);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(ref button17);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(ref button18);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(ref button19);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(ref button20);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(ref button21);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(ref button22);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(ref button23);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(ref button24);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(ref button25);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(ref button26);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(ref button27);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(ref button28);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(ref button29);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(ref button30);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(ref button31);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(ref button32);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(ref button33);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(ref button34);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(ref button35);
        }
        #endregion

        private void memorizeButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                MountMatrix(comboBox1.SelectedIndex);
                MessageBox.Show("Padrão memorizado com sucesso!");
            }
            else MessageBox.Show("Escolha um número válido");
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
                MountGrid(comboBox1.SelectedIndex);
            else
                MessageBox.Show("Escolha um número válido");
        }

        private void trainButton_Click(object sender, EventArgs e)
        {

        }

        private void cleanGridButton_Click(object sender, EventArgs e)
        {
            CleanGrid();
        }

        private void cleanAllButton_Click(object sender, EventArgs e)
        {
            CleanGrid();
            comboBox1.SelectedIndex = -1;
            textBox1.Text = "";
        }

        private void recognitionButton_Click(object sender, EventArgs e)
        {

        }
    }
}
