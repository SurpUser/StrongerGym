﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BLL;

namespace BLL
{
    public class Proveedores : ClaseMaestra
    {
        ConexionDB conexion = new ConexionDB();

        public int ProveedorId { get; set; }
        public int CiudadId { get; set; }
        public string CiudadNombre { get; set; }
        public string NombreRepresentante { get; set; }
        public string NombreEmpresa { get; set; }
        public string RNC { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }

        public Proveedores()
        {
            this.ProveedorId = 0;
            this.CiudadId = 0;
            this.NombreEmpresa = "";
            this.NombreRepresentante = "";
            this.RNC = "";
            this.Direccion = "";
            this.Telefono = "";
            this.Celular = "";
            this.Email = "";
        }

        public override bool Buscar(int IdBuscado)
        {
            DataTable dtProveedor = new DataTable();
            DataTable dtCiudad = new DataTable();
            bool retorno = false;

            try
            {
                dtProveedor = conexion.ObtenerDatos(String.Format("select * from Proveedores where ProveedorId = {0}",IdBuscado));
                this.CiudadId = (int)dtProveedor.Rows[0]["CiudadId"];
                this.NombreEmpresa = dtProveedor.Rows[0]["NombreEmpresa"].ToString();
                this.NombreRepresentante = dtProveedor.Rows[0]["NombreRepresentante"].ToString();
                this.RNC = dtProveedor.Rows[0]["RNC"].ToString();
                this.Direccion = dtProveedor.Rows[0]["Direccion"].ToString();
                this.Telefono = dtProveedor.Rows[0]["Telefono"].ToString();
                this.Celular = dtProveedor.Rows[0]["Celular"].ToString();
                this.Email = dtProveedor.Rows[0]["Email"].ToString();

                dtCiudad = conexion.ObtenerDatos(String.Format("select * from Ciudades where CiudadId = {0}",this.CiudadId));
                this.CiudadNombre = dtCiudad.Rows[0]["Nombre"].ToString();

                retorno = true;
            }
            catch (Exception)
            {
                retorno = false;
            }

            return retorno;
        }

        public override bool Editar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("update Proveedores set CiudadId={0}, NombreEmpresa='{1}' ,NombreRepresentante='{2}', RNC='{3}', Direccion='{4}', Telefono='{5}', Celular='{6}' ,Email='{7}' where ProveedorId={8}",
                                                this.CiudadId,this.NombreEmpresa,this.NombreRepresentante,this.RNC,this.Direccion,this.Telefono,this.Celular,this.Email,this.ProveedorId));
                
            }
            catch (Exception)
            {
                retorno = false;
            }

            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;

            try
            {
                retorno = conexion.Ejecutar(String.Format("delete from Proveedores where ProveedorId ={0};",this.ProveedorId));
            }
            catch (Exception)
            {
                retorno = false;
            }

            return retorno;
        }

        public override bool Insertar()
        {
            bool retorno = false;

            try
            {
                retorno = conexion.Ejecutar(String.Format("insert into Proveedores(CiudadId,NombreEmpresa,NombreRepresentante,RNC,Direccion,Telefono,Celular,Email) values({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                                                this.CiudadId, this.NombreEmpresa, this.NombreRepresentante, this.RNC, this.Direccion, this.Telefono, this.Celular, this.Email));
            }
            catch (Exception)
            {
                retorno = false;
            }

            return retorno;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            DataTable dt = new DataTable();

            try
            {
                dt = conexion.ObtenerDatos("select "+Campos +" from Proveedores where "+Condicion+" "+Orden);
            }
            catch (Exception ex)
            {
                Seguridad.ErrorExcepcion(ex.ToString());
            }

            return dt;
        }

        
    }
}
