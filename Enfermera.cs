using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Windows.Forms;
using Fase_1_C_.Models;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Extension.Poison;
using ReaLTaiizor.Helper;

namespace Fase_1_C_
{
	// Token: 0x02000007 RID: 7
	public partial class Enfermera : Form
	{
		// Token: 0x06000049 RID: 73 RVA: 0x00004B44 File Offset: 0x00002D44
		public Enfermera(int EnfermeraLogueada)
		{
			this.InitializeComponent();
			this.IDEnfermeraActual = EnfermeraLogueada;
		}

	
		private void Enfermera_Load(object sender, EventArgs e)
		{
		}

	
		private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
		{
		}

		
		private void hopeNumeric2_Click(object sender, EventArgs e)
		{
		}

		private void label10_Click(object sender, EventArgs e)
		{
		}

		
		private void label1_Click(object sender, EventArgs e)
		{
		}

	
		private void txtnombre_Enter(object sender, EventArgs e)
		{
			bool flag = this.txtnombre.Text == "Nombres";
			if (flag)
			{
				this.txtnombre.Text = "";
				this.txtnombre.ForeColor = Color.Black;
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

		private void label15_Click(object sender, EventArgs e)
		{
		}

	
		private void txtdui_Enter(object sender, EventArgs e)
		{
		}

		
		private void btningresar_Click(object sender, EventArgs e)
		{
			using (TriajeClinicoContext db = new TriajeClinicoContext())
			{
				try
				{
					string duiIngresado = string.IsNullOrWhiteSpace(this.txtdui.Text) ? null : this.txtdui.Text;
					Paciente pacienteActual = null;
					bool flag = duiIngresado != null;
					if (flag)
					{
						pacienteActual = db.Pacientes.FirstOrDefault((Paciente p) => p.DuiPaciente == duiIngresado);
					}
					bool flag2 = pacienteActual == null;
					if (flag2)
					{
						pacienteActual = new Paciente
						{
							DuiPaciente = duiIngresado,
							Nombres = this.txtnombre.Text,
							Apellidos = this.txtapellidos.Text,
							FechaNacimiento = new DateOnly?(DateOnly.FromDateTime(this.dateedad.Value)),
							Genero = this.cbgenero.Text
						};
						db.Pacientes.Add(pacienteActual);
						db.SaveChanges();
					}
					Dictionary<string, bool> sintomas = new Dictionary<string, bool>
					{
						{
							"Desmayo",
							this.rdbDesmayoSi.Checked
						},
						{
							"HemorragiaIncontrolable",
							this.rdbHemorragiaSi.Checked
						},
						{
							"DificultadRespiratoriaSevera",
							this.rdbDificultadadResSi.Checked
						},
						{
							"TraumaCraneoencefalico",
							this.rdbTraumaCraneoSi.Checked
						},
						{
							"DolorPecho",
							this.rdbDolorPechoSi.Checked
						}
					};
                    string jsonSintomas = JsonSerializer.Serialize(sintomas);
                    RegistrosTriaje nuevoRegistro = new RegistrosTriaje
					{
						IdPaciente = new int?(pacienteActual.IdPaciente),
						IdUsuarioEnfermera = new int?(this.IDEnfermeraActual),
						FechaHoraIngreso = new DateTime?(DateTime.Now),
						MotivoConsulta = this.cbmotivo.Text,
						EstadoMental = this.cbestadomental.Text,
						MecanismoLesion = this.cbmecanismo.Text,
						TiempoEvolucion = new int?(Convert.ToInt32(this.numevolucion.ValueNumber)),
						SintomasCriticosJson = jsonSintomas,
						EstadoAtencion = "En Sala de Espera",
						Temperatura = new decimal?(Convert.ToDecimal(this.numtemperatura.ValueNumber)),
						NivelDolor = new int?(Convert.ToInt32(this.numdolor.ValueNumber)),
						SaturacionO2 = new int?(Convert.ToInt32(this.numoxigeno.ValueNumber))
					};
					bool flag3 = (this.rdbDesmayoSi.Checked && this.cbestadomental.Text == "Inconsciente") || this.rdbHemorragiaSi.Checked || this.rdbDificultadadResSi.Checked || this.rdbTraumaCraneoSi.Checked || this.rdbDolorPechoSi.Checked || this.numtemperatura.ValueNumber >= 40f || this.numtemperatura.ValueNumber <= 35f || this.numdolor.ValueNumber >= 8f || this.numoxigeno.ValueNumber < 90f || this.cbmotivo.Text == "Convulsiones / Epilepsia" || this.cbmotivo.Text == "Intoxicación / Envenenamiento / Sobredosis" || this.cbestadomental.Text == "Responde solo al dolor";
					if (flag3)
					{
						nuevoRegistro.IdNivelAsignado = new int?(1);
					}
					else
					{
						bool flag4 = (this.numoxigeno.ValueNumber <= 94f && this.numoxigeno.ValueNumber >= 90f) || ((double)this.numtemperatura.ValueNumber <= 39.9 && this.numtemperatura.ValueNumber >= 39f) || (this.numdolor.ValueNumber <= 7f && this.numdolor.ValueNumber >= 5f) || this.cbestadomental.Text == "Responde a estimulos verbales" || this.cbmotivo.Text == "Sospecha de derrame (ACV)" || this.cbmotivo.Text == "Reacción alérgica grave" || this.cbmotivo.Text == "Dolor en el pecho / Problemas cardíacos" || this.cbmotivo.Text == "Emergencia Obstétrica / Embarazo" || this.cbmecanismo.Text == "Quemadura" || this.cbmecanismo.Text == "Accidente de transito";
						if (flag4)
						{
							nuevoRegistro.IdNivelAsignado = new int?(2);
						}
						else
						{
							bool flag5 = ((double)this.numtemperatura.ValueNumber <= 38.9 && this.numtemperatura.ValueNumber >= 38f) || (this.numdolor.ValueNumber <= 4f && this.numdolor.ValueNumber >= 3f) || this.cbmecanismo.Text == "Traumatismo / Accidente leve" || this.cbmecanismo.Text == "Caída desde su propia altura" || this.cbmecanismo.Text == "Heridas cortantes" || this.cbmotivo.Text == "Dolor Abdominal / Gastrointestinal" || this.cbmotivo.Text == "Fiebre / Infección" || this.cbmotivo.Text == "Problemas Respiratorios" || this.cbmotivo.Text == "Problemas urinarios / Renales";
							if (flag5)
							{
								nuevoRegistro.IdNivelAsignado = new int?(3);
							}
							else
							{
								bool flag6 = (this.numdolor.ValueNumber <= 2f && this.numdolor.ValueNumber >= 1f) || ((double)this.numtemperatura.ValueNumber <= 37.9 && (double)this.numtemperatura.ValueNumber >= 37.5) || this.cbmotivo.Text == "Lesiones menores / Cortes superficiales" || this.cbmotivo.Text == "Problemas en la piel / Erupciones Leve " || this.cbmotivo.Text == "Dolor muscular / Articular crónico";
								if (flag6)
								{
									nuevoRegistro.IdNivelAsignado = new int?(4);
								}
								else
								{
									nuevoRegistro.IdNivelAsignado = new int?(5);
								}
							}
						}
					}
					db.RegistrosTriajes.Add(nuevoRegistro);
					db.SaveChanges();
					MessageBox.Show("El paciente se ha ingresado en la clasificacion de triaje", "Exito");
					this.LimpiarCampos(this);
				}
				catch (Exception ex)
				{
					string mensajeError = ex.Message;
					bool flag7 = ex.InnerException != null;
					if (flag7)
					{
						mensajeError = mensajeError + "\n\nDetalle de SQL Server:\n" + ex.InnerException.Message;
					}
					MessageBox.Show("Hubo un problema al guardar:\n\n" + mensajeError, "Error de Base de Datos");
				}
			}
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

		private void btncancelar_Click(object sender, EventArgs e)
		{
			Login abrir = new Login();
			abrir.Show();
			base.Hide();
		}

		private void txtnombre_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x04000043 RID: 67
		private int IDEnfermeraActual;
	}
}
