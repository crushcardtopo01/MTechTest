using System.Collections.Generic;
using System;

namespace test1.Entidades
{
    public class ShoppingCart
    {
        public DateTime fechaCompra { get; set; }
        
        public Double totalCompra { get; set; }

        public List<Item> ListaItems { get; }

        public ShoppingCart(){
            ListaItems = new List<Item>();
            fechaCompra = new DateTime();
            fechaCompra =  DateTime.Now;
        }//end of constructor

        public ShoppingCart(DateTime fecha){
            ListaItems = new List<Item>();
            fechaCompra = new DateTime();
            fechaCompra =  fecha;
        }//end of constructor
        public void agregarItem(Item item){
            this.ListaItems.Add(item);
            totalCompra = ObtenerTotalCompra();

        }//end of agregaritem

        public void comprar(){
            
            SendMessage("----------");
            SendMessage($"Fecha {fechaCompra.ToString()}");
            SendMessage("Lista de productos");
            PrintItems();
            SendMessage($"total de productos: {ObtenerCantidadDeItems()} {System.Environment.NewLine}  Total a pagar: {totalCompra} ");
            SendMessage("----------");
            ShoppingCartReset();

        }//end of comprar
        public  int ObtenerCantidadDeItems(){
            int cantidadDeItems = 0;
            foreach (var item in ListaItems)
            {
                cantidadDeItems = cantidadDeItems+item.Cantidad;
            }//end of ofreach
            return cantidadDeItems;

        }//end of ObtenerCantidadDeItems
        public double ObtenerTotalCompra(){

            double totalCompra=0;
            foreach (var item in ListaItems)
            {
                totalCompra = totalCompra+(item.Cantidad* item.Precio);
            }//end of ofreach
            return totalCompra;
        }//end of ObtenerTotalCompra

        public void PrintItems(){
            foreach (var item in ListaItems){
                SendMessage(item.ToString());
            }//end of foreach
        }//end of PrintItems
        public void ShoppingCartReset(){
            fechaCompra =  DateTime.Now; 
            totalCompra = 0;
            ListaItems.RemoveAll(item => {
                if (item!= null){
                    return true;
                }else{
                    return false;
                }
            });
        }//end of Reset
        public void SendMessage(string menssage){
            System.Console.WriteLine(menssage);
        }//end of send message
    }
}