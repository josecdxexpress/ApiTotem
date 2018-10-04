using System.Collections.Generic;

namespace CDX.Totem.Core.Infraestrutura.Api
{
    public class RetornoDebitosVeiculo<T>
    {
        public RetornoDebitosVeiculo()
        {
        }

        public RetornoDebitosVeiculo(T elemento)
        {
            Debitos = elemento;
        }

        public string Mensagem { get; set; }

        public ResultadoOperacao Status { get; set; }

        public T Debitos { get; set; }

        public string Renavam { get; set; }

        public string Placa { get; set; }

        public string Nome { get; set; }

        public string Municipio { get; set; }

        public string Uf { get; set; }
    }

    public class Retorno<T>
    {
        public Retorno()
        {
            Mensagens = new List<MensagemSistemaDto>();
        }

        public Retorno(T elemento)
        {
            Objeto = elemento;
            Mensagens = new List<MensagemSistemaDto>();
        }

        public List<MensagemSistemaDto> Mensagens { get; set; }

        public ResultadoOperacao Status { get; set; }

        public T Objeto { get; set; }

        public void AdicionarMensagem(string identificador, params string[] argumentos)
        {
            if (Mensagens == null)
            {
                Mensagens = new List<MensagemSistemaDto>();
            }

            Mensagens.Add(new MensagemSistemaDto
            {
                Identificador = identificador,
            });
        }
    }

    public class MensagemSistemaDto
    {
        public string Titulo { get; set; }

        public string Mensagem { get; set; }

        public string Identificador { get; set; }
    }
    public enum ResultadoOperacao
    {
        Indefinido = 0,

        Sucesso = 1,

        Falha = 2,

        Alerta = 3,

        Info = 4
    }
}