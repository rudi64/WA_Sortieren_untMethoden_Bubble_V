using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WA_Sortieren_untMethoden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] unsort, sort;
        Random zufall = new Random(2);
        private void anzeigen(int[] _array, Label _ort)
        {
            _ort.Text = "";
            for (int i = 0; i < _array.Length; i++)
            {
                _ort.Text += String.Format(" {0,4} |", _array[i]);
            }
        }

        public void selectSort(int[] arr)
        {
           //TO DO
        }

        public static void Insertionsort(int[] _unsort)
        {
            //TO DO
        }

        static public void MainMerge(int[] numbers, int left, int mid, int right)
        {
            //TO DO
        }
        static public void SortMerge(int[] numbers, int left, int right)
        {
            //TO DO
        }

        public static void Quicksort(int[] elements, int left, int right)
        {
            //TO DO
        }

        private void btn_neu_Click(object sender, EventArgs e)
        {
            lbl_sort.Text = lbl_unsort.Text = "";
            unsort = sort = new int[10];
            for (int i = 0; i < unsort.Length; i++)
            {
                unsort[i] = zufall.Next(11, 100);
            }
            anzeigen(unsort, lbl_unsort);
            Array.Copy(unsort, sort, unsort.Length);
        }

        private void btn_bubble_Click(object sender, EventArgs e)
        {
            if (sort!=null)
            {


                for (int i = 0; i < sort.Length; i++)
                {
                    for (int j = 0; j < sort.Length - 1 - i; j++)
                    {
                        if (sort[j + 1] < sort[j])
                        {
                            int dummy = sort[j];
                            sort[j] = sort[j + 1];
                            sort[j + 1] = dummy;
                        }
                    }
                }
                anzeigen(sort, lbl_sort);
            }
            else
            {
                MessageBox.Show("Erst Button neu betätigen!", "Hinweis", MessageBoxButtons.OK);
            }
            
        }

        private void btn_quick_Click(object sender, EventArgs e)
        {
            //TO DO
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            //TO DO
        }

        private void btn_merge_Click(object sender, EventArgs e)
        {
            //TO DO
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            //TO DO
        }


    }
}
