namespace CRUD_ENTITYFRAMEWORK_Y_WEBSERVICES
{
    public class Producto
    {
        public int Id_Producto { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public string? Marca { get; set; }
        public decimal Precio { get; set; }
        public decimal Stock { get; set; }
    }
}
