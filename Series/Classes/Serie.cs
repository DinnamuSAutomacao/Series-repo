using Series.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Series.Classes
{
    public class Serie : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool isExcluido { get; set; }

        public Serie() {}

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.isExcluido = false;
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append("Genero: " + this.Genero + Environment.NewLine);
            retorno.Append("Titulo: " + this.Titulo + Environment.NewLine);
            retorno.Append("Descrição: " + this.Descricao + Environment.NewLine);
            retorno.Append("Ano: " + this.Ano + Environment.NewLine);
            
            return retorno.ToString();
        }

        public string RetornaTitulo()
        {
            return this.Titulo;
        }

        public int RetornaId()
        {
            return this.Id;
        }

        public void Exclui()
        {
            this.isExcluido = true;
        }
    }
}
