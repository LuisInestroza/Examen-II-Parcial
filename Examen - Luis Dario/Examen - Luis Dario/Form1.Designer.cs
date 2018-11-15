namespace Examen___Luis_Dario
{
    partial class frmMenu
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
            this.btnListar = new System.Windows.Forms.Button();
            this.btnElimarCancion = new System.Windows.Forms.Button();
            this.btnActualizarCancion = new System.Windows.Forms.Button();
            this.btnAgregarCancion = new System.Windows.Forms.Button();
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.gbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(40, 62);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(154, 47);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "Listar Canciones";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // btnElimarCancion
            // 
            this.btnElimarCancion.Location = new System.Drawing.Point(224, 62);
            this.btnElimarCancion.Name = "btnElimarCancion";
            this.btnElimarCancion.Size = new System.Drawing.Size(157, 47);
            this.btnElimarCancion.TabIndex = 1;
            this.btnElimarCancion.Text = "Eliminar Canción";
            this.btnElimarCancion.UseVisualStyleBackColor = true;
            // 
            // btnActualizarCancion
            // 
            this.btnActualizarCancion.Location = new System.Drawing.Point(40, 124);
            this.btnActualizarCancion.Name = "btnActualizarCancion";
            this.btnActualizarCancion.Size = new System.Drawing.Size(154, 47);
            this.btnActualizarCancion.TabIndex = 2;
            this.btnActualizarCancion.Text = "Actualizar Canción";
            this.btnActualizarCancion.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCancion
            // 
            this.btnAgregarCancion.Location = new System.Drawing.Point(224, 124);
            this.btnAgregarCancion.Name = "btnAgregarCancion";
            this.btnAgregarCancion.Size = new System.Drawing.Size(157, 47);
            this.btnAgregarCancion.TabIndex = 3;
            this.btnAgregarCancion.Text = "Agregar Canción";
            this.btnAgregarCancion.UseVisualStyleBackColor = true;
            // 
            // gbMenu
            // 
            this.gbMenu.Controls.Add(this.btnAgregarCancion);
            this.gbMenu.Controls.Add(this.btnListar);
            this.gbMenu.Controls.Add(this.btnActualizarCancion);
            this.gbMenu.Controls.Add(this.btnElimarCancion);
            this.gbMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMenu.Location = new System.Drawing.Point(12, 27);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(437, 213);
            this.gbMenu.TabIndex = 4;
            this.gbMenu.TabStop = false;
            this.gbMenu.Text = "Operaciones CRUD";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 253);
            this.Controls.Add(this.gbMenu);
            this.Name = "frmMenu";
            this.Text = "Menú Operaciones CRUD";
            this.gbMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnElimarCancion;
        private System.Windows.Forms.Button btnActualizarCancion;
        private System.Windows.Forms.Button btnAgregarCancion;
        private System.Windows.Forms.GroupBox gbMenu;
    }
}

