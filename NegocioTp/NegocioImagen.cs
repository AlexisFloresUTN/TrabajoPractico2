﻿using DominioTp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioTp
{

    public class NegocioImagen
    {
        public List<Imagen> Listar()
        {
            List<Imagen> lista = new List<Imagen>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("select Id, IdArticulo, ImagenUrl from IMAGENES");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Imagen aux = new Imagen();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.IdArticulo = (int)datos.Lector["IdArticulo"];

                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                    { aux.UrlImagen = (string)datos.Lector["ImagenUrl"]; }


                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public Imagen ListarPor(int id)
        {
            List<Imagen> lista = new List<Imagen>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("select Id, IdArticulo, ImagenUrl from IMAGENES WHERE IdArticulo =" + id + "");
                datos.EjecutarLectura();
                Imagen aux = new Imagen();
                while (datos.Lector.Read())
                {



                    aux.Id = (int)datos.Lector["Id"];
                    aux.IdArticulo = (int)datos.Lector["IdArticulo"];

                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                    { aux.UrlImagen = (string)datos.Lector["ImagenUrl"]; }




                }
                return aux;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
        public void AgregarNuevaIma(Imagen nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("insert into IMAGENES (IdArticulo, ImagenUrl) values ('" + nuevo.IdArticulo + "','" + nuevo.UrlImagen + "')");
                datos.ejecutarAccion();


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }

        }
        
        public void ModificarImagen(Imagen nueva)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
               
                datos.SetearConsulta("UPDATE IMAGENES SET IdArticulo=@IdArticulo, ImagenUrl=@ImagenUrl where Id="+nueva.Id+"");
                datos.setearParametro("@IdArticulo", nueva.IdArticulo);
                datos.setearParametro("ImagenUrl", nueva.UrlImagen);
                datos.ejecutarAccion();


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }

        }
        public void EliminarImagen(int idArticulo)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.SetearConsulta("delete from IMAGENES where IdArticulo = @idArticulo");
                datos.setearParametro("@idArticulo", idArticulo);
                datos.ejecutarAccion();  
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

