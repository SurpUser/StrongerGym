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

namespace StrongerGym.Registros
{
    public partial class CiudadRegistroForm : Form
    {
        Ciudades ciudad = new Ciudades();

        public CiudadRegistroForm()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            CiudadIdtextBox.Clear();
            CiudaderrorProvider.Clear();
            NombretextBox.Clear();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public bool LlenarDatoCiudades()
        {
            try
            {
                CiudaderrorProvider.Clear();
                if (NombretextBox.Text.Length > 0)
                {
                    ciudad.Nombre = NombretextBox.Text;
                }
                else
                {
                    CiudaderrorProvider.SetError(NombretextBox,"Ingrese Una Ciudad");
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CiudadIdtextBox.Text.Length == 0)
                {

                    if (LlenarDatoCiudades())
                    {
                        if (ciudad.Insertar())
                        {
                            MessageBox.Show("Guardado Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("Error Al Guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    if (LlenarDatoCiudades())
                    {
                        if (Seguridad.ValidarIdEntero(CiudadIdtextBox.Text) > 0)
                        {
                            ciudad.CiudadId = Seguridad.ValidarIdEntero(CiudadIdtextBox.Text);
                            if (ciudad.Editar())
                            {
                                MessageBox.Show("Modificado Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Limpiar();
                            }
                            else
                            {
                                MessageBox.Show("Error Al Modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Id Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Faltan Campos");
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Seguridad.ValidarIdEntero(CiudadIdtextBox.Text) > 0)
                {
                    ciudad.CiudadId = Seguridad.ValidarIdEntero(CiudadIdtextBox.Text);

                    if (ciudad.Eliminar())
                    {
                        MessageBox.Show("Eliminado Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Error Al Eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Id Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error Al Eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Seguridad.ValidarIdEntero(CiudadIdtextBox.Text) > 0)
                {
                    if (ciudad.Buscar(Seguridad.ValidarIdEntero(CiudadIdtextBox.Text)))
                    {
                        NombretextBox.Text = ciudad.Nombre;
                    }
                    else
                    {
                        MessageBox.Show("Id no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Limpiar();
                    }
                }
                else
                {
                    MessageBox.Show("Id Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Id no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
            }
        }
    }
}
