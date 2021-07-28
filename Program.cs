using System;
using test1.Entidades;
namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            var carrito = new ShoppingCart();

            for (int i = 1 ; i<= 3 ; i++)
            {
                carrito.agregarItem(new Item(("item"+i),i,(i+0.5)));
            }
            carrito.comprar();
        }
    }
}
