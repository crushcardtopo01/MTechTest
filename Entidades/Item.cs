namespace test1.Entidades
{
    public class Item
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }

        public Item(string nombre,int cantidad, double precio) => (Nombre,Cantidad,Precio) = (nombre,cantidad,precio);

        public override string ToString (){
            return $"Nombre: \"{Nombre}\" Cantidad: {Cantidad}  Precio: {Precio}";
        }
    }
}