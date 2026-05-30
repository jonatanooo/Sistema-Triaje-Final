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
	// Token: 0x0200000A RID: 10
	public partial class MisPacientes : Form
	{
		// Token: 0x0600006D RID: 109 RVA: 0x0000BA41 File Offset: 0x00009C41
		public MisPacientes(int DoctorLogueado)
		{
			this.InitializeComponent();
			this.IDDoctorActual = DoctorLogueado;
			this.CargarDatos();
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000BA68 File Offset: 0x00009C68
		private void CargarDatos()
		{
			using (TriajeClinicoContext db = new TriajeClinicoContext())
			{
				var vistaPersonalizada = (from t1 in db.RegistrosTriajes
				join t2 in db.Pacientes on t1.IdPaciente equals (int?)t2.IdPaciente
				where t1.EstadoAtencion == "Atendido"
				where t1.IdUsuarioMedico == (int?)this.IDDoctorActual
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
					EstadoAtencion = t1.EstadoAtencion,
					MotivoConsulta = t1.MotivoConsulta,
					Observaciones = t1.Observaciones
				}).ToList();
				this.dgvmispacientes.DataSource = vistaPersonalizada;
				this.dgvmispacientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
				this.dgvmispacientes.RowTemplate.Height = 40;
				this.dgvmispacientes.Columns["Color_Nivel"].Width = 150;
				this.dgvmispacientes.Columns["Observaciones"].Width = 400;
				foreach (object obj in ((IEnumerable)this.dgvmispacientes.Rows))
				{
					DataGridViewRow row = (DataGridViewRow)obj;
					row.Height = 40;
				}
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000C2D0 File Offset: 0x0000A4D0
		[NullableContext(1)]
		private void dgvmispacientes_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			bool flag = e.RowIndex >= 0 && e.ColumnIndex >= 0 && this.dgvmispacientes.Columns[e.ColumnIndex].Name == "Color_Nivel";
			if (flag)
			{
				e.Paint(e.CellBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border | DataGridViewPaintParts.ContentBackground | DataGridViewPaintParts.ErrorIcon | DataGridViewPaintParts.Focus | DataGridViewPaintParts.SelectionBackground);
				object valorCelda = this.dgvmispacientes.Rows[e.RowIndex].Cells["Nivel"].Value;
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

		// Token: 0x06000070 RID: 112 RVA: 0x0000C58C File Offset: 0x0000A78C
		[NullableContext(1)]
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

		// Token: 0x06000071 RID: 113 RVA: 0x0000C638 File Offset: 0x0000A838
		[NullableContext(1)]
		private void btncancelar_Click(object sender, EventArgs e)
		{
			VistaPacientes abrirvistapas = new VistaPacientes(this.IDDoctorActual);
			abrirvistapas.Show();
			base.Hide();
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000C660 File Offset: 0x0000A860
		[NullableContext(1)]
		private void txtobservaciones_Enter(object sender, EventArgs e)
		{
			bool flag = this.txtobservaciones.Text == "Escriba las observaciones del paciente o prescripciones";
			if (flag)
			{
				this.txtobservaciones.Text = "";
				this.txtobservaciones.ForeColor = Color.Black;
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000C6AC File Offset: 0x0000A8AC
		[NullableContext(1)]
		private void btningresar_Click(object sender, EventArgs e)
		{
			bool flag = this.dgvmispacientes.CurrentRow != null;
			if (flag)
			{
				try
				{
					int IDRegistro = Convert.ToInt32(this.dgvmispacientes.CurrentRow.Cells["Id_Registro"].Value);
					using (TriajeClinicoContext db = new TriajeClinicoContext())
					{
						RegistrosTriaje RegistroObservaciones = db.RegistrosTriajes.FirstOrDefault((RegistrosTriaje x) => x.IdRegistro == IDRegistro);
						bool flag2 = RegistroObservaciones != null;
						if (flag2)
						{
							RegistroObservaciones.Observaciones = this.txtobservaciones.Text;
							bool flag3 = this.txtobservaciones.Text == "Escriba las observaciones del paciente o prescripciones" || string.IsNullOrWhiteSpace(this.txtobservaciones.Text);
							if (flag3)
							{
								MessageBox.Show("Debe agregar algo al campo de observaciones", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							}
							else
							{
								db.SaveChanges();
								MessageBox.Show("Se ha ingresado las observaciones");
								this.CargarDatos();
								this.txtobservaciones.Text = "Escriba las observaciones del paciente o prescripciones";
							}
						}
						else
						{
							MessageBox.Show("No hay ningun registro", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						}
					}
				}
				catch (Exception ex)
				{
					string str = "Ha ocurrido un error";
					Exception ex2 = ex;
					MessageBox.Show(str + ((ex2 != null) ? ex2.ToString() : null), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			else
			{
				MessageBox.Show("Seleccione un fila", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		// Token: 0x04000094 RID: 148
		private int IDDoctorActual;
	}
}
