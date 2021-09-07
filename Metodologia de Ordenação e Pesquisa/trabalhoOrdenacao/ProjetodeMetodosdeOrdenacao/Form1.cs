﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetodeMetodosdeOrdenacao
{
    public partial class Form1 : Form
    {
		Metodos M = new Metodos();
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdVetor_Click(object sender, EventArgs e)
        {
            dgvVetor.RowCount = 1;
            dgvVetor.ColumnCount = (int)nudColunas.Value;

            for (int i = 0; i < nudColunas.Value; i++)
            {
                dgvVetor.Columns[i].Width = 30;
                dgvVetor.Rows[0].Height = 30;
                dgvVetor.Rows[0].Cells[i].Value = 0;
            }
        }

        private void cmdOrdenar_Click(object sender, EventArgs e)
        {
            int[] vet = new int[(int)nudColunas.Value];

            for (int i = 0; i < (int)nudColunas.Value; i++)
            {
                vet[i] = Convert.ToInt32(dgvVetor.Rows[0].Cells[i].Value);
            }
            if(comboBox1.SelectedItem == "Select Sort")
            {
                M.SelectSort(vet);
                lblTroca.Text = M.T4.ToString();
                lblComp.Text = M.C4.ToString();
            }
            else if (comboBox1.SelectedItem == "Insertion Sort")
            {
                M.InsertSort(vet);
                lblTroca.Text = M.T3.ToString();
                lblComp.Text = M.C3.ToString();
            }
            else if (comboBox1.SelectedItem == "Bubble Sort")
            {
                M.BubbleSort(vet);
                lblTroca.Text = M.T2.ToString();
                lblComp.Text = M.C2.ToString();
            }
            else if (comboBox1.SelectedItem == "Quick Sort")
            {
                M.QuickSort(vet, 0, (int)nudColunas.Value - 1);
                lblTroca.Text = M.T1.ToString();
                lblComp.Text = M.C1.ToString();
            }
            for (int j = 0; j < (int)nudColunas.Value; j++)
            {
                dgvVetor.Rows[0].Cells[j].Value = vet[j];
            }
        }
    }
}
