﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Domain.Models
{
    public class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QuantidadeDeMovimento { get; protected set; }
        public Tabuleiro Tabuleiro { get;protected set; }

        public Peca(Tabuleiro tabuleiro, Cor cor) 
        {
            Posicao = null;
            Tabuleiro = tabuleiro;
            Cor = cor;
            QuantidadeDeMovimento = 0;
        
        }
    }
}
