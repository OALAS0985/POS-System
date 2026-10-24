// Parte 1: tipos y sus rangos
Console.WriteLine("=== Rangos de tipos numéricos ===");
Console.WriteLine($"byte:    {byte.MinValue} a {byte.MaxValue}");
Console.WriteLine($"int:     {int.MinValue} a {int.MaxValue}");
Console.WriteLine($"long:    {long.MinValue} a {long.MaxValue}");
Console.WriteLine($"double:  {double.MinValue} a {double.MaxValue}");
Console.WriteLine($"decimal: {decimal.MinValue} a {decimal.MaxValue}");

Console.WriteLine();
Console.WriteLine("=== VARIABLES ===");
string producto = "Pan";
int cantidad = 3;
decimal precio = 500m;
bool disponible = true;
char categoria = 'A';

var total = cantidad * precio; //convertido a decimal automáticamente
const decimal IVA = 0.13m;//constantes no pueden ser modificadas


Console.WriteLine($"{producto} x {cantidad} = {total} (IVA: {IVA})");
Console.WriteLine($"Disponible: {disponible}, Categoria: {categoria}"); 