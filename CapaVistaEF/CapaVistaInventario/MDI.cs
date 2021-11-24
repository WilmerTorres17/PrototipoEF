using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVistaSeguridadHSC;
using CapaVista;
using CapaVistaReporte;

namespace CapaVistaInventario
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void tipoMovimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducto producto = new frmProducto();
            producto.Show();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteadorAdmin repo = new ReporteadorAdmin();
            repo.Show();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = form.usuario();
                nombreUsuario.nombre = txtUsuario.Text;

            }
            else
            {
                this.Close();
            }
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = form.usuario();
            }
            else
            {
                this.Close();
            }
        }

        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMIDSeguridad seguridad = new frmMIDSeguridad();
            seguridad.Show();
        }

        private void consultasInteligentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuconsultas consultas = new menuconsultas();
            consultas.Show();
        }

        private void movimientoInventarioEncabezadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMoviemientoInventarioEnc MovimientoEnc = new frmMoviemientoInventarioEnc();
            MovimientoEnc.Show();

        }

        private void movimientoInventarioDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovimientoInventarioDet MovimientoDet = new frmMovimientoInventarioDet();
            MovimientoDet.Show();
        }

        private void tiposDeMovimientosInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoMovimiento TipoMovimiento = new frmTipoMovimiento();
            TipoMovimiento.Show();
        }
    }
}
