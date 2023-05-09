/*Exercício : Faça um programa de conversão de moedas(câmbio) usando classe, membro e métodos estáticos.
Menu de opções : dólar para real, real para dólar, sair
Personalizar a resposta, usando recursos da linguagem(Bibliotecas)*/



using conversor_moeda;



Console.WriteLine(@$"

 *****************************************
|      Programa Conversor de Moedas       |
|                                         |
|                                         |
|          1.Dolar para Real              |    
|          2.real para Dolar              |
|          0. Sair                        |
|                                         |
|                                         |
 *****************************************



");




char opcao = char.Parse(Console.ReadLine());
;


while (opcao!=0)
{

Console.WriteLine($"Digite a moeda que deseja converter:");

 opcao=char.Parse(Console.ReadLine());


if (opcao=='1')
{
    



Console.WriteLine($"voce escolheu a opcao 1, sera convertido dolar para real");


Moeda. DolarParaReal(1);


}


    
}