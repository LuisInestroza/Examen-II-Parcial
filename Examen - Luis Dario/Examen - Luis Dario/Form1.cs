using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen___Luis_Dario
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de listar Canciones
            frmlistarCancion abrir = new frmlistarCancion();
            abrir.Show();
        }

        private void btnElimarCancion_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de eliminar Canciones
            frmEliminarCanciones abrir = new frmEliminarCanciones();
            abrir.Show();
        }

        private void btnActualizarCancion_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de actulizar Canciones
            frmActulizarCancion abrir = new frmActulizarCancion();
            abrir.Show();
        }

        private void btnAgregarCancion_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de agregar Canciones
            frmAgregarCancion abrir = new frmAgregarCancion();
            abrir.Show();
            
        }
    }
}
