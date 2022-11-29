using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop
{
    //definisco la mia classe rettangoli
    public class Prodotto

    {
        //// CARATTERISTICHE / PROPRIETA' che voglio tracciare (di un rettangolo)

        private int codice;
        public string nome;
        public string descrizione;
        public double prezzo;
        public int iva;


        public Prodotto()
        {

        }

        public Prodotto(string nome, string descrizione, double prezzo, int iva)
        { this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva; 
        }


        public void IvaProdotto(int iva)
        {

            if (iva != 4 && iva != 10 && iva != 22)
            {
                this.iva = iva;

            }
            else
            {
                Console.WriteLine("Non hai inserto un l'iva");
            }
        }




        private int SetMain()
        {
            Random rnd = new Random();
            int randumNumero = rnd.Next();
            return randumNumero;
        }

        private double SetPrezzoIva()
        { if(iva== 10)
            {  this.prezzo = prezzo - (prezzo * 0.1); 
            }else if (iva==4)
            {
                return this.prezzo = prezzo - (prezzo * 0.04);
            } else if (iva == 22)
            {
                return this.prezzo = prezzo - (prezzo * 0.22);
            }
            return prezzo;

        }



        public void StampaProdotto()
        {
            Console.WriteLine("Codice: " + SetMain() );
            Console.WriteLine("Nome: " + nome );
            Console.WriteLine("Descrizione: " + descrizione);
            Console.WriteLine("Prezzo: " + prezzo + "£ ");
            Console.WriteLine("Iva: " + iva + " %");
            Console.WriteLine("Prezzo con iva: " + SetPrezzoIva + "£ ");
        }







    }
}
