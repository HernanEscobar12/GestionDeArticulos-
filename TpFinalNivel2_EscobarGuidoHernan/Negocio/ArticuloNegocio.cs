using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select A.Id, Nombre, A.Descripcion, A.Codigo ,M.Descripcion Marca , A.IdMarca ,C.Descripcion Categoria, A.IdCategoria , ImagenUrl, Precio from ARTICULOS A, MARCAS M , CATEGORIAS C where A.IdMarca = M.Id and A.IdCategoria = c.Id");
                datos.ejecutarLectura();

                while (datos.lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.Id = (int)datos.lector["Id"];
                    articulo.Nombre= (string)datos.lector["Nombre"];
                    articulo.Codigo = (string)datos.lector["Codigo"];
                    articulo.Descripcion = (string)datos.lector["Descripcion"];
                    articulo.ImagenUrl = (string)datos.lector["ImagenUrl"];
                    articulo.Precio = (decimal)datos.lector["Precio"];
                    articulo.Marca = new Marca();
                    articulo.Marca.Descripcion = (string)datos.lector["Marca"];
                    articulo.Marca.Id = (int)datos.lector["IdMarca"];
                    articulo.Categoria = new Categoria();
                    articulo.Categoria.Descripcion = (string)datos.lector["Categoria"];
                    articulo.Categoria.Id = (int)datos.lector["IdCategoria"];

                    lista.Add(articulo);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Articulo> ListarDetalle(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                List<Articulo> lista = new List<Articulo>();
                datos.setearConsulta("select A.Descripcion, M.Descripcion Marca, M.Id , C.Descripcion Categoria, C.Id , ImagenUrl, Precio from ARTICULOS A , CATEGORIAS C, MARCAS M where A.IdCategoria = C.Id and A.IdMarca = M.Id and A.Id = @id");
                datos.setearParametros("@id", articulo.Id);
                datos.ejecutarLectura();

                while (datos.lector.Read())
                {
                    articulo.Descripcion = (string)datos.lector["Descripcion"];
                    articulo.ImagenUrl = (string)datos.lector["ImagenUrl"];
                    articulo.Precio = (decimal)datos.lector["Precio"];
                    articulo.Marca = new Marca();
                    articulo.Marca.Descripcion = (string)datos.lector["Marca"];
                    articulo.Marca.Id = (int)datos.lector["Id"];
                    articulo.Categoria = new Categoria();
                    articulo.Categoria.Descripcion = (string)datos.lector["Categoria"];
                    articulo.Categoria.Id = (int)datos.lector["Id"];

                    lista.Add(articulo);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public void Agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearConsulta("insert into ARTICULOS(Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values  ( @Codigo , @nombre, @descripcion, @idMarca, @idCategoria, @img, @precio)");
                
                    //datos.setearConsulta("insert into ARTICULOS(Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values(" + nuevo.Codigo + ",'" + nuevo.Nombre + "', '" + nuevo.Descripcion + "', @idMarca, @idCategoria, @img, @precio)"); 
                datos.setearParametros("@Codigo", nuevo.Codigo);
                datos.setearParametros("@nombre", nuevo.Nombre);
                datos.setearParametros("@descripcion", nuevo.Descripcion);
                datos.setearParametros("@idMarca", nuevo.Marca.Id);
                datos.setearParametros("@idCategoria", nuevo.Categoria.Id);
                datos.setearParametros("@img", nuevo.ImagenUrl);
                datos.setearParametros("@precio", nuevo.Precio);
                datos.ejecturarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void Modificar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @codigo , Nombre = @nombre , Descripcion = @descripcion , IdMarca = @idMarca , IdCategoria = @idCategoria , ImagenUrl = @img , Precio = @precio where Id = @id");
                datos.setearParametros("@codigo", articulo.Codigo);
                datos.setearParametros("@nombre", articulo.Nombre);
                datos.setearParametros("@descripcion", articulo.Descripcion);
                datos.setearParametros("@idMarca", articulo.Marca.Id);
                datos.setearParametros("@idCategoria", articulo.Categoria.Id);
                datos.setearParametros("@img", articulo.ImagenUrl);
                datos.setearParametros("@precio", articulo.Precio);
                datos.setearParametros("@id", articulo.Id);

                datos.ejecturarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public void Eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from Articulos where id = @id");
                datos.setearParametros("@id", id);
                datos.ejecturarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public List<Articulo> Filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "select A.Id, Codigo, A.Nombre, A.Descripcion, A.ImagenUrl,  Precio , A.IdMarca, A.IdCategoria ,C.Descripcion Categoria, M.Descripcion Marca from ARTICULOS A, CATEGORIAS C, MARCAS M where A.IdCategoria = C.Id and A.IdMarca = M.Id and ";
                if (campo == "Código")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                        consulta += " Codigo like  '" + filtro + "%'";
                            break;
                        case "Termina con":
                        consulta += " Codigo like  '%" + filtro + "'";
                        break;
                    default:
                        consulta += " Codigo like  '%" + filtro + "%'";
                        break;
                    }
                }
                else if (campo == "Precio")
                {
                    switch (criterio)
                    {
                        case "Mayor a ":
                            consulta += " Precio > " + filtro;
                            break;
                        case "Menor a":
                            consulta += " Precio < " + filtro;
                            break;
                        default:
                            consulta += " Precio = " + filtro;
                            break;
                    }
                }
                else if (campo == "Nombre")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += " Nombre like  '" + filtro + "%'";
                            break;
                        case "Termina con":
                            consulta += " Nombre like  '%" + filtro + "'";
                            break;
                        default:
                            consulta += " Nombre like  '%" + filtro + "%'";
                            break;
                    }
                }
                else 
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += " A.Descripcion like  '" + filtro + "%'";
                            break;
                        case "Termina con":
                            consulta += " A.Descripcion like  '%" + filtro + "'";
                            break;
                        default:
                            consulta += " A.Descripcion like  '%" + filtro + "%'";
                            break;
                    }
                }

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.lector.Read())
                {
                    Articulo art = new Articulo();
                    art.Id = (int)datos.lector["Id"];
                    art.Codigo = (string)datos.lector["Codigo"];
                    art.Nombre = (string)datos.lector["Nombre"];
                    art.Descripcion = (string)datos.lector["Descripcion"];
                    if (!(datos.lector["ImagenUrl"] is DBNull))
                        art.ImagenUrl = (string)datos.lector["ImagenUrl"];
                    art.Precio = (decimal)datos.lector["Precio"];
                    art.Categoria = new Categoria();
                    art.Categoria.Id = (int)datos.lector["IdCategoria"];
                    art.Categoria.Descripcion = (string)datos.lector["Categoria"];
                    art.Marca = new Marca();
                    art.Marca.Id = (int)datos.lector["IdMarca"];
                    art.Marca.Descripcion = (string)datos.lector["Marca"];

                    lista.Add(art);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }

    }
}
