﻿namespace WebLanches.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        public string CategoriaNome { get; set; }

        public string Descricao { get; set; }

        //Relacionamento de 1 para muitos

        public List<Lanche> Lanches { get; set;}
    }
}