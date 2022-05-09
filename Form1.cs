using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WF_Projeto_Prova2.Aula;

namespace WF_Projeto_Prova2
{
    public partial class Form1 : Form
    {
        List<Aula> nomesDasAulas = RepositorioAula.InicializarAula();
       

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(Aula aulas in nomesDasAulas)
            {
                cmbAula.Items.Add(aulas);
            }       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbAula.SelectedIndex == 0)
            {
                Telas.TurmaIngles fromIngles = new Telas.TurmaIngles();
                fromIngles.Show();
            }

            if (cmbAula.SelectedIndex == 1)
            {
                Telas.TurmaDanca fromDanca = new Telas.TurmaDanca();
                fromDanca.Show();
            }
        }
    }
}
