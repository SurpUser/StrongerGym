﻿using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Configuracion : ClaseMaestra
    {
        ConexionDB conexion = new ConexionDB();

        public int ConfiguracionId { get; set; }
        public int Semana { get; set; }
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public double ITBIS { get; set; }
        public string NCF { get; set; }

        public Configuracion()
        {
            this.ConfiguracionId = 1;
            this.Semana = 0;
            this.Dia = 0;
            this.Mes = 0;
            this.Ano = 0;
            this.ITBIS = 0.0;
            this.NCF = "";
        }

        public Configuracion(int ConfiguracionId,int Semana, int Dia, int Mes, int Ano, double Itbs, string CompFscal)
        {
            this.ConfiguracionId = ConfiguracionId;
            this.Semana = Semana;
            this.Dia = Dia;
            this.Mes = Mes;
            this.Ano = Ano;
            this.ITBIS = Itbs;
            this.NCF = CompFscal;
        }

        public Configuracion(int ConfiguracionId)
        {
            this.ConfiguracionId = ConfiguracionId;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            StringBuilder comando = new StringBuilder();
            try
            {
                retorno = conexion.Ejecutar(string.Format("insert into Configuraciones (Dia, Semana, Mes, Ano, ITBIS, NCF) values ({0},{1},{2},{3},{4},'{5}') ", this.Dia, this.Semana, this.Mes, this.Ano,this.ITBIS, this.NCF));
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
                retorno = conexion.Ejecutar(string.Format("update Configuraciones set Dia = {0}, Semana = {1}, Mes = {2}, Ano = {3}, ITBIS = {4}, NCF = '{5}' where ConfiguracionId = {6}", this.Dia, this.Semana ,this.Mes, this.Ano,this.ITBIS, this.NCF, this.ConfiguracionId));
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
                retorno = conexion.Ejecutar(string.Format("Delete from Configuraciones where ConfiguracionId = {0}", this.ConfiguracionId));
            }
            catch (Exception)
            {
                retorno = false;
            }

            return retorno;
        }

        public override bool Buscar(int IdBuscado)
        {
            DataTable dt = new DataTable();
            bool retorno = false;
            try
            {
                dt = conexion.ObtenerDatos(string.Format("select * from Configuraciones where ConfiguracionId = {0} ", IdBuscado));

                if (dt.Rows.Count > 0)
                {
                    this.Dia = (int)dt.Rows[0]["Dia"];
                    this.Semana = (int)dt.Rows[0]["Semana"];
                    this.Mes = (int)dt.Rows[0]["Mes"];
                    this.Ano = (int)dt.Rows[0]["Ano"];
                    this.ITBIS = (double)dt.Rows[0]["ITBIS"];
                    this.NCF = dt.Rows[0]["NCF"].ToString();
                }
                else
                {
                    retorno = false;
                }
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
                dt = conexion.ObtenerDatos("select " + Campos + " from Configuraciones where " + Condicion + " " + Orden);
            }
            catch (Exception ex)
            {
                Seguridad.ErrorExcepcion(ex.ToString());
            }
            return dt;
        }
    }
}
