using TestesUnitarios.Desafio.Console.Services;

ValidacoesLista vl = new ValidacoesLista();

var listaMista = new List<int> { 5, -1, -8, 9 };

List<int> listaPositivos = vl.RemoverNumerosNegativos(listaMista);

foreach(int num in listaPositivos)
{
    Console.WriteLine(num);
}
