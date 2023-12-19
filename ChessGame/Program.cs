using ChessGame.Domain;
using ChessGame.Domain.Models;

var posicao = new Posicao(3, 4);

Console.WriteLine($"posicao {posicao}");

Tabuleiro tabuleiro = new Tabuleiro(8, 8);

Tela.ImprimirTabuleiro(tabuleiro);