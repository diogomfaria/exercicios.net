Console.WriteLine("Informe a estimativa otimista:");
double otms = double.Parse(Console.ReadLine());

Console.WriteLine("Informe a estimativa pessimista:");
double pess = double.Parse(Console.ReadLine());

Console.WriteLine("Informe a estimativa mais provável:");
double prov = double.Parse(Console.ReadLine());

Console.WriteLine($"Otimista: {otms}");
Console.WriteLine($"Pessimista: {pess}");
Console.WriteLine($"Provavel: {prov}");
Console.WriteLine($"PERT = {(otms + pess + (4 * prov)) / 6}");
