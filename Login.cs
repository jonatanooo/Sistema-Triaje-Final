using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;
using BCrypt.Net;
using Fase_1_C_;
using Fase_1_C_.Models;
using ReaLTaiizor.Controls;

namespace Fase_1_C_
{
	// Token: 0x02000009 RID: 9
	public partial class Login : Form
	{
		// Token: 0x06000063 RID: 99 RVA: 0x0000AC95 File Offset: 0x00008E95
		public Login()
		{
			this.InitializeComponent();
		}

		
		private void button1_Click(object sender, EventArgs e)
		{
		}

		private void button2_Click(object sender, EventArgs e)
		{
		}

		
		private void txtusuario_Enter(object sender, EventArgs e)
		{
			bool flag = this.txtusuario.Text == "Usuario";
			if (flag)
			{
				this.txtusuario.Text = "";
				this.txtusuario.ForeColor = Color.Black;
			}
		}

		
		private void txtcontraseña_Enter(object sender, EventArgs e)
		{
			bool flag = this.txtcontraseña.Text == "Contraseña";
			if (flag)
			{
				this.txtcontraseña.Text = "";
				this.txtcontraseña.ForeColor = Color.Black;
			}
		}

		
		private void label2_Click(object sender, EventArgs e)
		{
		}

		
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Crear_Usuario crearuser = new Crear_Usuario();
			crearuser.Show();
			base.Hide();
		}

		
		
		private void button3_Click(object sender, EventArgs e)
		{
            string UsuarioIngresado = ((Control)(object)txtusuario).Text;
            string text = ((Control)(object)txtcontraseña).Text;
            try
            {
                TriajeClinicoContext triajeClinicoContext = new TriajeClinicoContext();
                try
                {
                    Usuario usuario = ((IQueryable<Usuario>)triajeClinicoContext.Usuarios).FirstOrDefault((Usuario u) => u.Username == UsuarioIngresado);
                    if (usuario != null)
                    {
                        if (BCrypt.Net.BCrypt.Verify(text, usuario.PasswordHash))
                        {
                            MessageBox.Show("Has ingresado al sistema", "Bienvenido " + usuario.Username, MessageBoxButtons.OK);
                            if (usuario.Rol == "Doctor")
                            {
                                VistaPacientes vistaPacientes = new VistaPacientes(usuario.IdUsuario);
                                vistaPacientes.Show();
                                Hide();
                            }
                            else if (usuario.Rol == "Enfermera")
                            {
                                Enfermera enfermera = new Enfermera(usuario.IdUsuario);
                                enfermera.Show();
                                Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sus Credenciales son Incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sus Credenciales son Incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                finally
                {
                    ((IDisposable)triajeClinicoContext)?.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar conectar: " + ex.Message, "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
	}
}
