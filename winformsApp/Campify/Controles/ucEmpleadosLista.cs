using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    public partial class ucEmpleadosLista : UserControl
    {

        /// <summary>
        /// Representa el empleado asociado al control de usuario.
        /// </summary>
        public Empleado Empleado { get; set; }

        public ucEmpleadosLista()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Muestra en el control de usuario los datos del empleado dado como parámetro.
        /// </summary>
        /// <param name="empleado"></param>
        public void SetData(Empleado empleado)
        {
            Empleado = empleado;
            lblId.Text = "Nº: " + empleado.Id.ToString();
            lblNombre.Text = empleado.Nombre;
            lblApellidos.Text = empleado.Apellidos;
            lblPuesto.Text = empleado.Puesto.ToString();
            BackColor = empleado.Activo ? Color.LightGreen : Color.LightCoral;
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el user control del empleado.
        /// </summary>
        public event EventHandler<Empleado> EmpleadoClick;


        /// <summary>
        /// Lanza el evento EmpleadoClick al hacer clic en el user control del empleado o un elemento de texto.
        /// </summary>
        private void ucEmpleadosLista_Click(object sender, EventArgs e)
        {
            EmpleadoClick?.Invoke(this, Empleado);
        }

        private void lblId_Click(object sender, EventArgs e)
        {
            EmpleadoClick?.Invoke(this, Empleado);
        }

        private void lblPuesto_Click(object sender, EventArgs e)
        {
            EmpleadoClick?.Invoke(this, Empleado);
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {
            EmpleadoClick?.Invoke(this, Empleado);
        }

        private void lblApellidos_Click(object sender, EventArgs e)
        {
            EmpleadoClick?.Invoke(this, Empleado);
        }
    }
}
