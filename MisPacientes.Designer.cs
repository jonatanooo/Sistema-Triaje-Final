namespace Fase_1_C_
{
	// Token: 0x0200000A RID: 10
	public partial class MisPacientes : global::System.Windows.Forms.Form
	{
		// Token: 0x06000074 RID: 116 RVA: 0x0000C8A8 File Offset: 0x0000AAA8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000C8E0 File Offset: 0x0000AAE0
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.btningresar = new global::ReaLTaiizor.Controls.Button();
			this.btncancelar = new global::ReaLTaiizor.Controls.Button();
			this.dgvmispacientes = new global::ReaLTaiizor.Controls.PoisonDataGridView();
			this.parrotGradientPanel1 = new global::ReaLTaiizor.Controls.ParrotGradientPanel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.txtobservaciones = new global::ReaLTaiizor.Controls.DungeonRichTextBox();
			((global::System.ComponentModel.ISupportInitialize)this.dgvmispacientes).BeginInit();
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
			this.btningresar.Location = new global::System.Drawing.Point(1222, 566);
			this.btningresar.Name = "btningresar";
			this.btningresar.PressedBorderColor = global::System.Drawing.Color.DeepSkyBlue;
			this.btningresar.PressedColor = global::System.Drawing.Color.DeepSkyBlue;
			this.btningresar.Size = new global::System.Drawing.Size(120, 40);
			this.btningresar.TabIndex = 77;
			this.btningresar.Text = "Guardar";
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
			this.btncancelar.Location = new global::System.Drawing.Point(1222, 631);
			this.btncancelar.Name = "btncancelar";
			this.btncancelar.PressedBorderColor = global::System.Drawing.Color.DeepSkyBlue;
			this.btncancelar.PressedColor = global::System.Drawing.Color.DeepSkyBlue;
			this.btncancelar.Size = new global::System.Drawing.Size(120, 40);
			this.btncancelar.TabIndex = 76;
			this.btncancelar.Text = "Volver";
			this.btncancelar.TextAlignment = global::System.Drawing.StringAlignment.Center;
			this.btncancelar.Click += new global::System.EventHandler(this.btncancelar_Click);
			this.dgvmispacientes.AllowUserToResizeRows = false;
			this.dgvmispacientes.BackgroundColor = global::System.Drawing.Color.FromArgb(255, 255, 255);
			this.dgvmispacientes.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.dgvmispacientes.CellBorderStyle = global::System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvmispacientes.ColumnHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = global::System.Drawing.Color.FromArgb(0, 174, 219);
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("Segoe UI", 11f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.Color.FromArgb(255, 255, 255);
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.Color.FromArgb(0, 198, 247);
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dgvmispacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dgvmispacientes.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 255);
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Segoe UI", 11f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.Color.FromArgb(136, 136, 136);
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.Color.FromArgb(0, 198, 247);
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
			dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.dgvmispacientes.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvmispacientes.EnableHeadersVisualStyles = false;
			this.dgvmispacientes.Font = new global::System.Drawing.Font("Segoe UI", 11f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Pixel);
			this.dgvmispacientes.GridColor = global::System.Drawing.Color.White;
			this.dgvmispacientes.Location = new global::System.Drawing.Point(31, 95);
			this.dgvmispacientes.Name = "dgvmispacientes";
			this.dgvmispacientes.RowHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = global::System.Drawing.Color.FromArgb(0, 174, 219);
			dataGridViewCellStyle3.Font = new global::System.Drawing.Font("Segoe UI", 11f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = global::System.Drawing.Color.FromArgb(255, 255, 255);
			dataGridViewCellStyle3.SelectionBackColor = global::System.Drawing.Color.FromArgb(0, 198, 247);
			dataGridViewCellStyle3.SelectionForeColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
			dataGridViewCellStyle3.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dgvmispacientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvmispacientes.RowHeadersWidthSizeMode = global::System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvmispacientes.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvmispacientes.Size = new global::System.Drawing.Size(1365, 366);
			this.dgvmispacientes.TabIndex = 75;
			this.dgvmispacientes.CellPainting += new global::System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvmispacientes_CellPainting);
			this.parrotGradientPanel1.BottomLeft = global::System.Drawing.Color.Indigo;
			this.parrotGradientPanel1.BottomRight = global::System.Drawing.Color.MediumSlateBlue;
			this.parrotGradientPanel1.CompositingQualityType = global::System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
			this.parrotGradientPanel1.Controls.Add(this.label1);
			this.parrotGradientPanel1.InterpolationType = global::System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
			this.parrotGradientPanel1.Location = new global::System.Drawing.Point(-15, 1);
			this.parrotGradientPanel1.Name = "parrotGradientPanel1";
			this.parrotGradientPanel1.PixelOffsetType = global::System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
			this.parrotGradientPanel1.PrimerColor = global::System.Drawing.Color.White;
			this.parrotGradientPanel1.Size = new global::System.Drawing.Size(1473, 66);
			this.parrotGradientPanel1.SmoothingType = global::System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.parrotGradientPanel1.Style = global::ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
			this.parrotGradientPanel1.TabIndex = 74;
			this.parrotGradientPanel1.TextRenderingType = global::System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.parrotGradientPanel1.TopLeft = global::System.Drawing.Color.DeepSkyBlue;
			this.parrotGradientPanel1.TopRight = global::System.Drawing.Color.Fuchsia;
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.Font = new global::System.Drawing.Font("Century Gothic", 20.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(639, 14);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(192, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mis Pacientes";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Segoe UI Semibold", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(31, 483);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(122, 21);
			this.label2.TabIndex = 78;
			this.label2.Text = "Observaciones:";
			this.txtobservaciones.AutoWordSelection = false;
			this.txtobservaciones.BackColor = global::System.Drawing.Color.Transparent;
			this.txtobservaciones.BorderColor = global::System.Drawing.Color.FromArgb(180, 180, 180);
			this.txtobservaciones.EdgeColor = global::System.Drawing.Color.White;
			this.txtobservaciones.Font = new global::System.Drawing.Font("Tahoma", 10f);
			this.txtobservaciones.ForeColor = global::System.Drawing.Color.FromArgb(76, 76, 76);
			this.txtobservaciones.Location = new global::System.Drawing.Point(31, 514);
			this.txtobservaciones.Name = "txtobservaciones";
			this.txtobservaciones.ReadOnly = false;
			this.txtobservaciones.Size = new global::System.Drawing.Size(1101, 229);
			this.txtobservaciones.TabIndex = 80;
			this.txtobservaciones.Text = "Escriba las observaciones del paciente o prescripciones";
			this.txtobservaciones.TextBackColor = global::System.Drawing.Color.White;
			this.txtobservaciones.WordWrap = true;
			this.txtobservaciones.Enter += new global::System.EventHandler(this.txtobservaciones_Enter);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1443, 806);
			base.Controls.Add(this.txtobservaciones);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.btningresar);
			base.Controls.Add(this.btncancelar);
			base.Controls.Add(this.dgvmispacientes);
			base.Controls.Add(this.parrotGradientPanel1);
			base.Name = "MisPacientes";
			this.Text = "MisPacientes";
			((global::System.ComponentModel.ISupportInitialize)this.dgvmispacientes).EndInit();
			this.parrotGradientPanel1.ResumeLayout(false);
			this.parrotGradientPanel1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000095 RID: 149
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000096 RID: 150
		private global::ReaLTaiizor.Controls.Button btningresar;

		// Token: 0x04000097 RID: 151
		private global::ReaLTaiizor.Controls.Button btncancelar;

		// Token: 0x04000098 RID: 152
		private global::ReaLTaiizor.Controls.PoisonDataGridView dgvmispacientes;

		// Token: 0x04000099 RID: 153
		private global::ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;

		// Token: 0x0400009A RID: 154
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400009B RID: 155
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400009C RID: 156
		private global::ReaLTaiizor.Controls.DungeonRichTextBox txtobservaciones;
	}
}
