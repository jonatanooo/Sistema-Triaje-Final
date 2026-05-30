using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Fase_1_C_.Models;
using ReaLTaiizor.Controls;

namespace Fase_1_C_
{
	// Token: 0x0200000D RID: 13
	public partial class VistaPacientes : Form
	{
		// Token: 0x0600007B RID: 123 RVA: 0x0000D449 File Offset: 0x0000B649
		public VistaPacientes(int DoctorLogueado)
		{
			this.InitializeComponent();
			this.IDDoctorActual = DoctorLogueado;
		}

	
		private void VistaPacientes_Load(object sender, EventArgs e)
		{
			this.CargarDatos();
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000D474 File Offset: 0x0000B674
		private void CargarDatos()
		{
			using (TriajeClinicoContext db = new TriajeClinicoContext())
			{
				var vistaPersonalizada = (from t1 in db.RegistrosTriajes
				join t2 in db.Pacientes on t1.IdPaciente equals (int?)t2.IdPaciente
				where t1.EstadoAtencion == "En Sala de Espera"
				orderby t1.IdNivelAsignado, t1.FechaHoraIngreso
				select new
				{
					Id_Registro = t1.IdRegistro,
					Color_Nivel = "",
					Nivel = t1.IdNivelAsignado,
					Nombres = t2.Nombres,
					Apellidos = t2.Apellidos,
					FechaIngreso = t1.FechaHoraIngreso,
					Motivo = t1.MotivoConsulta,
					EstadoMental = t1.EstadoMental,
					MecanismoLesion = t1.MecanismoLesion,
					Temperatura = t1.Temperatura,
					NivelDolor = t1.NivelDolor,
					SaturacionO2 = t1.SaturacionO2,
					EstadoAtencion = t1.EstadoAtencion
				}).ToList();
				this.dgvtriaje.DataSource = vistaPersonalizada;
				this.dgvtriaje.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
				this.dgvtriaje.RowTemplate.Height = 40;
				this.dgvtriaje.Columns["Color_Nivel"].Width = 150;
				foreach (object obj in ((IEnumerable)this.dgvtriaje.Rows))
				{
					DataGridViewRow row = (DataGridViewRow)obj;
					row.Height = 40;
				}
			}
		}

	
		private void dgvtriaje_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

	
		private void dgvtriaje_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			bool flag = e.RowIndex >= 0 && e.ColumnIndex >= 0 && this.dgvtriaje.Columns[e.ColumnIndex].Name == "Color_Nivel";
			if (flag)
			{
				e.Paint(e.CellBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border | DataGridViewPaintParts.ContentBackground | DataGridViewPaintParts.ErrorIcon | DataGridViewPaintParts.Focus | DataGridViewPaintParts.SelectionBackground);
				object valorCelda = this.dgvtriaje.Rows[e.RowIndex].Cells["Nivel"].Value;
				bool flag2 = valorCelda != null;
				if (flag2)
				{
					int nivel = Convert.ToInt32(valorCelda);
					Color backColor = Color.Gray;
					Color textColor = Color.White;
					string textLabel = "DESCONOCIDO";
					switch (nivel)
					{
					case 1:
						backColor = Color.Red;
						textLabel = "RESUCITACIÓN";
						break;
					case 2:
						backColor = Color.Orange;
						textLabel = "EMERGENCIA";
						break;
					case 3:
						backColor = Color.Yellow;
						textColor = Color.Black;
						textLabel = "URGENCIA";
						break;
					case 4:
						backColor = Color.Green;
						textLabel = "U. MENOR";
						break;
					case 5:
						backColor = Color.Blue;
						textLabel = "NO URGENTE";
						break;
					}
					e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
					e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
					int marginV = 4;
					int marginH = 8;
					Rectangle badgeArea = new Rectangle(e.CellBounds.Left + marginH, e.CellBounds.Top + marginV, e.CellBounds.Width - 2 * marginH, e.CellBounds.Height - 2 * marginV);
					using (GraphicsPath shapePath = this.GetRoundedRect(badgeArea, 10f))
					{
						using (Brush backBrush = new SolidBrush(backColor))
						{
							e.Graphics.FillPath(backBrush, shapePath);
						}
					}
					using (Font textFont = new Font("Segoe UI", 8.25f, FontStyle.Bold))
					{
						using (Brush textBrush = new SolidBrush(textColor))
						{
							using (StringFormat sf = new StringFormat())
							{
								sf.Alignment = StringAlignment.Center;
								sf.LineAlignment = StringAlignment.Center;
								e.Graphics.DrawString(textLabel, textFont, textBrush, badgeArea, sf);
							}
						}
					}
				}
				e.Handled = true;
			}
		}

	
		private GraphicsPath GetRoundedRect(RectangleF baseRect, float radius)
		{
			GraphicsPath path = new GraphicsPath();
			path.AddArc(baseRect.X, baseRect.Y, radius, radius, 180f, 90f);
			path.AddArc(baseRect.Right - radius, baseRect.Y, radius, radius, 270f, 90f);
			path.AddArc(baseRect.Right - radius, baseRect.Bottom - radius, radius, radius, 0f, 90f);
			path.AddArc(baseRect.X, baseRect.Bottom - radius, radius, radius, 90f, 90f);
			path.CloseFigure();
			return path;
		}

	
		private void dgvprueba_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
		}

	
		private void timer1_Tick(object sender, EventArgs e)
		{
			this.CargarDatos();
		}

	
		private void btncancelar_Click(object sender, EventArgs e)
		{
			MisPacientes AbrirMisPacientes = new MisPacientes(this.IDDoctorActual);
			AbrirMisPacientes.Show();
			base.Hide();
		}

	
		private void button1_Click(object sender, EventArgs e)
		{
			HistorialPaciente abrirhistorial = new HistorialPaciente(this.IDDoctorActual);
			abrirhistorial.Show();
			base.Hide();
		}

	
		private void btningresar_Click(object sender, EventArgs e)
		{
			bool flag = this.dgvtriaje.CurrentRow != null;
			if (flag)
			{
				try
				{
					int IDRegistroSelect = Convert.ToInt32(this.dgvtriaje.CurrentRow.Cells["Id_Registro"].Value);
					using (TriajeClinicoContext db = new TriajeClinicoContext())
					{
						RegistrosTriaje RegistroEditar = db.RegistrosTriajes.FirstOrDefault((RegistrosTriaje p) => p.IdRegistro == IDRegistroSelect);
						bool flag2 = RegistroEditar != null;
						if (flag2)
						{
							RegistroEditar.EstadoAtencion = "Atendido";
							RegistroEditar.IdUsuarioMedico = new int?(this.IDDoctorActual);
							db.SaveChanges();
							MessageBox.Show("Se ha ingresado al paciente", "", MessageBoxButtons.OK);
						}
						else
						{
							MessageBox.Show("No tiene ningun dato", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Ha ocurrido un error en la BD" + ex.Message, "Error de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			else
			{
				MessageBox.Show("Selecciona una fila", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

	
		private void btnatras_Click(object sender, EventArgs e)
		{
			Login abrirlogin = new Login();
			abrirlogin.Show();
			base.Hide();
		}

		
		private void button2_Click(object sender, EventArgs e)
		{
			bool flag = this.dgvtriaje.CurrentRow != null;
			if (flag)
			{
				try
				{
					int IDRegistroSelect = Convert.ToInt32(this.dgvtriaje.CurrentRow.Cells["Id_Registro"].Value);
					using (TriajeClinicoContext db = new TriajeClinicoContext())
					{
						RegistrosTriaje RegistroEditar = db.RegistrosTriajes.FirstOrDefault((RegistrosTriaje p) => p.IdRegistro == IDRegistroSelect);
						bool flag2 = RegistroEditar != null;
						if (flag2)
						{
							RegistroEditar.EstadoAtencion = "Abandono";
							RegistroEditar.IdUsuarioMedico = new int?(this.IDDoctorActual);
							db.SaveChanges();
							MessageBox.Show("El paciente ha abandonado la sala de espera", "", MessageBoxButtons.OK);
						}
						else
						{
							MessageBox.Show("No tiene ningun dato", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Ha ocurrido un error en la BD" + ex.Message, "Error de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			else
			{
				MessageBox.Show("Selecciona una fila", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		// Token: 0x0400009E RID: 158
		private int IDDoctorActual;
	}
}
