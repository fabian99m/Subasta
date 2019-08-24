namespace Subasta
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tabla = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.ofer_dep = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ofer_ced = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ofer_nom = new System.Windows.Forms.TextBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.groupBox1.Controls.Add(this.tabla);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.ofer_dep);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.ofer_ced);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.ofer_nom);
			this.groupBox1.Location = new System.Drawing.Point(-7, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(583, 559);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ofertantes";
			// 
			// tabla
			// 
			this.tabla.AllowUserToAddRows = false;
			this.tabla.AllowUserToDeleteRows = false;
			this.tabla.AllowUserToResizeColumns = false;
			this.tabla.AllowUserToResizeRows = false;
			this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tabla.Location = new System.Drawing.Point(73, 286);
			this.tabla.Name = "tabla";
			this.tabla.ReadOnly = true;
			this.tabla.RowHeadersWidth = 35;
			this.tabla.RowTemplate.Height = 24;
			this.tabla.Size = new System.Drawing.Size(452, 243);
			this.tabla.TabIndex = 7;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.SkyBlue;
			this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(214, 223);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(157, 33);
			this.button1.TabIndex = 6;
			this.button1.Text = "Guardar";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.GuardarOfertantes);
			// 
			// ofer_dep
			// 
			this.ofer_dep.Location = new System.Drawing.Point(284, 164);
			this.ofer_dep.Name = "ofer_dep";
			this.ofer_dep.Size = new System.Drawing.Size(157, 22);
			this.ofer_dep.TabIndex = 5;
			this.ofer_dep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox3_KeyPress);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(124, 167);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(113, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "Ingrese deposito";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(124, 101);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Ingrese cédula ";
			// 
			// ofer_ced
			// 
			this.ofer_ced.Location = new System.Drawing.Point(284, 101);
			this.ofer_ced.Name = "ofer_ced";
			this.ofer_ced.Size = new System.Drawing.Size(157, 22);
			this.ofer_ced.TabIndex = 2;
			this.ofer_ced.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox2_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(122, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Ingrese nombre";
			// 
			// ofer_nom
			// 
			this.ofer_nom.Location = new System.Drawing.Point(284, 42);
			this.ofer_nom.Name = "ofer_nom";
			this.ofer_nom.Size = new System.Drawing.Size(157, 22);
			this.ofer_nom.TabIndex = 0;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(587, 594);
			this.tabControl1.TabIndex = 2;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.Transparent;
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(579, 565);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Ofertantes";
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(579, 565);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Celulares";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			this.tabPage3.Location = new System.Drawing.Point(4, 25);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(579, 565);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Ofertas";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(630, 602);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Subasta del pueblo";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox ofer_nom;
		private System.Windows.Forms.TextBox ofer_dep;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox ofer_ced;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.DataGridView tabla;
	}
}

