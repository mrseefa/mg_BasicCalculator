using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Calculator : Form
    {
        private string _Islem;
        private int _FirstNum;

        public Calculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        //basıldığında 1 yazar
        private void button6_Click(object sender, EventArgs e)
        {
            
            if (lblTotal.Text =="0") { lblTotal.Text = "1"; }
            else{ lblTotal.Text += "1"; }
            
        }

        //çarpma
        private void button14_Click(object sender, EventArgs e)
        {
            _FirstNum = Convert.ToInt32(lblTotal.Text);
            _Islem = "*";
            lblTotal.Text = "";
        }

        private void lblTotal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupCalculator_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //basıldığında 7 yazar
        private void btnNum7_Click(object sender, EventArgs e)
        {
            if (lblTotal.Text == "0") { lblTotal.Text = "7"; }
            else { lblTotal.Text += "7"; }
        }

        //basıldığında 6 yazar
        private void btnNum6_Click(object sender, EventArgs e)
        {
            if (lblTotal.Text == "0") { lblTotal.Text = "6"; }
            else { lblTotal.Text += "6"; }
        }

        //basıldığında 8 yazar
        private void btnNum8_Click(object sender, EventArgs e)
        {
            
            if (lblTotal.Text == "0") { lblTotal.Text = "8"; }
            else { lblTotal.Text += "8"; }
        }

        //basıldığında 9 yazar
        private void btnNum9_Click(object sender, EventArgs e)
        {
            
            if (lblTotal.Text == "0") { lblTotal.Text = "9"; }
            else { lblTotal.Text += "9"; }
        }

        //toplama
        private void btnAddition_Click(object sender, EventArgs e)
        {
            
            _FirstNum = Convert.ToInt32(lblTotal.Text);
            _Islem = "+";
            lblTotal.Text = "";
        }

        //basıldığında 4 yazar
        private void btnNum4_Click(object sender, EventArgs e)
        {
          
            if (lblTotal.Text == "0") { lblTotal.Text = "4"; }
            else { lblTotal.Text += "4"; }
        }

        //basıldığında 5 yazar
        private void btnNum5_Click(object sender, EventArgs e)
        {
           
            if (lblTotal.Text == "0") { lblTotal.Text = "5"; }
            else { lblTotal.Text += "5"; }
        }

        //basıldığında 3 yazar
        private void btnNum3_Click(object sender, EventArgs e)
        {
           
            if (lblTotal.Text == "0") { lblTotal.Text = "3"; }
            else { lblTotal.Text += "3"; }
        }

        //basıldığında 2 yazar
        private void btnNum2_Click(object sender, EventArgs e)
        {
           
            if (lblTotal.Text == "0") { lblTotal.Text = "2"; }
            else { lblTotal.Text+= "2"; }
        }

        //çıkarma
        private void btnExtraction_Click(object sender, EventArgs e)
        {
            _FirstNum = Convert.ToInt32(lblTotal.Text);
            _Islem = "-";
            lblTotal.Text = "";
        }

        //basıldığında 0 yazar
        private void btnNum0_Click(object sender, EventArgs e)
        {
            if (lblTotal.Text == "0") { lblTotal.Text = "0"; }
            else { lblTotal.Text += "0"; }
        }

        //bölme
        private void btnDivision_Click(object sender, EventArgs e)
        {
            _FirstNum = Convert.ToInt32(lblTotal.Text);
            _Islem = "/";
            lblTotal.Text = "";
        }

        // nokta koyar ama hesaplama yanlış çıkıyor koyunca
        private void btnPoint_Click(object sender, EventArgs e)
        {
            lblTotal.Text += ".";
        }
        
        
        //sonuçlar
        private void btnEqual_Click(object sender, EventArgs e)
        {
            int _SecNum = Convert.ToInt32(lblTotal.Text);
            int sonuc;
            switch (_Islem)
            {
                case "+":
                    
                    sonuc = _FirstNum + _SecNum;
                    lblTotal.Text = Convert.ToString(sonuc);
                    break;

                case "-":
                    sonuc = _FirstNum - _SecNum;
                    lblTotal.Text = Convert.ToString(sonuc); 
                    break;

                case "/":
                    sonuc = _FirstNum / _SecNum;
                    lblTotal.Text = Convert.ToString(sonuc); 
                    break;

                case "*":
                    sonuc = _FirstNum * _SecNum;
                    lblTotal.Text = Convert.ToString(sonuc); break;
                    
                default: sonuc = 0; 
                    break;
            }

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        //ekrandaki tüm sayıları silme
        private void button2_Click(object sender, EventArgs e)
        {
            lblTotal.Text = "";
        }
        //son yazılan rakamı silme
        private void button1_Click(object sender, EventArgs e)
        {
            if (lblTotal.Text.Length > 0)
            {
                lblTotal.Text = lblTotal.Text.Substring(0, lblTotal.Text.Length - 1);
            }
        }
    }
}
