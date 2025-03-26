Console.WriteLine("Digite a espécie do animal: "); 
string especie = Console.ReadLine();

Console.WriteLine("Digite a raça do animal: ");
string raca = Console.ReadLine();

Console.WriteLine("Atende pela alcunha de: ");
string alcunha = Console.ReadLine();

Console.WriteLine("Digite a idade do animal: ");
string idade = Console.ReadLine();

Console.WriteLine("Digite a pelagem/cor do animal: ");
string pelagem = Console.ReadLine();

Console.WriteLine("+===============================================================+");
Console.WriteLine("|                    Pet Hotel \"Nem um pio\"                     |");
Console.WriteLine("+===============================================================+");
Console.WriteLine("| Espécie: " + especie.ToUpper().Trim().PadLeft(15, '.').Substring(0, 15) +
                  " | Raça: " + raca.ToUpper().Trim().PadLeft(28, '.').Substring(0, 28) + " |");
Console.WriteLine("+===============================================================+");
Console.WriteLine("| Atende pela Alcunha de: " + alcunha.ToUpper().Trim().PadLeft(37, '.').Substring(0, 37) + " |");
Console.WriteLine("| Idade: " + idade.Trim().ToUpper().PadLeft(2, '0').Substring(0, 2) + " ano(s)" +
                  " | Pelagem/cor: " + pelagem.Trim().ToUpper().PadLeft(29, '.').Substring(0, 29) + " |");
Console.WriteLine("+===============================================================+");