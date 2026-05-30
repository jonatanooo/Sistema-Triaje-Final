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
	// Token: 0x02000008 RID: 8
	public partial class HistorialPaciente : Form
	{
		// Token: 0x06000059 RID: 89 RVA: 0x00008688 File Offset: 0x00006888
		public HistorialPaciente(int DoctorLogueado)
		{
			this.InitializeComponent();
			this.IDDoctorActual = DoctorLogueado;
		}

		private void txtbusqueda_Enter(object sender, EventArgs e)
		{
			bool flag = this.txtidpaciente.Text == "Ingrese ID del Paciente";
			if (flag)
			{
				this.txtidpaciente.Text = "";
				this.txtidpaciente.ForeColor = Color.Black;
			}
		}

	
		private void btncancelar_Click(object sender, EventArgs e)
		{
			VistaPacientes abrirvistapaciente = new VistaPacientes(this.IDDoctorActual);
			abrirvistapaciente.Show();
			base.Hide();
		}

	
		private void btningresar_Click(object sender, EventArgs e)
		{
			bool flag = string.IsNullOrWhiteSpace(this.txtapellido.Text) && string.IsNullOrWhiteSpace(this.txtnombre.Text) && string.IsNullOrWhiteSpace(this.txtidpaciente.Text) && string.IsNullOrWhiteSpace(this.txtidregistro.Text);
			if (flag)
			{
				this.CargarDatos();
			}
			using (TriajeClinicoContext db = new TriajeClinicoContext())
			{
				var vistaPersonalizada = from t1 in db.RegistrosTriajes
				join t2 in db.Pacientes on t1.IdPaciente equals (int?)t2.IdPaciente
				where t1.EstadoAtencion == "Atendido"
				orderby t1.IdNivelAsignado, t1.FechaHoraIngreso
				select new
				{
					Id_Registro = t1.IdRegistro,
					Color_Nivel = "",
					Nivel = t1.IdNivelAsignado,
					Nombres = t2.Nombres,
					Apellidos = t2.Apellidos,
					DUI_Paciente = t2.DuiPaciente,
					FechaIngreso = t1.FechaHoraIngreso,
					Motivo = t1.MotivoConsulta,
					EstadoMental = t1.EstadoMental,
					MecanismoLesion = t1.MecanismoLesion,
					Temperatura = t1.Temperatura,
					NivelDolor = t1.NivelDolor,
					SaturacionO2 = t1.SaturacionO2,
					EstadoAtencion = t1.EstadoAtencion,
					MotivoConsulta = t1.MotivoConsulta
				};
				bool flag2 = !string.IsNullOrWhiteSpace(this.txtnombre.Text);
				if (flag2)
				{
					vistaPersonalizada = from x in vistaPersonalizada
					where x.Nombres.Contains(this.txtnombre.Text)
					select x;
				}
				bool flag3 = !string.IsNullOrWhiteSpace(this.txtapellido.Text);
				if (flag3)
				{
					vistaPersonalizada = from x in vistaPersonalizada
					where x.Apellidos.Contains(this.txtapellido.Text)
					select x;
				}
				bool flag4 = !string.IsNullOrWhiteSpace(this.txtidpaciente.Text);
				if (flag4)
				{
					vistaPersonalizada = from x in vistaPersonalizada
					where x.DUI_Paciente == this.txtidpaciente.Text
					select x;
				}
				int idRegistro;
				bool flag5 = int.TryParse(this.txtidregistro.Text, out idRegistro);
				if (flag5)
				{
					vistaPersonalizada = from x in vistaPersonalizada
					where x.Id_Registro == idRegistro
					select x;
				}
				this.dgvhistorial.DataSource = vistaPersonalizada.ToList();
				this.dgvhistorial.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
				this.dgvhistorial.RowTemplate.Height = 40;
				this.dgvhistorial.Columns["Color_Nivel"].Width = 150;
				foreach (object obj in ((IEnumerable)this.dgvhistorial.Rows))
				{
					DataGridViewRow row = (DataGridViewRow)obj;
					row.Height = 40;
				}
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000091F0 File Offset: 0x000073F0
		private void CargarDatos()
		{
			using (TriajeClinicoContext db = new TriajeClinicoContext())
			{
				var vistaPersonalizada = (from t1 in db.RegistrosTriajes
				join t2 in db.Pacientes on t1.IdPaciente equals (int?)t2.IdPaciente
				where t1.EstadoAtencion == "Atendido" || t1.EstadoAtencion == "Abandono"
				orderby t1.IdNivelAsignado, t1.FechaHoraIngreso
				select new
				{
					Id_Registro = t1.IdRegistro,
					Color_Nivel = "",
					Nivel = t1.IdNivelAsignado,
					Nombres = t2.Nombres,
					Apellidos = t2.Apellidos,
					DUI_Paciente = t2.DuiPaciente,
					FechaIngreso = t1.FechaHoraIngreso,
					Motivo = t1.MotivoConsulta,
					EstadoMental = t1.EstadoMental,
					MecanismoLesion = t1.MecanismoLesion,
					Temperatura = t1.Temperatura,
					NivelDolor = t1.NivelDolor,
					SaturacionO2 = t1.SaturacionO2,
					EstadoAtencion = t1.EstadoAtencion,
					MotivoConsulta = t1.MotivoConsulta
				}).ToList();
				this.dgvhistorial.DataSource = vistaPersonalizada;
				this.dgvhistorial.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
				this.dgvhistorial.RowTemplate.Height = 40;
				this.dgvhistorial.Columns["Color_Nivel"].Width = 150;
				foreach (object obj in ((IEnumerable)this.dgvhistorial.Rows))
				{
					DataGridViewRow row = (DataGridViewRow)obj;
					row.Height = 40;
				}
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

		private void HistorialPaciente_Load(object sender, EventArgs e)
		{
			this.CargarDatos();
		}

		
		private void dgvhistorial_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			bool flag = e.RowIndex >= 0 && e.ColumnIndex >= 0 && this.dgvhistorial.Columns[e.ColumnIndex].Name == "Color_Nivel";
			if (flag)
			{
				e.Paint(e.CellBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border | DataGridViewPaintParts.ContentBackground | DataGridViewPaintParts.ErrorIcon | DataGridViewPaintParts.Focus | DataGridViewPaintParts.SelectionBackground);
				object valorCelda = this.dgvhistorial.Rows[e.RowIndex].Cells["Nivel"].Value;
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

		// Token: 0x04000079 RID: 121
		private int IDDoctorActual;
	}
}
