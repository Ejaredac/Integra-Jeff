﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegraJeff
{
    public partial class FrmCruceAgregar : Form
    {
        public FrmCruceAgregar()
        {
            InitializeComponent();
        }

        private void NotVacio(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (string.IsNullOrEmpty((sender as TextBox).Text)) ? "0" : (sender as TextBox).Text;
        }

        private void DecimalAllow(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void IntAllow(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            
        }

        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            FrmClientes fcl = new FrmClientes(cli);
            fcl.ShowDialog();
            txtIdClientes.Text = cli.IDCliente.ToString();
        }

        private void btnSeleccionarCaja_Click(object sender, EventArgs e)
        {
            Caja caj = new Caja();
            FrmCajas frcaja = new FrmCajas(caj);
            frcaja.ShowDialog();
            txtIdCajas.Text = caj.IDCaja.ToString();
        }

        private void btnSeleccionarFactura_Click(object sender, EventArgs e)
        {
            Factura fact = new Factura();
            FrmFactura frfact = new FrmFactura(fact);
            frfact.ShowDialog();
            txtIdRemisiones.Text = fact.IdRemisionesFactura.ToString();
        }

        private void btnSeleccionarIntermediario_Click(object sender, EventArgs e)
        {
            Intermediario inter = new Intermediario();
            FrmIntermediario frint = new FrmIntermediario(inter);
            frint.ShowDialog();
            txtIdIntermediarios.Text = inter.IDIntermediario.ToString();
        }

        private void btnSeleccionarUnidades_Click(object sender, EventArgs e)
        {
            Unidad uni = new Unidad();
            FrmUnidades frUni = new FrmUnidades(uni);
            frUni.ShowDialog();
            txtIdUnidades.Text = uni.IdUnidad.ToString();
        }

        private void btnSeleccionarConductores_Click(object sender, EventArgs e)
        {
            Conductor cond = new Conductor();
            FrmConductor frCond = new FrmConductor(cond);
            frCond.ShowDialog();
            txtIdConductores.Text = cond.IDConductor.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {


            MySqlConnection conn = ConexionBD.Conexion;
            try
            {
                string strOrder = @"INSERT INTO `integrajeffschm`.`cruces`
(`TipoServicio`,
`idClientes`,
`idCajas`,
`idRemisionesYFacturas`,
`EstatusCobro`,
`FechaCarga`,
`FechaEntrega`,
`LugarCarga`,
`LugarDescarga`,
`PrecioPesos`,
`PrecioDolares`,
`idIntermediarios`,
`Asignada`,
`Demora`,
`HorasDemora`,
`idUnidades`,
`idConductores`,
`Anotaciones`,
`Referencia`)
VALUES
(@tip,
@idcli,
@idcaj,
@idremi,
@est,
@fcar,
@fent,
@lugcar,
@lugdes,
@prepes,
@predol,
@idint,
@asig,
@dem,
@hordem,
@iduni,
@idcond,
@anot,
@ref);";
                MySqlCommand mscCommand = new MySqlCommand(strOrder, conn);
                mscCommand.Parameters.AddWithValue("@tip", txtTipoServicio.Text);
                mscCommand.Parameters.AddWithValue("@idcli", int.Parse(txtIdClientes.Text));
                mscCommand.Parameters.AddWithValue("@idcaj", int.Parse(txtIdCajas.Text));
                mscCommand.Parameters.AddWithValue("@idremi", int.Parse(txtIdRemisiones.Text));
                mscCommand.Parameters.AddWithValue("@est", chkEstatusCobro.Checked);
                mscCommand.Parameters.AddWithValue("@fcar", dtpFechaCarga.Value);
                mscCommand.Parameters.AddWithValue("@fent", dtpFechaEntrega.Value);
                mscCommand.Parameters.AddWithValue("@lugcar", txtLugarCarga.Text);
                mscCommand.Parameters.AddWithValue("@lugdes", txtLugarDescarga.Text);
                mscCommand.Parameters.AddWithValue("@prepes", double.Parse(txtPrecioPesos.Text));
                mscCommand.Parameters.AddWithValue("@predol", double.Parse(txtPrecioDolares.Text));
                mscCommand.Parameters.AddWithValue("@idint", int.Parse(txtIdIntermediarios.Text));
                mscCommand.Parameters.AddWithValue("@asig", chkAsignada.Checked);
                mscCommand.Parameters.AddWithValue("@dem", txtDemora.Text);
                mscCommand.Parameters.AddWithValue("@hordem", int.Parse(txtHorasDemora.Text));
                mscCommand.Parameters.AddWithValue("@iduni", int.Parse(txtIdUnidades.Text));
                mscCommand.Parameters.AddWithValue("@idcond", int.Parse(txtIdConductores.Text));
                mscCommand.Parameters.AddWithValue("@anot", txtAnotaciones.Text);
                mscCommand.Parameters.AddWithValue("@ref", txtReferencia.Text);
                conn.Open();
                mscCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}