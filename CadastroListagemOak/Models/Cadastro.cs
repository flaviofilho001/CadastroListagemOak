using CadastroListagemOak.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace CadastroListagemOak.Models
{
    public class Cadastro
    {
        public int Id { get; set; }
        [Display(Name = "Nome do Produto")]
        public string Nome { get; set; }
        [Display(Name = "Descrição do Produto")]
        public string Descricao { get; set; }
        [Display(Name = "Valor do Produto")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public decimal Valor { get; set; }
        [Display(Name = "Disponível")]
        public EDisponivel Disponivel { get; set; }

        //    "CadastroListagemContext": "server=localhost;userid=root;password=admin;database=CadastroListagem"
    }
}
