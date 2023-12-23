using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace RevitEasy.CoatingCalculateForm
{
    public partial class CoatingCalculateForm : System.Windows.Forms.Form

    {

        // Construtor do formulário
        public CoatingCalculateForm()
        {
            InitializeComponent();
            
        }

        // Método chamado ao carregar o formulário
        private void CoatingCalculatForm_Load(object sender, EventArgs e)
        {

        }


        #region Métodos para converter os valores dos inputs do usuário em texto
        // Métodos para converter os valores dos inputs do usuário em texto
        public string CoatingCalculateRoomSideA => this.Tb_CoatingCalculateRoomSideA.Text;
        public string CoatingCalculateRoomSideB => this.Tb_CoatingCalculateRoomSideB.Text;
        public string CoatingCalculateCoatingSideA => this.Tb_CoatingCalculateCoatingSideA.Text;
        public string TbCoatingCalculateCoatingSideB => this.Tb_CoatingCalculateCoatingSideB.Text;

        #endregion

        private void SicCoatingCalculateRoomSideB(object sender, EventArgs e)
        {
            //Verifica se o os campos estão vazios

            if (string.IsNullOrEmpty(this.Tb_CoatingCalculateRoomSideA.Text) || string.IsNullOrEmpty(this.Tb_CoatingCalculateRoomSideB.Text))
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }

            //Calcula a área do ambiente
            double roomSideA = Convert.ToDouble(this.Tb_CoatingCalculateRoomSideA.Text);
            double roomSideB = Convert.ToDouble(this.Tb_CoatingCalculateRoomSideB.Text);
            double roomArea = roomSideA * roomSideB;

            //Coloca o resultado no Label da área do ambiente Lb_CoatingCalculateRoomAreaWatch
            this.Lb_CoatingCalculateRoomAreaWatch.Text = roomArea.ToString();



        }

        private void Sic_CoatingCalculateCoatingArea(object sender, EventArgs e)
        {
            //Verifica se o os campos estão vazios
            if (string.IsNullOrEmpty(this.Tb_CoatingCalculateCoatingSideA.Text) || string.IsNullOrEmpty(this.Tb_CoatingCalculateCoatingSideB.Text))
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }

            //Calcula a área do revestimento
            double coatingSideA = Convert.ToDouble(this.Tb_CoatingCalculateCoatingSideA.Text);
            double coatingSideB = Convert.ToDouble(this.Tb_CoatingCalculateCoatingSideB.Text);
            double coatingArea = coatingSideA * coatingSideB;

            //Coloca o resultado no Label da área do revestimento Lb_CoatingCalculateCoatingAreaWatch
            this.Lb_CoatingCalculateCoatingAreaWatch.Text = coatingArea.ToString();
        }

        private void Btn_CoatingCalculateCalculate_Click(object sender, EventArgs e)
        {
            // Verifica se os campos estão vazios
            if (string.IsNullOrEmpty(this.Tb_CoatingCalculateRoomSideA.Text) ||
                string.IsNullOrEmpty(this.Tb_CoatingCalculateRoomSideB.Text) ||
                string.IsNullOrEmpty(this.Tb_CoatingCalculateCoatingSideA.Text) ||
                string.IsNullOrEmpty(this.Tb_CoatingCalculateCoatingSideB.Text))
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }

            try
            {
                // Calcula a área do ambiente
                double roomSideA = Convert.ToDouble(this.Tb_CoatingCalculateRoomSideA.Text);
                double roomSideB = Convert.ToDouble(this.Tb_CoatingCalculateRoomSideB.Text);
                double roomArea = roomSideA * roomSideB;

                // Calcula a área do revestimento
                double coatingSideA = Convert.ToDouble(this.Tb_CoatingCalculateCoatingSideA.Text);
                double coatingSideB = Convert.ToDouble(this.Tb_CoatingCalculateCoatingSideB.Text);
                double coatingArea = coatingSideA * coatingSideB;

                // Calcula a quantidade de peças de revestimento necessárias
                double coatingPieces = roomArea / coatingArea;

                // Coloca o resultado no Label da área do revestimento Lb_CoatingCalculateCoatingAreaWatch
                this.Lb_CoatingCalculateCoatingAreaWatch.Text = coatingPieces.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Certifique-se de inserir valores válidos para os lados do ambiente e do revestimento.");
            }



        }
        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }
    }
}