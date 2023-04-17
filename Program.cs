/***
 * 1) Observe o trecho de código abaixo:

int INDICE = 13, SOMA = 0, K = 0;

enquanto K < INDICE faça
{
K = K + 1;
SOMA = SOMA + K;
}

imprimir(SOMA);

Ao final do processamento, qual será o valor da variável SOMA?


2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

IMPORTANTE:
Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;


3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:
• O menor valor de faturamento ocorrido em um dia do mês;
• O maior valor de faturamento ocorrido em um dia do mês;
• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.

IMPORTANTE:
a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal;
b) Podem existir dias sem faturamento, como nos finais de semana e feriados. Estes dias devem ser ignorados no cálculo da média;


4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:

SP – R$67.836,43
RJ – R$36.678,66
MG – R$29.229,88
ES – R$27.165,48
Outros – R$19.849,53

Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve dentro do valor total mensal da distribuidora.
 
5) Escreva um programa que inverta os caracteres de um string.

IMPORTANTE:
a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
b) Evite usar funções prontas, como, por exemplo, reverse;


NÃO SE ESQUEÇA DE INSERIR O LINK DO SEU REPOSITÓRIO NO GITHUB COM O CÓDIGO FONTE QUE VOCÊ DESENVOLVEU
***/

Console.WriteLine("Fim da questão 4 do teste:");
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