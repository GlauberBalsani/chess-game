﻿using ChessGame.Domain;
using ChessGame.Domain.Models;
using ChessGame.Domain.Models.Xadrez;




Tabuleiro tabuleiro = new Tabuleiro(8, 8);

tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0,0));
tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(0,0));
tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(1,3));
tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(2,4));

Tela.ImprimirTabuleiro(tabuleiro);