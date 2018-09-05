using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer;
using DataLayer;

namespace DataLayer.DataBase
{
    /// <summary>
    /// Repositorio de entidad Producto
    /// </summary>
    public class ProductoRepository: Repository<Producto, GymMatiContext>, IProductoRepository
    {
        public ProductoRepository(GymMatiContext pContext) : base(pContext)
        {

        }

        public IList<Producto> GetByCadena(string cadena)
        {
            var listaPorTipo = this.iDbContext.Productos.Where(unProd => unProd.TipoProducto.Nombre.StartsWith(cadena));
            //var listaPorMarca = this.iDbContext.Productos.Where(unProd => unProd.Marca.Nombre.StartsWith(cadena));
            var listaPorNombre = this.iDbContext.Productos.Where(unProd => unProd.Nombre.StartsWith(cadena));

           // var listaPorTipoYMarca = listaPorTipo.Concat(listaPorMarca);
            var listaCompleta = listaPorTipo.Concat(listaPorNombre);

            return listaCompleta.OrderBy(unProd => unProd.CodProducto).ToList();
        }

        public TipoProducto GetTipoProducto(string cadena)
        {
            return this.iDbContext.TiposProductos.Where(unTipo => unTipo.Nombre == cadena).First();
        }

        public IList<TipoProducto> GetTiposProductos()
        {
            return this.iDbContext.TiposProductos.ToList();
        }

        //public IList<Marca> GetMarcas()
        //{
        //    return this.iDbContext.Marcas.ToList();
        //}

        //public IList<ProductoDTO> listaBuscarProducto()
        //{
            
        //    //var query = this.iDbContext.Database.SqlQuery<ProductoDTO>("select p.codProducto as CodProducto, p.nombre as Nombre, p.Marca, p.contenido as Contenido, p.precio as Precio, p.descripcion as Descripcion, p.stock as Stock, tp.nombre as TipoProducto from Producto p inner join TipoProducto tp ON p.TipoProductoId=tp.tipoId");
        //    //return query.ToList();
        //}
    }
}
