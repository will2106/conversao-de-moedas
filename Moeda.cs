
using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


/*Exercício : Faça um programa de conversão de moedas(câmbio) usando classe, membro e métodos estáticos.
Menu de opções : dólar para real, real para dólar, sair
Personalizar a resposta, usando recursos da linguagem(Bibliotecas)*/




namespace conversor_moeda
{
    public static class Moeda
    {


        public static double dolar { get; set; }   

        public static double real { get; set; }   


        public static double DolarParaReal(double moeda_dolar)
        {

           
            
            real =1;
            dolar=5;
            double conversao= real/dolar;

            return real;



        }


  public static double RealparaDolar(double moeda_real)
        {

           
            real =1;
            dolar=5;
            double conversao= real*dolar;

           

            return dolar;


        }















    }
}