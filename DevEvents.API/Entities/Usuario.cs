using System;

namespace DevEvents.API.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
    }
}