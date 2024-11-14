using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Data;
using Negocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    public partial class FormMovimientoBancario : Form
    {
        List<MovimientosBancario> mblist = new List<MovimientosBancario>();
        public FormMovimientoBancario()
        {
            InitializeComponent();
        }

        private void CargarCuenta()
        {
            List<Cuenta> list = BCuenta.Get();

            cuentaBindingSource1.DataSource = list;
            comboBox3.DataSource = cuentaBindingSource1;
            comboBox3.DisplayMember = "Detalle";
            comboBox3.ValueMember = "IdCuenta";
        }


        private void CargarBanco()
        {
            List<Banco> list = BBanco.Get();

            bancoBindingSource1.DataSource = list;
            comboBox2.DataSource = bancoBindingSource1;
            comboBox2.DisplayMember = "NombreBanco";
            comboBox2.ValueMember = "IdBanco";
        }

        private void FormMovimientoBancario_Load(object sender, EventArgs e)
        {
            CargarCuenta();
            CargarBanco();

            //dataGridView1.AutoGenerateColumns = true;
            mblist = BMovimientoBancario.Get();
            movimientosBancarioBindingSource.DataSource = mblist;

            LimpiarCampos();

            // MostrarMovimientosConNombre();
        }

        private void LimpiarCampos()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            dateTimePicker1.Value = DateTime.Now;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
        }
        private void MostrarMovimientosConNombre()
        {
            var movimientosConNombres = mblist.Select(mb => new
            {
                mb.IdMovimiento,
                Banco = BBanco.Get().FirstOrDefault(b => b.idBanco == mb.BancoId)?.nombreBanco,
                Cuenta = BCuenta.Get().FirstOrDefault(c => c.idCuenta == mb.CuentaId)?.detalle,
                mb.Fecha,
                mb.Debe,
                mb.Haber
            }).ToList();

            // Asignar la lista con nombres al DataGridView
            dataGridView1.DataSource = movimientosConNombres;
            dataGridView1.ReadOnly = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int banco = (int)comboBox2.SelectedValue;
            int cuenta = (int)comboBox3.SelectedValue;
            DateTime fecha = dateTimePicker1.Value;
            double debe = double.Parse(textBox1.Text);
            double haber = double.Parse(textBox3.Text);
            var movimientoExistente = mblist.FirstOrDefault(mb =>
                mb.BancoId == banco &&
                mb.CuentaId == cuenta &&
                mb.Fecha.Date == fecha.Date &&
                mb.Debe == debe &&
                mb.Haber == haber);

            if (movimientoExistente != null)
            {
                MessageBox.Show("Ya existe un movimiento bancario con estos datos. No se puede insertar un registro duplicado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                BMovimientoBancario.Insert(fecha, banco, cuenta, debe, haber);

                mblist = BMovimientoBancario.Get();
                MostrarMovimientosConNombre();
            }

            LimpiarCampos();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            int idMovimiento = int.Parse(textBox2.Text);
            int banco = (int)comboBox2.SelectedValue;
            int cuenta = (int)comboBox3.SelectedValue;
            DateTime fecha = dateTimePicker1.Value;
            double debe = double.Parse(textBox1.Text);
            double haber = double.Parse(textBox3.Text);

            BMovimientoBancario.Update(idMovimiento, fecha, banco, cuenta, debe, haber);
            mblist = BMovimientoBancario.Get();
            movimientosBancarioBindingSource.DataSource = mblist;

            LimpiarCampos();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            MovimientosBancario mb = (MovimientosBancario)movimientosBancarioBindingSource.Current;
            int idMovimiento = mb.IdMovimiento;

            BMovimientoBancario.Delete(idMovimiento);

            mblist = BMovimientoBancario.Get();
            movimientosBancarioBindingSource.DataSource = mblist;


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                if (mblist.Count > 0)
                {
                    MovimientosBancario mb = (MovimientosBancario)movimientosBancarioBindingSource.Current;
                    if (mb != null)
                    {
                        comboBox2.SelectedValue = mb.BancoId;
                        comboBox3.SelectedValue = mb.CuentaId;

                        textBox2.Text = mb.IdMovimiento.ToString();
                        dateTimePicker1.Value = mb.Fecha;
                        textBox1.Text = mb.Debe.ToString();
                        textBox3.Text = mb.Haber.ToString();
                    }
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultarID_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int idMovimiento))
            {
                if (mblist == null || mblist.Count == 0)
                {
                    MessageBox.Show("No hay movimientos bancarios para consultar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var movimiento = mblist.FirstOrDefault(mb => mb.IdMovimiento == idMovimiento);

                if (movimiento != null)
                {
                    var banco = BBanco.Get().FirstOrDefault(b => b.idBanco == movimiento.BancoId);
                    var cuenta = BCuenta.Get().FirstOrDefault(c => c.idCuenta == movimiento.CuentaId);

                    var movimientosConNombres = new List<object>
            {
                new
                {
                    movimiento.IdMovimiento,
                    Banco = banco?.nombreBanco ?? "No encontrado",  // Si no se encuentra el banco, mostrar un mensaje predeterminado
                    Cuenta = cuenta?.detalle ?? "No encontrado",    // Si no se encuentra la cuenta, mostrar un mensaje predeterminado
                    movimiento.Fecha,
                    movimiento.Debe,
                    movimiento.Haber
                }
            };

                    dataGridView1.DataSource = movimientosConNombres;
                }
                else
                {
                    MessageBox.Show("No se encontró un movimiento bancario con el ID especificado.", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LimpiarCampos();
        }
    }
}


