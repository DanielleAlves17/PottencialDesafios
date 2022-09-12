﻿using Models.Estacionamento;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

while(exibirMenu){
    
    Console.WriteLine("Digite sua opção: ");
    Console.WriteLine("1 - Cadastrar veiculo");
    Console.WriteLine("2 - Remover veiculo");
    Console.WriteLine("3 - Listar veiculos");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch(opcao)
    {
    case "1":

            es.AdicionarVeiculo();
            break;

    case "2":
            es.RemoverVeiculo();
            break;

    case "3":
            es.ListarVeiculos();
            break;

    case "4":
    exibirMenu = false;
    break;

    default:
    Console.WriteLine("Opção inválida");
    break;
    } 

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();

}

Console.WriteLine("O programa se encerrou");

