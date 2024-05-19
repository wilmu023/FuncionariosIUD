using System;
using System.Windows.Forms;

namespace FuncionariosIUD
{
    public partial class Form1 : Form
    {
        private IFuncionarioDAO funcionarioDAO;

        public Form1()
        {
            InitializeComponent(GetLabel1());
            funcionarioDAO = new FuncionarioDAOImpl();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            var funcionario = new Funcionario
            {
                TipoIdentificacion = txtTipoIdentificacion.Text,
                NumeroIdentificacion = txtNumeroIdentificacion.Text,
                Nombres = txtNombres.Text,
                Apellidos = txtApellidos.Text,
                EstadoCivil = txtEstadoCivil.Text,
                Sexo = txtSexo.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                FechaNacimiento = dtpFechaNacimiento.Value
            };
            funcionarioDAO.Add(funcionario);
            MessageBox.Show("Funcionario añadido con éxito.");
            RefreshGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var funcionario = new Funcionario
            {
                Id = int.Parse(txtId.Text),
                TipoIdentificacion = txtTipoIdentificacion.Text,
                NumeroIdentificacion = txtNumeroIdentificacion.Text,
                Nombres = txtNombres.Text,
                Apellidos = txtApellidos.Text,
                EstadoCivil = txtEstadoCivil.Text,
                Sexo = txtSexo.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                FechaNacimiento = dtpFechaNacimiento.Value
            };
            funcionarioDAO.Update(funcionario);
            MessageBox.Show("Funcionario actualizado con éxito.");
            RefreshGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            funcionarioDAO.Delete(id);
            MessageBox.Show("Funcionario eliminado con éxito.");
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = funcionarioDAO.GetAll();
        }

        private Label GetLabel1()
        {
            return label1;
        }

        private void InitializeComponent(Label label1)
        {
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 46);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(284, 261);
            Controls.Add(label1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

