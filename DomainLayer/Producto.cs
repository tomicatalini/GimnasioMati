using System.Collections.Generic;

namespace DomainLayer
{
    public class Producto
    {
        public int CodProducto { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public float Precio { get; set; }
        public float Contenido { get; set; }
        public int Stock { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }

        public virtual int TipoProductoId { get; set; }
        public virtual TipoProducto TipoProducto { get; set; }

        public virtual IList<LineaMovimiento> LineaMovimientos { get; set; }

        public Producto()
        {

        }

        public Producto(int codProducto, string marca, string nombre, TipoProducto tipoProd, float contenido, float precio, string descripcion)
        {
            this.CodProducto = codProducto;
            this.Marca = marca;
            this.Nombre = nombre;
            this.TipoProductoId = tipoProd.Id;
            this.TipoProducto = tipoProd;
            this.Contenido = contenido;
            this.Precio = precio;
            this.Descripcion = descripcion;
            this.Stock = 1;
            this.Activo = true;

            this.LineaMovimientos = new List<LineaMovimiento>();
        }
    }
}