using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Fase_1_C_.Models;
using Microsoft.Data.SqlClient;
using ReaLTaiizor.Controls;

namespace Fase_1_C_
{
	
	public partial class Crear_Usuario : Form
	{
		// Token: 0x0600003E RID: 62 RVA: 0x0000346C File Offset: 0x0000166C
		public Crear_Usuario()
		{
			this.InitializeComponent();
		}

	

		private void txtcrearuser_Enter(object sender, EventArgs e)
		{
			bool flag = this.txtcrearuser.Text == "Usuario";
			if (flag)
			{
				this.txtcrearuser.Text = "";
				this.txtcrearuser.ForeColor = Color.Black;
			}
		}


		private void txtcontracrear_Enter(object sender, EventArgs e)
		{
			bool flag = this.txtcontracrear.Text == "Contraseña";
			if (flag)
			{
				this.txtcontracrear.Text = "";
				this.txtcontracrear.ForeColor = Color.Black;
			}
		}

		private void txtnombres_Enter(object sender, EventArgs e)
		{
			bool flag = this.txtnombres.Text == "Nombres";
			if (flag)
			{
				this.txtnombres.Text = "";
				this.txtnombres.ForeColor = Color.Black;
			}
		}

	
		private void txtapellidos_Enter(object sender, EventArgs e)
		{
			bool flag = this.txtapellidos.Text == "Apellidos";
			if (flag)
			{
				this.txtapellidos.Text = "";
				this.txtapellidos.ForeColor = Color.Black;
			}
		}

	
		private void txtDUI_Enter(object sender, EventArgs e)
		{
			bool flag = this.txtDUI.Text == "DUI";
			if (flag)
			{
				this.txtDUI.Text = "";
				this.txtDUI.ForeColor = Color.Black;
			}
		}

	
		private void btnregistrar_Click(object sender, EventArgs e)
		{
			bool flag = string.IsNullOrWhiteSpace(this.txtcrearuser.Text) || string.IsNullOrWhiteSpace(this.txtcontracrear.Text) || string.IsNullOrWhiteSpace(this.txtDUI.Text) || string.IsNullOrWhiteSpace(this.txtnombres.Text) || string.IsNullOrWhiteSpace(this.txtapellidos.Text) || string.IsNullOrWhiteSpace(this.cbrol.Text);
			if (flag)
			{
				MessageBox.Show("No deje Campos en Blanco", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				try
				{
					using (TriajeClinicoContext db = new TriajeClinicoContext())
					{
						string ContraseñaNueva = this.txtcontracrear.Text;
                        string HashContraSegura = BCrypt.Net.BCrypt.HashPassword(ContraseñaNueva);
                        Usuario NuevoUsuario = new Usuario
						{
							DuiUsuaio = this.txtDUI.Text,
							Nombres = this.txtnombres.Text,
							Apellidos = this.txtapellidos.Text,
							Username = this.txtcrearuser.Text,
							PasswordHash = HashContraSegura,
							Rol = this.cbrol.Text
						};
						db.Usuarios.Add(NuevoUsuario);
						db.SaveChanges();
						MessageBox.Show("Usuario Registrado Con Exito", "Registro Completado", MessageBoxButtons.OK);
						this.LimpiarCampos(this);
					}
				}
				catch (Exception ex)
				{
					string MensajeError = ex.Message;
					bool flag2 = ex.InnerException != null;
					if (flag2)
					{
						MensajeError = MensajeError + "\n\nDetalle: " + ex.InnerException.Message;
					}
					MessageBox.Show("Hubo un problema al registrar el usuario.\n\n" + MensajeError, "Error");
				}
			}
		}

	
		private void btnatras_Click(object sender, EventArgs e)
		{
			Login abrirlogin = new Login();
			abrirlogin.Show();
			base.Hide();
		}


		private void LimpiarCampos(Control controlPadre)
		{
			foreach (object obj in controlPadre.Controls)
			{
				Control control = (Control)obj;
				bool flag = control is TextBox;
				if (flag)
				{
					((TextBox)control).Clear();
				}
				else
				{
					bool flag2 = control is System.Windows.Forms.CheckBox;
					if (flag2)
					{
						((System.Windows.Forms.CheckBox)control).Checked = false;
					}
					else
					{
						bool flag3 = control is System.Windows.Forms.RadioButton;
						if (flag3)
						{
							((System.Windows.Forms.RadioButton)control).Checked = false;
						}
						else
						{
							bool flag4 = control is ComboBox;
							if (flag4)
							{
								((ComboBox)control).SelectedIndex = -1;
							}
							else
							{
								bool flag5 = control is NumericUpDown;
								if (flag5)
								{
									((NumericUpDown)control).Value = 0m;
								}
							}
						}
					}
				}
				bool hasChildren = control.HasChildren;
				if (hasChildren)
				{
					this.LimpiarCampos(control);
				}
			}
		}
	}
}
