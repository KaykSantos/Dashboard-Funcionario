using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade2_WFA
{
    public partial class ExibInfoUser : Form
    {
       

        public ExibInfoUser()
        {
            InitializeComponent();
        }
        public ExibInfoUser( string nome, string email, string senha, string cpf, string rg, string logradouro, string cidade, string UF, string pais, string numero)
        {
            InitializeComponent();
            txtBoxNome.Text = nome;
            txtBoxEmail.Text = email;
            txtBoxCPF.Text = cpf;
            txtBoxRG.Text = rg;
            txtBoxLogradouro.Text = logradouro;
            txtBoxCidade.Text = cidade;
            txtBoxUF.Text = UF;
            txtBoxPais.Text = pais;
            txtBoxNumero.Text = numero;

            //string Nome = nome, Email = email, Senha = senha, CPF = cpf, RG = rg, Logradouro = logradouro, Cidade = cidade, UniFed = UF, Pais = pais, Numero = numero;
            //txtBoxNome.Text = Nome;
            //txtBoxEmail.Text = Email;
            //txtBoxCPF.Text = CPF;
            //txtBoxRG.Text = RG;
            //txtBoxLogradouro.Text = Logradouro;
            //txtBoxCidade.Text = Cidade;
            //txtBoxUF.Text = UF;
            //txtBoxPais.Text = Pais;
            //txtBoxNumero.Text = Numero;

        }
    }
}
