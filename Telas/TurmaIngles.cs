using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WF_Projeto_Prova2.Aluno;

namespace WF_Projeto_Prova2.Telas
{
    public partial class TurmaIngles : Form
    {
        List<Aluno> alunos = RepositorioAluno.InicializarAluno();
       
        public TurmaIngles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstbIngles.Items.Remove(lstbIngles.SelectedItem);
            lstbBuscar.Items.Remove(lstbBuscar.SelectedItem);
            MessageBox.Show("Inscrição deletada!!");
        }

        private void TurmaIngles_Load(object sender, EventArgs e)
        {
            foreach (Aluno aluno in alunos)
            {
                lstbIngles.Items.Add(aluno);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNome.Visible = true;  txtTelefone.Visible = true; txtEmail.Visible = true; 
            lblNome.Visible = true;  lblTelefone.Visible = true; lblEmail.Visible = true;
            btnCadastrar.Visible = true;
            lstbIngles.Visible = true;
        }

        private void lstbIngles_SelectedIndexChanged(object sender, EventArgs e)
        {           
            button1.Visible = true;   
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            txtNome.Visible = false; txtTelefone.Visible = false; txtEmail.Visible = false;
            lblNome.Visible = false; lblTelefone.Visible = false; lblEmail.Visible = false;
            btnCadastrar.Visible = false;

            string nome = txtNome.Text.ToString();
            int telefone = int.Parse(txtTelefone.Text.ToString());
            string email = txtEmail.Text.ToString();

            txtNome.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            
            lstbIngles.Items.Add($"Nome: {nome} Telefone: {telefone}  Email: {email}");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            lstbBuscar.Items.Clear();
            string busca = txtBusca.Text.ToString();


            foreach (Aluno aluno in alunos)
            {
                if (busca == aluno.Nome)
                {
                    lstbBuscar.Items.Add($"Nome: {aluno.Nome} Telefone: {aluno.Telefone}  Email: {aluno.Email}");
                }
                else
                {                   
                    button2.Visible = true;
                }
                txtBusca.Clear();
            }
        }
        private void lstbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
        }
    }
}
