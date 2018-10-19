using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.DataBase;
using DomainLayer;
using DataLayer;

namespace BusinessLayer.Controladores
{
    public class ControladorProducto
    {

        UnitOfWork iUnitOfWork;

        public ControladorProducto()
        {
            this.iUnitOfWork = new UnitOfWork(new GymMatiContext());
        }

        public void AltaProducto(int codProducto, string marca, string nombre, string tipoProd, float contenido, float precio, string descripcion)
        {
            var tipoProducto = this.iUnitOfWork.ProductoRepository.GetTiposProductos().Where(tipo => tipo.Nombre == tipoProd).First();
           

            var unProd = new Producto(codProducto, marca, nombre, tipoProducto, contenido, precio, descripcion);
            this.iUnitOfWork.ProductoRepository.Add(unProd);
        }

        public IList<Producto> BuscarProductos(string cadena)
        {
            return this.iUnitOfWork.ProductoRepository.GetByCadena(cadena);
        }

        public void ModificarProducto(int codProducto, string marca, string nombre, string tipoProd, float contenido, float precio, string descripcion)
        {
                        
            var unProducto = this.iUnitOfWork.ProductoRepository.Get(codProducto);
            var tipoProducto = this.iUnitOfWork.ProductoRepository.GetTiposProductos().Where(tipo => tipo.Nombre == tipoProd).First();

            unProducto.Marca = marca;
            unProducto.Nombre = nombre;
            unProducto.TipoProducto = tipoProducto;
            unProducto.Contenido = contenido;
            unProducto.Precio = precio;
            unProducto.Descripcion = descripcion;

        }

        public void BajaProducto(int codProducto)
        {

            var unProducto = this.iUnitOfWork.ProductoRepository.Get(codProducto);
            unProducto.Activo = false;
        }

        public int NumeroNuevoProducto()
        {
            var listaProductos = this.iUnitOfWork.ProductoRepository.GetAll().ToList();
            
            if (listaProductos.Any())
            {
                var ultProducto = listaProductos.Last();
                return (ultProducto.CodProducto + 1);
            }
            else
            {
                return 1;
            }
        }

        public void GuardarCambios()
        {
            this.iUnitOfWork.Complete();
        }

        public List<TipoProducto> GetTipoProductos()
        {
            return this.iUnitOfWork.TipoProductoRepository.GetAll().ToList();
        }

        public void AddTipoProducto(int id, string nombre)
        {
            this.iUnitOfWork.TipoProductoRepository.Add(new TipoProducto(id, nombre));
        }

        public List<Producto> GetProductos()
        {
            return this.iUnitOfWork.ProductoRepository.GetAll().ToList();
        }

        //public List<ProductoDTO> listaBuscarProducto()
        //{
        //    return this.iUnitOfWork.ProductoRepository.listaBuscarProducto().ToList();
        //}

        public Producto GetProducto(int codigo)
        {
            return this.iUnitOfWork.ProductoRepository.Get(codigo);
        }

        public void ModificarPrecioProducto(int codProd, float precio)
        {
            var unProd = this.GetProducto(codProd);

            unProd.Precio = precio;
        }
    }
}
