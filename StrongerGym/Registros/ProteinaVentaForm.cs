﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using StrongerGym.R;
using StrongerGym.Properties;
using StrongerGym.Consultas;
using StrongerGym.Reportes;
using System.Xml;
using System.IO;
using System.Xml.Serialization;

namespace StrongerGym.Registros
{
    public partial class ProteinaVentaForm : Form
    {
        Configuracion configuracion = new Configuracion();
        Proteinas proteina = new Proteinas();
        Clientes cliente = new Clientes();
        Usuarios usuario = new Usuarios();
        Ventas venta = new Ventas();

        int Cantidades = 0;
        double monto = 0.0;
        double itbis = 0.0;
        bool Mode = false;

        public ProteinaVentaForm()
        {
            InitializeComponent();
            VentaUsuariotextBox.Text = LoginForm.NombreUsuario;

            itbis = Seguridad.ValidarIdDouble(configuracion.Listado(" * ", " 1=1 ", "").Rows[0]["ITBIS"].ToString());
            NCFtextBox.Text = configuracion.Listado("NCF","1=1","").Rows[0]["NCF"].ToString();
            ITBISlabel.Text = itbis.ToString();
        }

        private void VentasdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void BuscarProteina()
        {
            VentaerrorProvider.Clear();

            if (CodigoProteinatextBox.Text.Length > 0)
            {
                proteina.ProteinaId = Seguridad.ValidarIdEntero(CodigoProteinatextBox.Text);
            }
            else
            {
                VentaerrorProvider.SetError(CodigoProteinatextBox, "Ingrese Un Codigo de Proteina");
            }
           
            if (proteina.Buscar(proteina.ProteinaId))
            {
                ProteinatextBox.Text = proteina.Nombre;
            }
            else
            {
                MessageBox.Show("Codigo No Existe","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public void BuscarCliente()
        {
            int Convertido = 0;
            VentaerrorProvider.Clear();

            if (CodigoClientetextBox.Text.Length > 0)
            {
                Convertido = venta.ClienteId = Seguridad.ValidarIdEntero(CodigoClientetextBox.Text);
            }
            else
            {
                VentaerrorProvider.SetError(CodigoClientetextBox, "Ingrese Un Codigo de Cliente");
            }

            if (cliente.Buscar(Convertido))
                {
                    NombreClientetextBox.Text = cliente.Nombre;
                }
                else
                {
                    MessageBox.Show("Codigo No Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        public void CalcularMonto()
        {
            Montolabel.Text = "";
            monto = 0.0;
            VentaerrorProvider.Clear();
            for (int i = 0; i < VentasdataGridView.RowCount; i++)
            {

                monto += (double)VentasdataGridView.Rows[i].Cells[5].Value;
            }
            Montolabel.Text = monto.ToString();
        }

        public void AgregarProducto()
        {
            Montolabel.Text = "";
            monto = 0.0;
            VentaerrorProvider.Clear();

            if (CantidadProteinatextBox.Text.Length > 0)
            {
                Cantidades = Convert.ToInt32(CantidadProteinatextBox.Text);

                VentasdataGridView.Rows.Add(proteina.ProteinaId, proteina.Nombre, proteina.Precio, Cantidades, itbis, Cantidades * proteina.Precio + (itbis * proteina.Precio));

                CalcularMonto();
            }
            else
            {
                VentaerrorProvider.SetError(CantidadProteinatextBox, "Ingrese Una Cantidad");
            }          

            CodigoProteinatextBox.Clear();
            CantidadProteinatextBox.Clear();
            ProteinatextBox.Clear();
        }

        private void AgregarProductobutton_Click(object sender, EventArgs e)
        {
            if (Mode)
            {
                VentasdataGridView.Rows.RemoveAt(VentasdataGridView.CurrentRow.Index);
                CalcularMonto();
            }
            else
            {
                AgregarProducto();
                
            }
            
        }

        public void Limpiar()
        {
            VentaerrorProvider.Clear();
            VentasdataGridView.Rows.Clear();
            CodigoClientetextBox.Clear();
            CodigoProteinatextBox.Clear();
            NombreClientetextBox.Clear();
            ProteinatextBox.Clear();
            CantidadProteinatextBox.Clear();
            Montolabel.Text = "0.00";
            CodigoClientetextBox.ReadOnly = false;
            venta.LimpiarList();
        }

        public bool LlenarDatos()
        {
            bool retorno = false;
            VentaerrorProvider.Clear();

            venta.UsuarioId = LoginForm.UsuarioId; ;

            if (CodigoClientetextBox.Text.Length > 0)
            {
                venta.ClienteId = Seguridad.ValidarIdEntero(CodigoClientetextBox.Text);
                retorno = true;
            }
            else
            {
                VentaerrorProvider.SetError(CodigoClientetextBox, "Ingrese Un Codigo de Cliente");
                retorno = false;
            }
                
            venta.ITBS = itbis;
            venta.Fecha = FechadateTimePicker.Text;

            venta.TotalVenta = Seguridad.ValidarIdDouble(Montolabel.Text);

            venta.NCF = NCFtextBox.Text;

            venta.LimpiarList();
            for (int i = 0; i < VentasdataGridView.RowCount; i++)
            {
                venta.AgregarProteinas((int)VentasdataGridView.Rows[i].Cells[0].Value, (int)VentasdataGridView.Rows[i].Cells[3].Value, (double)VentasdataGridView.Rows[i].Cells[5].Value);
            }
            return retorno;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
            CodigoVentatextBox.Clear();
            Guardarbutton.Image = Resources._1444608937_Save;
            Guardarbutton.Text = "Guardar";

            AgregarProteinabutton.Image = Resources.Shopping_cart_add;
            AgregarProteinabutton.Text = "Agregar";
        }

        private void BuscarClientebutton_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void BuscarProductobutton_Click(object sender, EventArgs e)
        {
            BuscarProteina();
            AgregarProteinabutton.Image = Resources.Shopping_cart_add;
            AgregarProteinabutton.Text = "Agregar";
            Mode = false;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (LlenarDatos())
            {
                if (CodigoVentatextBox.Text.Length == 0)
                {
                    if (venta.Insertar())
                    {
                        MessageBox.Show("Guardado Correctamente", "Confirmar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Error al Guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (Seguridad.ValidarIdEntero(CodigoVentatextBox.Text) > 0)
                    {
                        venta.VentaId = Seguridad.ValidarIdEntero(CodigoVentatextBox.Text);
                        if (venta.Editar())
                        {
                            MessageBox.Show("Modificado Correctamente", "Confirmar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al Modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        VentaerrorProvider.SetError(CodigoVentatextBox,"Codifo No Valido");
                    }
                }
            }
            
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            VentaerrorProvider.Clear();
            if (Seguridad.ValidarIdEntero(CodigoVentatextBox.Text) > 0)
            {
                venta.VentaId = Seguridad.ValidarIdEntero(CodigoVentatextBox.Text);
                if (venta.Eliminar())
                {
                    MessageBox.Show("Eliminado Correctamente", "Confirmar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Error al Eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                VentaerrorProvider.SetError(CodigoVentatextBox,"Codigo No Valido");
            }
        }

        public void LlenarForm()
        {
            VentaerrorProvider.Clear();

            if (CodigoVentatextBox.Text.Length > 0)
            {
                venta.VentaId = Seguridad.ValidarIdEntero(CodigoVentatextBox.Text);
            }
            else
            {
                VentaerrorProvider.SetError(CodigoVentatextBox, "Ingrese Un Codigo de Venta");
            }          
            
            if (venta.VentaId > 0)
            {
                if (venta.Buscar(venta.VentaId))
                {
                    CodigoClientetextBox.Text = venta.ClienteId.ToString();
                    NombreClientetextBox.Text = venta.NombreCliente;
                    VentaUsuariotextBox.Text = venta.NombreUsuario;
                    NCFtextBox.Text = venta.NCF;
                    FechadateTimePicker.Text = venta.Fecha;
                    itbis = venta.ITBS;
                    Montolabel.Text = venta.TotalVenta.ToString();
                    foreach (var venta in venta.proteina)
                    {
                        VentasdataGridView.Rows.Add(venta.ProteinaId,venta.Nombre,venta.Precio,venta.Cantidad, itbis,venta.Importe);
                    }
                    Guardarbutton.Image = Resources._1442108330_Modify;
                    Guardarbutton.Text = "Modificar";
                }
                else
                {
                    MessageBox.Show("La Venta No Existe","Comfirmacion",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            else
            {
                VentaerrorProvider.SetError(CodigoVentatextBox,"Codigo No Valido");
            }
        }
        private void BuscarVentabutton_Click(object sender, EventArgs e)
        {
                Limpiar();
                LlenarForm();
        }

        private void VentasdataGridView_Click(object sender, EventArgs e)
        {
            AgregarProteinabutton.Image = Resources.basket___32;
            AgregarProteinabutton.Text = "Eliminar";
            Mode = true;
        }
    }
}
