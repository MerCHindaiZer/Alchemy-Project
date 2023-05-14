namespace ConsoleApp1
{
public class ElementsDBase
{

    public Dictionary<int, Elements> Table = new Dictionary<int, Elements>();

    public Dictionary<int, Molecule> Substances = new Dictionary<int, Molecule>();


    public ElementsDBase()
    {

        Elements H = new Elements(1, "H", 1, 1);
        Elements He = new Elements(2, "He", 5,0);
        Elements Li = new Elements(3, "Li", 3,1);
        Elements Be = new Elements(4, "Be",4, 2);
        Elements B = new Elements(5, "B", 1,3);
        Elements C = new Elements(6, "C", 2, 4);
        Elements N = new Elements(7, "N", 2, 3);
        Elements O = new Elements(8, "O", 2, 2);
        Elements F = new Elements(9, "F", 2,1);
        Elements Ne = new Elements(10, "Ne", 5, 0);
        Elements Na = new Elements(11, "Na", 3, 1);
        Elements Mg = new Elements(12, "Mg", 4, 2);
        Elements Al = new Elements(13, "Al", 1, 3);
        Elements Si = new Elements(14, "Si", 2, 4);
        Elements P = new Elements(15, "P", 2, 3);
        Elements S = new Elements(16, "S", 2, 2);
        Elements Cl = new Elements(17, "Cl", 2, 1);
        Elements Ar = new Elements(18, "Ar", 5, 0);
        Elements K = new Elements(19, "K",3, 1);
        Elements Ca = new Elements(20, "Ca",4, 2);
        Elements OH = new Elements(50, "OH", 6, 1);

        Molecule Water = new Molecule();
        Water.Elements.Add(H);
        Water.Elements.Add(H);
        Water.Elements.Add(O);

        Molecule Cl2 = new Molecule();
        Cl2.Elements.Add(Cl);
        Cl2.Elements.Add(Cl);

        Molecule CO3 = new Molecule();
         CO3.Elements.Add(C);
         CO3.Elements.Add(O);
         CO3.Elements.Add(O);
         CO3.Elements.Add(O);





        Table.Add(1, H);
        Table.Add(2, He);
        Table.Add(3, Li);
        Table.Add(4, Be);
        Table.Add(5, B);
        Table.Add(6, C);
        Table.Add(7, N);
        Table.Add(8, O);
        Table.Add(9, F);
        Table.Add(10, Ne);
        Table.Add(11, Na);
        Table.Add(12, Mg);
        Table.Add(13, Al);
        Table.Add(14, Si);
        Table.Add(15, P);
        Table.Add(16, S);
        Table.Add(17, Cl);
        Table.Add(18, Ar);
        Table.Add(19, K);
        Table.Add(20, Ca);
        Table.Add(50, OH);

        Substances.Add(1, Water);
        Substances.Add(2, Cl2);
        Substances.Add(3, CO3);

    }
}
}