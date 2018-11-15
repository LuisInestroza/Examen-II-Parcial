namespace Examen___Luis_Dario
{
    partial class frmEliminarCanciones
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
            this.lbListarCancion = new System.Windows.Forms.ListBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtNombreCancion = new System.Windows.Forms.TextBox();
            this.gbEliminarCancion = new System.Windows.Forms.GroupBox();
            this.gbEliminarCancion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbListarCancion
            // 
            this.lbListarCancion.FormattingEnabled = true;
            this.lbListarCancion.ItemHeight = 20;
            this.lbListarCancion.Location = new System.Drawing.Point(11, 27);
            this.lbListarCancion.Name = "lbListarCancion";
            this.lbListarCancion.Size = new System.Drawing.Size(280, 224);
            this.lbListarCancion.TabIndex = 0;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(297, 74);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(131, 20);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre Canción:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(358, 157);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(91, 37);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtNombreCancion
            // 
            this.txtNombreCancion.Location = new System.Drawing.Point(434, 71);
            this.txtNombreCancion.Name = "txtNombreCancion";
            this.txtNombreCancion.Size = new System.Drawing.Size(149, 26);
            this.txtNombreCancion.TabIndex = 3;
            // 
            // gbEliminarCancion
            // 
            this.gbEliminarCancion.Controls.Add(this.lbListarCancion);
            this.gbEliminarCancion.Controls.Add(this.txtNombreCancion);
            this.gbEliminarCancion.Controls.Add(this.lbNombre);
            this.gbEliminarCancion.Controls.Add(this.btnEliminar);
            this.gbEliminarCancion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEliminarCancion.Location = new System.Drawing.Point(24, 12);
            this.gbEliminarCancion.Name = "gbEliminarCancion";
            this.gbEliminarCancion.Size = new System.Drawing.Size(589, 266);
            this.gbEliminarCancion.TabIndex = 4;
            this.gbEliminarCancion.TabStop = false;
            this.gbEliminarCancion.Text = "Eliminar Canciones";
            // 
            // frmEliminarCanciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 293);
            this.Controls.Add(this.gbEliminarCancion);
            this.Name = "frmEliminarCanciones";
            this.Text = "Eliminar Canciones";
            this.gbEliminarCancion.ResumeLayout(false);
            this.gbEliminarCancion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbListarCancion;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtNombreCancion;
        private System.Windows.Forms.GroupBox gbEliminarCancion;
    }
}