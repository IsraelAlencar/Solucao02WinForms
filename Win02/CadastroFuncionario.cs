using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win02.Modelo;
using Win02.Banco;
using System.ComponentModel.DataAnnotations;

namespace Win02
{
    public partial class CadastroFuncionario : Form
    {
        private TelaPrincipal telaprincipal;
        public CadastroFuncionario(TelaPrincipal tela)
        {
            telaprincipal = tela;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void SalvarAction(object sender, EventArgs e)
        {
            //Mover os dados para a Classe Funcionario
            Funcionario funcionario = new Funcionario();
            funcionario.Name = txtNome.Text;
            funcionario.Email = txtEmail.Text;
            funcionario.Salario = decimal.Parse(txtSalario.Text);
            funcionario.Sexo = (rbMasculino.Checked) ? "M" : "F";
            funcionario.TipoContrato = (rbClt.Checked) ? "CLT" : (rbPj.Checked) ? "PJ" : "AUT";
            funcionario.DataCadastro = DateTime.Now;

            //Validar os dados
            List<ValidationResult> ListError = new List<ValidationResult>();
            ValidationContext contexto = new ValidationContext(funcionario);
            bool Validado = Validator.TryValidateObject(funcionario, contexto, ListError, true);

            if (Validado)
            {
                //Salvar os dados
                //Fechar e atualizar a TelaPrincipal

                if (FuncionarioDataAccess.SalvarFuncionarios(funcionario))
                {
                    //Sucesso
                    telaprincipal.AtualizarTabela();
                    Close();
                }

                else {

                    //Erro
                    lblErro.Text = "Erro na inserção - Banco!";
                }
            }

            else {
                //Validação Erro.
                StringBuilder sb = new StringBuilder();
                foreach (ValidationResult erro in ListError) {
                    sb.Append(erro.ErrorMessage + "\n");
                }

                lblErro.Text = sb.ToString();
            }

            //Salvar os dados
            //Fechar e atualizar a TelaPrincipal
        }
    }
}
