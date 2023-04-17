
Console.WriteLine("Questão 1 do teste:");
int indice = 13, soma = 0, k = 0;
while (k < indice)
{
    k = k + 1;
    soma = soma + k;
    Console.WriteLine($"k:{k}, soma: {soma}");
}

Console.Write(soma);
Console.WriteLine("Fim da questão 1 do teste:");




Console.WriteLine("Questão 4 do teste:");

var SP = 67838.43;
var RJ = 36678.66;
var MG = 29229.88;
var ES = 27165.48;
var outros = 19849.53;

var total = SP + RJ + MG + ES + outros;

var percentSP = (SP * 100) / total;
var percentRJ = (RJ * 100) / total;
var percentMG = (MG * 100) / total;
var percentES = (ES * 100) / total;
var percentOutros = (outros * 100) / total;

Console.WriteLine($"{percentSP.ToString("N2")}%");
Console.WriteLine($"{percentRJ.ToString("N2")}%");
Console.WriteLine($"{percentMG.ToString("N2")}%");
Console.WriteLine($"{percentES.ToString("N2")}%");
Console.WriteLine($"{percentOutros.ToString("N2")}%");

Console.WriteLine("Fim da questão 4 do teste:");

Console.ReadKey();