﻿using System.Globalization;

double largura;
double comprimento, area, valorMetro, valorTerreno;
largura =  double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
valorMetro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
area = largura * comprimento;

valorTerreno = area * valorMetro;
// saida
Console.WriteLine("AREA -" + area.ToString("F2",CultureInfo.InvariantCulture));
Console.WriteLine("PRECO = " + valorTerreno. ToString("F2", CultureInfo.InvariantCulture));










