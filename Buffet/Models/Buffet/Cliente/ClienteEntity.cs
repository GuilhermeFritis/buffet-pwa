using System;
using System.ComponentModel.DataAnnotations;

namespace Buffet.Models.Buffet.Cliente
{
    public class ClienteEntity
    {
        [Key] public int Id { get; set; }
        [Required] public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public int Idade { get; set; }

        public string Sobrenome { get; set; }
    }
}