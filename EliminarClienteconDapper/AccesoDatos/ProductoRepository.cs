using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace AccesoDatos
{
    public class ProductoRepository
    {
        public Producto ObtenerPorId(int id)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                String selectForID = "";
                selectForID = selectForID + "SELECT [Id] " + "\n";
                selectForID = selectForID + "      ,[Nombre] " + "\n";
                selectForID = selectForID + "      ,[Descripcion] " + "\n";
                selectForID = selectForID + "      ,[Precio] " + "\n";
                selectForID = selectForID + "      ,[Stock] " + "\n";
                selectForID = selectForID + "      ,[Marca] " + "\n";
                selectForID = selectForID + "      ,[Categoria] " + "\n";
                selectForID = selectForID + "  FROM [dbo].[Productos] " + "\n";
                selectForID = selectForID + "  WHERE Id = @Id";

                var IdProduct = conexion.QueryFirstOrDefault<Producto>(selectForID, new Producto { Id = id });
                return IdProduct;
            }
        }
        public int EliminarProducto(int id)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                String DeleteProd = "";
                DeleteProd = DeleteProd + "DELETE FROM [dbo].[Productos] " + "\n";
                DeleteProd = DeleteProd + "      WHERE Id=@Id";
                var DelProducto = conexion.Execute(DeleteProd, new { Id = id });
                return DelProducto;
            }
        }
        public List<Producto> ObtenerTodo()
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                String SelectAll = "";
                SelectAll = SelectAll + "SELECT [Id] " + "\n";
                SelectAll = SelectAll + "      ,[Nombre] " + "\n";
                SelectAll = SelectAll + "      ,[Descripcion] " + "\n";
                SelectAll = SelectAll + "      ,[Precio] " + "\n";
                SelectAll = SelectAll + "      ,[Stock] " + "\n";
                SelectAll = SelectAll + "      ,[Marca] " + "\n";
                SelectAll = SelectAll + "      ,[Categoria] " + "\n";
                SelectAll = SelectAll + "  FROM [dbo].[Productos]";
                var ProductList = conexion.Query<Producto>(SelectAll).ToList();
                return ProductList;
            }
        }
    }
}
