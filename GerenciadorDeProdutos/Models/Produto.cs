using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace GerenciadorDeProdutos.Model
{
    public class Produto
    {
        public Produto()
        {
        }
        public Produto(long iD_PRODUTO, string dESCRICAO, double? pRECO)
        {
            ID_PRODUTO = iD_PRODUTO;
            DESCRICAO = dESCRICAO;
            PRECO = pRECO;
        }

        [Key]
        public long ID_PRODUTO { get; set; }

        public string DESCRICAO { get; set; }
        public double? PRECO { get; set; }
    }
}