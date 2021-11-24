
namespace CapaVistaInventario
{
    partial class frmTipoMovimiento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDTM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreTM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DGVTipoMov = new System.Windows.Forms.DataGridView();
            this.radBtnAct = new System.Windows.Forms.RadioButton();
            this.radBtnInac = new System.Windows.Forms.RadioButton();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.navegador1 = new DLL.nav.navegador();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTipoMov)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Tipo Movimiento";
            // 
            // txtIDTM
            // 
            this.txtIDTM.Location = new System.Drawing.Point(43, 170);
            this.txtIDTM.Name = "txtIDTM";
            this.txtIDTM.Size = new System.Drawing.Size(100, 20);
            this.txtIDTM.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // NombreTM
            // 
            this.NombreTM.Location = new System.Drawing.Point(43, 236);
            this.NombreTM.Name = "NombreTM";
            this.NombreTM.Size = new System.Drawing.Size(100, 20);
            this.NombreTM.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estatus";
            // 
            // DGVTipoMov
            // 
            this.DGVTipoMov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTipoMov.Location = new System.Drawing.Point(321, 125);
            this.DGVTipoMov.Name = "DGVTipoMov";
            this.DGVTipoMov.Size = new System.Drawing.Size(448, 150);
            this.DGVTipoMov.TabIndex = 6;
            // 
            // radBtnAct
            // 
            this.radBtnAct.AutoSize = true;
            this.radBtnAct.Location = new System.Drawing.Point(49, 308);
            this.radBtnAct.Name = "radBtnAct";
            this.radBtnAct.Size = new System.Drawing.Size(32, 17);
            this.radBtnAct.TabIndex = 7;
            this.radBtnAct.TabStop = true;
            this.radBtnAct.Text = "A";
            this.radBtnAct.UseVisualStyleBackColor = true;
            // 
            // radBtnInac
            // 
            this.radBtnInac.AutoSize = true;
            this.radBtnInac.Location = new System.Drawing.Point(87, 308);
            this.radBtnInac.Name = "radBtnInac";
            this.radBtnInac.Size = new System.Drawing.Size(28, 17);
            this.radBtnInac.TabIndex = 8;
            this.radBtnInac.TabStop = true;
            this.radBtnInac.Text = "I";
            this.radBtnInac.UseVisualStyleBackColor = true;
            // 
            // txtEstatus
            // 
            this.txtEstatus.Location = new System.Drawing.Point(121, 303);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(68, 20);
            this.txtEstatus.TabIndex = 9;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Location = new System.Drawing.Point(377, 312);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(75, 23);
            this.BtnIngresar.TabIndex = 10;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(514, 312);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(75, 23);
            this.BtnModificar.TabIndex = 11;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(656, 312);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 12;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tipo Movimiento";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(0, 1);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 14;
            // 
            // frmTipoMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(861, 450);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.radBtnInac);
            this.Controls.Add(this.radBtnAct);
            this.Controls.Add(this.DGVTipoMov);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NombreTM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDTM);
            this.Controls.Add(this.label1);
            this.Name = "frmTipoMovimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTipoMovimiento";
            ((System.ComponentModel.ISupportInitialize)(this.DGVTipoMov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDTM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreTM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGVTipoMov;
        private System.Windows.Forms.RadioButton radBtnAct;
        private System.Windows.Forms.RadioButton radBtnInac;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label label4;
        private DLL.nav.navegador navegador1;
    }
}