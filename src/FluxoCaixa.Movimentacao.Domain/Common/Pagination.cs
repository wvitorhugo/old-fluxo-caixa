﻿namespace FluxoCaixa.Movimentacao.Domain.Common
{
    public class Pagination
    {
        public int Skip { get; set; } = 0;
        public int Limit { get; set; } = 10;
    }
}