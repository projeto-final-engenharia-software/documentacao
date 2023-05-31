using FactoryMethod_Mercado;
using System.Runtime.CompilerServices;

Console.WriteLine("=======Cliente========");
Console.WriteLine("Informe o local do cliente Brasil(BR) ou EUA(EUA)");
var localCliente = Console.ReadLine().ToUpper();
Console.WriteLine("Informe o tipo do cliente Pessoa Fisica (F) ou Pessoa Juridica(E)");
var tipoEscolhido = Console.ReadLine().ToUpper();

try
{
	ClienteFactoryMethod clienteFactory = ClienteSimpleFactory.CreateClientByLocal(localCliente);

	var cliente = clienteFactory.MontaCliente(tipoEscolhido);
	Console.WriteLine(cliente.MostrarDadosCliente());

}
catch (Exception ex)
{

	Console.WriteLine(ex.Message);
}
