using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__project
{
    internal class Prodotti
    {

        private int _idprod;
        public int Idprod
        { 
            get { return _idprod; }
        }

        private string _nome;
        public string nome { get; set; }


        private double _prezzo;
        public double prezzo { get; set; }


        private int _quantità;
        public int quantità { get; set; }


        private string _gusto;
        public string gusto { get; set; }

        public virtual bool isProdottiB { get; } = false;
        public Prodotti(int id, string nome, double pr, int quantità, string gusto)
        {
          this._idprod = id;
          this.nome = nome;
          this.prezzo = pr;
          this.quantità = quantità;
          this.gusto = gusto;

        }
    }

    internal class ProdottiB : Prodotti
    {
        private int _persone;
       public int persone { get; set; }
        public override bool isProdottiB { get; } = true;

        public ProdottiB(int id, string nome, double pr, int quantità, string gusto, int persone) : base(id, nome, pr, quantità, gusto)
        {
            this.persone = persone;
        }   
    }
}
