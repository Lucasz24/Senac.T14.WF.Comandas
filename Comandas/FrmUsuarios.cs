using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comandas
{
    public partial class FrmUsuarios : Form
    {
        private bool ehNovo;

        public FrmUsuarios()
        {
            InitializeComponent();
            // metodo que lista os usuarios
            ListarUsuarios();
        }

        private void ListarUsuarios()
        {
            // 1. conectar no banco
            using (var banco = new AppDbContext())
            {
                // 2. SELECT * FROM usuarios 
                var usuarios = banco.Usuarios.ToList();
                // 3. Popular a tabela na tela DataGridView
                dgvUsuarios.DataSource = usuarios;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // metodo que irá inserir outro usuario no banco
            if (ehNovo)
                CriarUsuario();
            else
                AtualizarUsuario();
            //AtualizarUsuario();

            DesabilitarCampos();
            ListarUsuarios();
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtId.TextButton = string.Empty;
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSenha.Text = string.Empty;
        }

        private void AtualizarUsuario()
        {
            using (var banco = new AppDbContext())
            { // consulta um usuario na tabela usando o Id da tela
                var usuario = banco
                    .Usuarios
                    .Where(e => e.Id == int.Parse(txtId.TextButton))
                    .FirstOrDefault();

                usuario.Nome = txtNome.TextButton;
                usuario.Email = txtEmail.TextButton;
                usuario.Senha = txtSenha.TextButton;
                banco.SaveChanges();

            }
        }


        private void CriarUsuario()
        {
            // acessar o banco
            using (var banco = new AppDbContext())
            {
                // criar um novo usuario
                var novoUsuario = new Usuario();

                // atribuimos as propriedades do usuario
                novoUsuario.Nome = txtNome.TextButton;
                novoUsuario.Email = txtEmail.TextButton;
                novoUsuario.Senha = txtSenha.TextButton;
                // salvar as alterações(INSERT INTO usuarios)
                banco.Usuarios.Add(novoUsuario);
                banco.SaveChanges();

                MessageBox.Show("Usuário cadastrado com sucesso.");
            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ehNovo = true;
            HabilitarCampos();
        }

        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtSenha.Enabled = true;
        }
        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtSenha.Enabled = false;
        }



        private void thunderLabel3_Click(object sender, EventArgs e)
        {

        }

        private void thunderLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Indica que esta editando um usuario
            ehNovo = false;
        }
    }
}
