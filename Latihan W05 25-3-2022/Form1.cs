using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_W05_25_3_2022
{
    public partial class FormTugas : Form
    {
        public FormTugas()
        {
            InitializeComponent();
        }

        private void FormTugas_Load(object sender, EventArgs e)
        {

        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            if (cBoxMode.SelectedItem == "Add" && txtBoxData.Text != "")
            {
                lBoxKiri.Items.Add(txtBoxData.Text);
            }
            else if (cBoxMode.SelectedItem == "Replace" && lBoxKiri.SelectedItem != "" && txtBoxData.Text != "")
            {
                if (lBoxKiri.SelectedItems.Count > 1)
                {
                    MessageBox.Show("Replace hanya dapat mengganti satu data saja");
                }
                else if (lBoxKiri.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Tidak ada data yang dipilih");
                }
                else
                {
                    int selectedItem = lBoxKiri.SelectedIndex;
                    lBoxKiri.Items.RemoveAt(selectedItem);
                    lBoxKiri.Items.Insert(selectedItem, txtBoxData.Text);
                }
            }
        }

        private void checkBoxBlock_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBlock.Checked == true)
            {
                btnFullKanan.Enabled = false;
                btnKanan.Enabled = false;
                btnFullKiri.Enabled = false;
                btnKiri.Enabled = false;
                btnHapus.Enabled = false;
            }
            else
            {
                btnFullKanan.Enabled = true;
                btnKanan.Enabled = true;
                btnFullKiri.Enabled = true;
                btnKiri.Enabled = true;
                btnHapus.Enabled = true;
            }
        }

        private void btnFullKanan_Click(object sender, EventArgs e)
        {
            lBoxKanan.Items.AddRange(lBoxKiri.Items);
            lBoxKiri.Items.Clear();
        }

        private void btnKanan_Click(object sender, EventArgs e)
        {
            if (lBoxKiri.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item");
            }
            else
            {
                while (lBoxKiri.SelectedItems.Count != 0)
                {
                    lBoxKanan.Items.Add(lBoxKiri.SelectedItem);
                    lBoxKiri.Items.Remove(lBoxKiri.SelectedItem);
                }
            }
        }


        private void btnFullKiri_Click(object sender, EventArgs e)
        {
            lBoxKiri.Items.AddRange(lBoxKanan.Items);
            lBoxKanan.Items.Clear();
        }

        private void btnKiri_Click(object sender, EventArgs e)
        {
            if (lBoxKanan.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item");
            }
            else
            {
                while (lBoxKiri.SelectedItems.Count != 0)
                {
                    lBoxKiri.Items.Add(lBoxKanan.SelectedItem);
                    lBoxKanan.Items.Remove(lBoxKanan.SelectedItem);
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {


            if (lBoxKiri.SelectedItem != "" || lBoxKanan.SelectedItem != "")
            {
                for (int x = lBoxKiri.SelectedIndices.Count - 1; x >= 0; x--)
                {
                    int idx = lBoxKiri.SelectedIndices[x];
                    lBoxKiri.Items.RemoveAt(idx);
                }
                for (int x = lBoxKanan.SelectedIndices.Count - 1; x >= 0; x--)
                {
                    int idx1 = lBoxKanan.SelectedIndices[x];
                    lBoxKanan.Items.RemoveAt(idx1);
                }
            }
        }
    }
}
