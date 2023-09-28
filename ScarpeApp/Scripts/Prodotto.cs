using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScarpeApp.Models
{
    public class Prodotto
    {
        public int Id_Prodotto { get; set; }
        public string Nome { get; set; }
        public decimal Prezzo { get; set; }
        public string Descrizione { get; set; }
        public bool InVendita { get; set; }
        public string ImmagineCopertina { get; set; }
        public string ImmagineAgg1 { get; set; }
        public string ImmagineAgg2 { get; set; }

        public Prodotto() { }

        public Prodotto(string nome, decimal prezzo, string descrizione, string imgCopertina = "", string img2 = "", string img3 = "")
        {
            Nome = nome;
            Prezzo = prezzo;
            Descrizione = descrizione;
            ImmagineCopertina = imgCopertina;
            ImmagineAgg1 = img2;
            ImmagineAgg2 = img3;
        }
        public Prodotto(int id, string nome, decimal prezzo, string descrizione, bool invendita, string imgCopertina = "", string img2 = "", string img3 = "")
        {
            Id_Prodotto = id;
            Nome = nome;
            Prezzo = prezzo;
            Descrizione = descrizione;
            ImmagineCopertina = imgCopertina;
            ImmagineAgg1 = img2;
            ImmagineAgg2 = img3;
            InVendita = invendita;
        }
    }
}