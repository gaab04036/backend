using System;
using MateODragao.Models;

namespace MateODragao
{
    class Program
    {
        static void Main(string[] args){
            bool jogadorNaoDesistiu = true;
            do
            {


                Console.Clear();
                System.Console.WriteLine("==============================");
                System.Console.WriteLine("       Mate o Dragão");
                System.Console.WriteLine("==============================");

                System.Console.WriteLine(" 1 - Iniciar jogo");
                System.Console.WriteLine(" 0 - Sair do jogo");


                string opcaoJogador = Console.ReadLine();

                switch (opcaoJogador) {

                    case "1":
                        Console.Clear();
                        
                        Guerreiro guerreiro = CriarGuerreiro();
                        
                        Dragao dragao =  CriarDragao(); 

                        

                        /* INICIO _ Primeiro Diálogo */
                        CriarDialogo(guerreiro.Nome, $"seu louco! Vim-lhe Derrotar-lhe!");
                        CriarDialogo(dragao.Nome," Humano tolinho. Quem pensas que és?");

                        FinalizarDialogo();

                        /* FIM _ Primeiro Diálogo */

                        /* INICIO _ Segundo Diálogo */
                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}:! Da Casa {guerreiro.Sobrenome} ó criatura morfética");
                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: vim de {guerreiro.CidadeNatal} para derrotar-te e mostrar meu valor");
                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}:QUEM? DE ONDE? Bom, que seja...fritar-te-ei e devorar-te-ei, primata insolente");
                        /* khgvfkjghvgh */

                        System.Console.WriteLine("BAMBAM: É HORA DO SHOWWWWW!");

                        System.Console.WriteLine();
                        System.Console.WriteLine("Aperte ENTER para prosseguir");
                        Console.ReadLine();

                        /* FIM _ Segundo Diálogo */
                        Console.Clear();

                        bool jogadorAtacaPrimeiro = guerreiro.Destreza > dragao.Destreza ? true : false;

                        int poderAtaqueGuerreiro = guerreiro.Forca > guerreiro.Inteligencia ? guerreiro.Forca + guerreiro.Destreza : guerreiro.Inteligencia + guerreiro.Destreza;
                        bool jogadorNaoCorreu = true;

                        if (jogadorAtacaPrimeiro)
                        {
                            System.Console.WriteLine("** Turno do Jogador ***");
                            System.Console.WriteLine("Escolha uma ação:");
                            System.Console.WriteLine(" 1 - Atacar");
                            System.Console.WriteLine(" 2 - Fugir");

                            string opcaoBatalhaJogador = Console.ReadLine();

                            switch (opcaoBatalhaJogador){
                                case "1":
                                    Random geradorNumeroAleatorio = new Random();
                                    int numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                                    int numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);
                                    int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    int DragaoDestrezaTotal = guerreiro.Destreza + numeroAleatorioDragao;

                                    if (guerreiroDestrezaTotal > DragaoDestrezaTotal)
                                    {
                                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Toma essa, lagarto MALJEEETO! BIRLLLLLLL");
                                        dragao.Vida -= poderAtaqueGuerreiro + 5;
                                        System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                        System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");
                                    } else {
                                        System.Console.WriteLine($"[{dragao.Nome.ToUpper()}: Errrrrrrrrou, humanóide");
                                    }


                                    break;
                                case "2":
                                    System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Simbora fii, VLW FLW!");
                                    System.Console.WriteLine($"{dragao.Nome.ToUpper()}: GG EZ");
                                    jogadorNaoCorreu = false;
                                    break;
                            }
                        }

                        System.Console.WriteLine();
                        System.Console.WriteLine("Aperte ENTER para prosseguir");
                        Console.ReadLine();

                        while (guerreiro.Vida > 0 && dragao.Vida > 0 && jogadorNaoCorreu)
                        {
                            Console.Clear();
                            System.Console.WriteLine("*** Turno Dragão ***");
                            Random geradorNumeroAleatorio = new Random();
                            int numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                            int numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);
                            int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                            int DragaoDestrezaTotal = guerreiro.Destreza + numeroAleatorioDragao;

                            if (guerreiroDestrezaTotal < DragaoDestrezaTotal)
                            {
                                System.Console.WriteLine($"{dragao.Nome.ToUpper()}:Fritou o forévis, foi? ");
                                guerreiro.Vida -= dragao.Forca;
                                System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");
                            }
                            else
                            {
                                System.Console.WriteLine($"[{guerreiro.Nome.ToUpper()}: Errou DESGRAÇADO!");
                            }

                            System.Console.WriteLine();
                            System.Console.WriteLine("Aperte o ENTER para prosseguir");
                            Console.ReadLine();

                            Console.Clear();

                            System.Console.WriteLine("** Turno do Jogador ***");
                            System.Console.WriteLine("Escolha uma ação:");
                            System.Console.WriteLine(" 1 - Atacar");
                            System.Console.WriteLine(" 2 - Fugir");

                            string opcaoBatalhaJogador = Console.ReadLine();

                            switch (opcaoBatalhaJogador)
                            {
                                case "1":
                                geradorNumeroAleatorio = new Random();
                                numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                                numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);
                                guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                DragaoDestrezaTotal = guerreiro.Destreza + numeroAleatorioDragao;

                                    if (guerreiroDestrezaTotal > DragaoDestrezaTotal)
                                    {
                                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Toma essa, lagarto MALJEEETO! BIRLLLLLLL");
                                        dragao.Vida -= poderAtaqueGuerreiro + 5;
                                        System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                        System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");
                                    }

                                    else
                                    {
                                        System.Console.WriteLine($"[{dragao.Nome.ToUpper()}: Errrrrrrrrou, humanóide");
                                    }


                                    break;
                                case "2":
                                    System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Simbora fii, VLW FLW!");
                                    System.Console.WriteLine($"{dragao.Nome.ToUpper()}: GG EZ");
                                    jogadorNaoCorreu = false;
                                    break;
                    }

                        }

                        if (guerreiro.Vida<= 0)
                        {
                            System.Console.WriteLine("Você perdeu!");

                        }
                        if (dragao.Vida<= 0)
                        {
                            System.Console.WriteLine("Você Venceu!");
                        }

                        break;
                    case "0":
                        jogadorNaoDesistiu = false;
                        System.Console.WriteLine("GAME OVER");

                        break;
                    default:
                        System.Console.WriteLine("Comando inválido!");
                        break;
                }
            } while (jogadorNaoDesistiu);
        }
    
        public static void CriarDialogo(string Nome, string frase)
        {
            System.Console.WriteLine($"{Nome.ToUpper()}:\n- {frase}"); 
        } 

        public static void FinalizarDialogo() {
            System.Console.WriteLine();
            System.Console.WriteLine("Aperte ENTER para prosseguir");
            Console.ReadLine();
            Console.Clear();
        }


        public static Guerreiro CriarGuerreiro(){
            Guerreiro guerreiro = new Guerreiro();
            guerreiro.Nome = "Soluço";
            guerreiro.Sobrenome = "Salvattore";
            guerreiro.CidadeNatal = "Manhattan";
            guerreiro.DataNascimento = DateTime.Parse("04/06/1319");
            guerreiro.FerramentaAtaque = "Espada";
            guerreiro.FerramentaProtecao = "Escudo";
            guerreiro.Forca = 3;
            guerreiro.Destreza = 3;
            guerreiro.Inteligencia = 2;
            guerreiro.Vida = 22;

            return guerreiro; 

        }

        public static Dragao CriarDragao(){
            Dragao dragao = new Dragao();
            dragao.Nome = "Banguela";
            dragao.Forca = 5;
            dragao.Destreza = 1;
            dragao.Inteligencia = 3;
            dragao.Vida = 300;

            return dragao;
        }
    }
}
