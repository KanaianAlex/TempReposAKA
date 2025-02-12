using ModusProjekt;

Console.WriteLine("gebe folgenden ein, um den Modus auszugeben: modccl");

string modccl = "modccl";

string befehl = Console.ReadLine()!;

if (befehl == modccl)
{
    ModusBerechnen.Mdsccl();
}
else
{
    Console.WriteLine("Befehl nicht vorhanden.");
}

Console.ReadLine();