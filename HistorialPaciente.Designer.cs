namespace Fase_1_C_
{
	// Token: 0x02000008 RID: 8
	public partial class HistorialPaciente : global::System.Windows.Forms.Form
	{
		// Token: 0x06000061 RID: 97 RVA: 0x00009D6C File Offset: 0x00007F6C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00009DA4 File Offset: 0x00007FA4
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.btningresar = new global::ReaLTaiizor.Controls.Button();
			this.btncancelar = new global::ReaLTaiizor.Controls.Button();
			this.dgvhistorial = new global::ReaLTaiizor.Controls.PoisonDataGridView();
			this.parrotGradientPanel1 = new global::ReaLTaiizor.Controls.ParrotGradientPanel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.txtidpaciente = new global::ReaLTaiizor.Controls.BigTextBox();
			this.txtnombre = new global::ReaLTaiizor.Controls.BigTextBox();
			this.txtidregistro = new global::ReaLTaiizor.Controls.BigTextBox();
			this.txtapellido = new global::ReaLTaiizor.Controls.BigTextBox();
			this.label16 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.dgvhistorial).BeginInit();
			this.parrotGradientPanel1.SuspendLayout();
			base.SuspendLayout();
			this.btningresar.BackColor = global::System.Drawing.Color.Transparent;
			this.btningresar.BorderColor = global::System.Drawing.Color.Black;
			this.btningresar.EnteredBorderColor = global::System.Drawing.Color.FromArgb(165, 37, 37);
			this.btningresar.EnteredColor = global::System.Drawing.Color.FromArgb(32, 34, 37);
			this.btningresar.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.btningresar.Image = null;
			this.btningresar.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btningresar.InactiveColor = global::System.Drawing.Color.MediumOrchid;
			this.btningresar.Location = new global::System.Drawing.Point(1147, 117);
			this.btningresar.Name = "btningresar";
			this.btningresar.PressedBorderColor = global::System.Drawing.Color.DeepSkyBlue;
			this.btningresar.PressedColor = global::System.Drawing.Color.DeepSkyBlue;
			this.btningresar.Size = new global::System.Drawing.Size(120, 40);
			this.btningresar.TabIndex = 78;
			this.btningresar.Text = "Buscar";
			this.btningresar.TextAlignment = global::System.Drawing.StringAlignment.Center;
			this.btningresar.Click += new global::System.EventHandler(this.btningresar_Click);
			this.btncancelar.BackColor = global::System.Drawing.Color.Transparent;
			this.btncancelar.BorderColor = global::System.Drawing.Color.Black;
			this.btncancelar.EnteredBorderColor = global::System.Drawing.Color.FromArgb(165, 37, 37);
			this.btncancelar.EnteredColor = global::System.Drawing.Color.FromArgb(32, 34, 37);
			this.btncancelar.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.btncancelar.Image = null;
			this.btncancelar.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btncancelar.InactiveColor = global::System.Drawing.Color.LightCoral;
			this.btncancelar.Location = new global::System.Drawing.Point(694, 724);
			this.btncancelar.Name = "btncancelar";
			this.btncancelar.PressedBorderColor = global::System.Drawing.Color.DeepSkyBlue;
			this.btncancelar.PressedColor = global::System.Drawing.Color.DeepSkyBlue;
			this.btncancelar.Size = new global::System.Drawing.Size(120, 40);
			this.btncancelar.TabIndex = 77;
			this.btncancelar.Text = "Regresar";
			this.btncancelar.TextAlignment = global::System.Drawing.StringAlignment.Center;
			this.btncancelar.Click += new global::System.EventHandler(this.btncancelar_Click);
			this.dgvhistorial.AllowUserToResizeRows = false;
			this.dgvhistorial.BackgroundColor = global::System.Drawing.Color.FromArgb(255, 255, 255);
			this.dgvhistorial.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.dgvhistorial.CellBorderStyle = global::System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvhistorial.ColumnHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = global::System.Drawing.Color.FromArgb(0, 174, 219);
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("Segoe UI", 11f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.Color.FromArgb(255, 255, 255);
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.Color.FromArgb(0, 198, 247);
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dgvhistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dgvhistorial.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 255);
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Segoe UI", 11f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.Color.FromArgb(136, 136, 136);
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.Color.FromArgb(0, 198, 247);
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
			dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.dgvhistorial.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvhistorial.EnableHeadersVisualStyles = false;
			this.dgvhistorial.Font = new global::System.Drawing.Font("Segoe UI", 11f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Pixel);
			this.dgvhistorial.GridColor = global::System.Drawing.Color.White;
			this.dgvhistorial.Location = new global::System.Drawing.Point(12, 239);
			this.dgvhistorial.Name = "dgvhistorial";
			this.dgvhistorial.RowHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = global::System.Drawing.Color.FromArgb(0, 174, 219);
			dataGridViewCellStyle3.Font = new global::System.Drawing.Font("Segoe UI", 11f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = global::System.Drawing.Color.FromArgb(255, 255, 255);
			dataGridViewCellStyle3.SelectionBackColor = global::System.Drawing.Color.FromArgb(0, 198, 247);
			dataGridViewCellStyle3.SelectionForeColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
			dataGridViewCellStyle3.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dgvhistorial.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvhistorial.RowHeadersWidthSizeMode = global::System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvhistorial.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvhistorial.Size = new global::System.Drawing.Size(1411, 470);
			this.dgvhistorial.TabIndex = 76;
			this.dgvhistorial.CellPainting += new global::System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvhistorial_CellPainting);
			this.parrotGradientPanel1.BottomLeft = global::System.Drawing.Color.DarkMagenta;
			this.parrotGradientPanel1.BottomRight = global::System.Drawing.Color.Crimson;
			this.parrotGradientPanel1.CompositingQualityType = global::System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
			this.parrotGradientPanel1.Controls.Add(this.label1);
			this.parrotGradientPanel1.InterpolationType = global::System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
			this.parrotGradientPanel1.Location = new global::System.Drawing.Point(-4, 0);
			this.parrotGradientPanel1.Name = "parrotGradientPanel1";
			this.parrotGradientPanel1.PixelOffsetType = global::System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
			this.parrotGradientPanel1.PrimerColor = global::System.Drawing.Color.White;
			this.parrotGradientPanel1.Size = new global::System.Drawing.Size(1473, 66);
			this.parrotGradientPanel1.SmoothingType = global::System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.parrotGradientPanel1.Style = global::ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
			this.parrotGradientPanel1.TabIndex = 75;
			this.parrotGradientPanel1.TextRenderingType = global::System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.parrotGradientPanel1.TopLeft = global::System.Drawing.Color.DeepSkyBlue;
			this.parrotGradientPanel1.TopRight = global::System.Drawing.Color.Fuchsia;
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.Font = new global::System.Drawing.Font("Century Gothic", 20.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(624, 16);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(251, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "Historial Pacientes";
			this.txtidpaciente.BackColor = global::System.Drawing.Color.Transparent;
			this.txtidpaciente.Font = new global::System.Drawing.Font("Tahoma", 11f);
			this.txtidpaciente.ForeColor = global::System.Drawing.Color.DimGray;
			this.txtidpaciente.Image = null;
			this.txtidpaciente.Location = new global::System.Drawing.Point(126, 93);
			this.txtidpaciente.MaxLength = 32767;
			this.txtidpaciente.Multiline = false;
			this.txtidpaciente.Name = "txtidpaciente";
			this.txtidpaciente.ReadOnly = false;
			this.txtidpaciente.Size = new global::System.Drawing.Size(382, 41);
			this.txtidpaciente.TabIndex = 80;
			this.txtidpaciente.TextAlignment = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.txtidpaciente.UseSystemPasswordChar = false;
			this.txtidpaciente.Enter += new global::System.EventHandler(this.txtbusqueda_Enter);
			this.txtnombre.BackColor = global::System.Drawing.Color.Transparent;
			this.txtnombre.Font = new global::System.Drawing.Font("Tahoma", 11f);
			this.txtnombre.ForeColor = global::System.Drawing.Color.DimGray;
			this.txtnombre.Image = null;
			this.txtnombre.Location = new global::System.Drawing.Point(126, 166);
			this.txtnombre.MaxLength = 32767;
			this.txtnombre.Multiline = false;
			this.txtnombre.Name = "txtnombre";
			this.txtnombre.ReadOnly = false;
			this.txtnombre.Size = new global::System.Drawing.Size(382, 41);
			this.txtnombre.TabIndex = 81;
			this.txtnombre.TextAlignment = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.txtnombre.UseSystemPasswordChar = false;
			this.txtidregistro.BackColor = global::System.Drawing.Color.Transparent;
			this.txtidregistro.Font = new global::System.Drawing.Font("Tahoma", 11f);
			this.txtidregistro.ForeColor = global::System.Drawing.Color.DimGray;
			this.txtidregistro.Image = null;
			this.txtidregistro.Location = new global::System.Drawing.Point(659, 93);
			this.txtidregistro.MaxLength = 32767;
			this.txtidregistro.Multiline = false;
			this.txtidregistro.Name = "txtidregistro";
			this.txtidregistro.ReadOnly = false;
			this.txtidregistro.Size = new global::System.Drawing.Size(382, 41);
			this.txtidregistro.TabIndex = 82;
			this.txtidregistro.TextAlignment = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.txtidregistro.UseSystemPasswordChar = false;
			this.txtapellido.BackColor = global::System.Drawing.Color.Transparent;
			this.txtapellido.Font = new global::System.Drawing.Font("Tahoma", 11f);
			this.txtapellido.ForeColor = global::System.Drawing.Color.DimGray;
			this.txtapellido.Image = null;
			this.txtapellido.Location = new global::System.Drawing.Point(659, 166);
			this.txtapellido.MaxLength = 32767;
			this.txtapellido.Multiline = false;
			this.txtapellido.Name = "txtapellido";
			this.txtapellido.ReadOnly = false;
			this.txtapellido.Size = new global::System.Drawing.Size(382, 41);
			this.txtapellido.TabIndex = 83;
			this.txtapellido.TextAlignment = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.txtapellido.UseSystemPasswordChar = false;
			this.label16.AutoSize = true;
			this.label16.Font = new global::System.Drawing.Font("Ebrima", 12f);
			this.label16.Location = new global::System.Drawing.Point(38, 113);
			this.label16.Name = "label16";
			this.label16.Size = new global::System.Drawing.Size(39, 21);
			this.label16.TabIndex = 84;
			this.label16.Text = "DUI:";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Ebrima", 12f);
			this.label2.Location = new global::System.Drawing.Point(559, 102);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(90, 21);
			this.label2.TabIndex = 85;
			this.label2.Text = "ID Registro:";
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Ebrima", 12f);
			this.label3.Location = new global::System.Drawing.Point(38, 176);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(68, 21);
			this.label3.TabIndex = 86;
			this.label3.Text = "Nombre";
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Ebrima", 12f);
			this.label4.Location = new global::System.Drawing.Point(559, 176);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(67, 21);
			this.label4.TabIndex = 87;
			this.label4.Text = "Apellido";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1465, 791);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label16);
			base.Controls.Add(this.txtapellido);
			base.Controls.Add(this.txtidregistro);
			base.Controls.Add(this.txtnombre);
			base.Controls.Add(this.txtidpaciente);
			base.Controls.Add(this.btningresar);
			base.Controls.Add(this.btncancelar);
			base.Controls.Add(this.dgvhistorial);
			base.Controls.Add(this.parrotGradientPanel1);
			base.Name = "HistorialPaciente";
			this.Text = "HistorialPaciente";
			base.Load += new global::System.EventHandler(this.HistorialPaciente_Load);
			((global::System.ComponentModel.ISupportInitialize)this.dgvhistorial).EndInit();
			this.parrotGradientPanel1.ResumeLayout(false);
			this.parrotGradientPanel1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400007A RID: 122
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400007B RID: 123
		private global::ReaLTaiizor.Controls.Button btningresar;

		// Token: 0x0400007C RID: 124
		private global::ReaLTaiizor.Controls.Button btncancelar;

		// Token: 0x0400007D RID: 125
		private global::ReaLTaiizor.Controls.PoisonDataGridView dgvhistorial;

		// Token: 0x0400007E RID: 126
		private global::ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;

		// Token: 0x0400007F RID: 127
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000080 RID: 128
		private global::ReaLTaiizor.Controls.BigTextBox txtidpaciente;

		// Token: 0x04000081 RID: 129
		private global::ReaLTaiizor.Controls.BigTextBox txtnombre;

		// Token: 0x04000082 RID: 130
		private global::ReaLTaiizor.Controls.BigTextBox txtidregistro;

		// Token: 0x04000083 RID: 131
		private global::ReaLTaiizor.Controls.BigTextBox txtapellido;

		// Token: 0x04000084 RID: 132
		private global::System.Windows.Forms.Label label16;

		// Token: 0x04000085 RID: 133
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000086 RID: 134
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000087 RID: 135
		private global::System.Windows.Forms.Label label4;
	}
}
