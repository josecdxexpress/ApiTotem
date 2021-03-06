﻿namespace CDX.Totem.Core.Infraestrutura.Enum
{
    /// <summary>
    /// Situação (inativo, ativo, excluido)
    /// </summary>
    public enum SituacaoEnum
    {
        Inativo = 0,
        Ativo = 1,
        Excluido = 2
    }

    public enum TipoRetorno
    {
        Url = 1,
        Imagem = 2
    }

    public class Output
    {
        public bool Status { get; set; }
        public string Mensagem { get; set; }
    }
}
