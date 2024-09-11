using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace TargetTest
{
	public class Program
	{
		public static void Main(string[] args)
		{
			FirstQuestion();
			SecondQuestion();
			ThirdQuestion();
			FourthQuestion();
			FifthQuestion();
		}
		
		public static void FirstQuestion()
		{
		  int INDICE = 12, SOMA = 0, K = 1;

      while(K < INDICE)
      { 
        K = K + 1; 
        SOMA = SOMA + K;
      }
      
      Console.Write("First Question Response: " + SOMA);
		}
		
		public static void FourthQuestion()
		{
		  var dailyBilling = GenerateBilling();
		  int daysCount = 365;
		  
		  var minorBillingValue = dailyBilling.Where(x => x != 0).Min();
		  var maxBillingValue = dailyBilling.Max();
		  var daysUpperAverage = BillingDaysCountUpperAvarage(dailyBilling);
		  
		  Console.Write("Minor billing value: " + minorBillingValue + "\n");
		  Console.Write("Max billing value: " + maxBillingValue + "\n");
		  Console.Write("Days count upper average: " + daysUpperAverage + "\n");
		}
		
		//Carrega a lista de faturamento dos 365 dias com valores aleatorios
		private static List<int> GenerateBilling()
		{
		  var resultList = new List<int>();
		  
		  Random rnd = new Random();
		  for(int j = 1; j <= 365; j++)
      {
          resultList.Add(rnd.Next(0, 9000));
      }
      return resultList;
		}
		
		private static int BillingDaysCountUpperAvarage(List<int> billingList)
		{
		  var anualAverage = billingList.Average();
		  
		  return billingList.Where(b => b > anualAverage).Count();
		  
		}
		
		private static void SecondQuestion()
		{
		  Console.Write("\n\nSecond Question Response: a) 9 b) 128 c) 49 d) 100 e) 13 f) 200\n\n");
		}
		
		private static void ThirdQuestion()
		{
		  System.Text.StringBuilder sb = new System.Text.StringBuilder();
		  sb.Append("SELECT s.code, c.corporateName, p.number, pt.description FROM Client as c \n")
		  .Append("JOIN State as s \n")
		  .Append("ON c.stateId = s.stateId \n")
      .Append("JOIN Phone as p \n")
      .Append("ON c.clientId = p.clientId \n")
      .Append("JOIN PhoneType as pt \n")
      .Append("ON p.phoneTypeId = pt.phoneTypeId \n")
      .Append("WHERE s.code = 'SP')\n\n");
      
		  Console.Write(sb.ToString());
		}
		
		private static void FifthQuestion()
		{
		  string st = "Considerando que as duas cidades tem a mesma distância, podemos representar em uma linha no eixo X." +
		  "Ao se cruzarem ambos estariam  na mesma posição com a mesma distância de Ribeirão. Porém ao se cruzarem o veículo" +
		  "mais próximo de Ribeirão será o caminhão pois ele ser aproximaria mais da cidade enquanto o carro se afastaria";
		  Console.Write(st);
		}
	}
}
