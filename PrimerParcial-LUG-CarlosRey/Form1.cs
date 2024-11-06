using BLL;
using DAL;
using Entity;

namespace PrimerParcial_LUG_CarlosRey
{
    public partial class Form1 : Form
    {
        PartidoBLL partidoBLL = new PartidoBLL();
        DeportesBLL deportesBLL = new DeportesBLL();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTestDB_Click(object sender, EventArgs e)
        {
            try
            {
                TestDBBLL testDBBLL = new TestDBBLL();
                TestDB testDB = new TestDB();
                testDB.CAMPO1 = testDBBLL.testDB("test ok");
                MessageBox.Show(testDB.CAMPO1);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return; }
        }

        private void btnTestEscritura_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateGral();
        }

        private void ActualizarDGV()
        {
            try
            {
                dgvPartidos.DataSource = null;
                dgvPartidos.DataSource = partidoBLL.getpartidos();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void LlenarcmbDeportes()
        {
            try
            {
                cmbDeporte.DataSource = null;
                cmbDeporte.DataSource = deportesBLL.getDeportes();
                cmbDeporte.ValueMember = "IdDeporte";
                cmbDeporte.DisplayMember = "Descripcion";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void LlenarcmbPartidos()
        {
            try
            {
                cmbIdPartidos.DataSource = null;
                cmbIdPartidos.DataSource = partidoBLL.getpartidos();
                cmbIdPartidos.ValueMember = "IdPartido";
                cmbIdPartidos.DisplayMember = "IdPartido";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnGuardarPartido_Click(object sender, EventArgs e)
        {
            try
            {
                Partido nuevoPartido = new Partido();
                nuevoPartido.DeportePartido = new Deporte();
                nuevoPartido.DeportePartido.IdDeporte= Convert.ToInt32(cmbDeporte.SelectedValue);
                nuevoPartido.EquipoLocal = txtLocal.Text;
                nuevoPartido.EquipoVisitante = txtVisitante.Text;
                nuevoPartido.FechaPartido = dtpFechaPartido.Value;
                partidoBLL.GuardarPartido(nuevoPartido);
                updateGral();

                MessageBox.Show("Partido agregado correctamente");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void updateGral()
        {
            ActualizarDGV();
            LlenarcmbDeportes();
            LlenarcmbPartidos();
        }

        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                partidoBLL.ActualizarDatosPartido(Convert.ToInt32(cmbIdPartidos.SelectedValue), Convert.ToInt32(txtMarcadorLocal.Text), Convert.ToInt32(txtMarcadorVisitante.Text));
                MessageBox.Show("Partido Actualizado Correctamente");
                updateGral();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


        }

        private void btnEliminarPartido_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro desea eliminar el partido ID: " + Convert.ToInt32(cmbIdPartidos.SelectedValue) + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                partidoBLL.EliminarPartido(Convert.ToInt32(cmbIdPartidos.SelectedValue));
                MessageBox.Show("Partido Eliminado Correctamente");
                updateGral();
            }
            else { MessageBox.Show("Eliminación del partido cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void cmbIdPartidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //No llego a completarlo, la idea era completarlos textbox si existía el partido.
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
