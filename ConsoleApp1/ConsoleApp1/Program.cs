// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Щас попробую создать класс для молекулы");

ElementsDBase Table = new ElementsDBase();
CompoundReaction compound = new CompoundReaction();

    Molecule C = new Molecule();

    C.Elements.Add(Table.Table[6]);

    Molecule Na2O = new Molecule();

    Na2O.Elements.Add(Table.Table[11]);
    Na2O.Elements.Add(Table.Table[8]);
    Na2O.Elements.Add(Table.Table[11]);

    Molecule CO2 = new Molecule();
    CO2.Elements.Add(Table.Table[8]);
    CO2.Elements.Add(Table.Table[8]);
    CO2.Elements.Add(Table.Table[6]);

Substance substance = new Substance(Na2O, CO2, compound);
List<Elements> biba = new List<Elements>();
biba = substance.Elements.FindAll(p => p.simbol == Table.Substances[3].formule);

Console.WriteLine(substance.Elements.Find(p => p.simbol == Table.Substances[3].formule) != null);

//Console.WriteLine(substance.Reaction.molecule.formule);





