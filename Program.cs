
Start();

static void Start()
{
    Console.Clear();

    Console.WriteLine("Informe a string de colchetes para determindas se está balanceada:");
    Console.WriteLine("------------------------------------------------------------------");
    Console.ResetColor();

    var value = Console.ReadLine();
    var IsBalanced = BalancedSupport.IsBalanced(value);
    var responseText = $"O valor informado {(IsBalanced ? String.Empty : "NÃO ")}está balanceado";

    Console.WriteLine(responseText);
}