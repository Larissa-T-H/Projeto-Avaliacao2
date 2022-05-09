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
    public partial class TurmaDanca : Form
    {
        List<Aluno> alunosDanca = RepositorioAluno.InicializarAlunoDanca();
        public TurmaDanca()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lstbBuscar.Items.Clear();
            string busca = txtBusca.Text.ToString();

            foreach (Aluno aluno in alunosDanca)
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

        private void button2_Click(object sender, EventArgs e)
        {
            txtNome.Visible = true; txtTelefone.Visible = true; txtEmail.Visible = true;
            lblNome.Visible = true; lblTelefone.Visible = true; lblEmail.Visible = true;
            btnCadastrar.Visible = true; lstbDanca.Visible = true;              
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstbDanca.Items.Remove(lstbDanca.SelectedItem);
            lstbBuscar.Items.Remove(lstbBuscar.SelectedItem);
            MessageBox.Show("Inscrição deletada!!");
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

            lstbDanca.Items.Add($"Nome: {nome} Telefone: {telefone}  Email: {email}");
        }

        private void lstbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
        }

        private void lstbDanca_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
        }

        private void TurmaDanca_Load(object sender, EventArgs e)
        {           
            
            foreach (Aluno aluno in alunosDanca)
            {
                lstbDanca.Items.Add(aluno);
            }
        }
    }
}
