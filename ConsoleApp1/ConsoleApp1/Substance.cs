namespace ConsoleApp1
{
    public class Substance
    {

        public AlchemyReaction Reaction;
        public String formule;
        public List<Elements> Elements = new List<Elements>();
        public Substance(Molecule molecule1, Molecule molecule2, AlchemyReaction reaction)
        {
            Reaction = reaction;

            Reaction.Molecule1 = molecule1;

            Reaction.Molecule2 = molecule2;

            Reaction.StartReaction();

            formule = Reaction.formule;
        }

    }
    public class AlchemyReaction
    {
        public Molecule Molecule1;
        public Molecule Molecule2;
        public Molecule molecule = new Molecule();
        public String formule;


        public virtual void StartReaction()
        {

        }
    }

    public class CompoundReaction : AlchemyReaction
    {
        public override void StartReaction()
        {
            
            for (int i = 0; i < Molecule1.Elements.Count; i++)
            {
                molecule.Elements.Add(Molecule1.Elements[i]);
            }
            for (int i = 0; i < Molecule2.Elements.Count; i++)
            {
                molecule.Elements.Add(Molecule2.Elements[i]);
            }
                int metall = 0;

            for(int i = 0; i < molecule.Elements.Count; i++)
            {
                if (molecule.Elements[i].property.priority == 1)
                {
                    metall++;
                }
            }
            if (metall == 0)
            {
                if (molecule.Elements[0].property.OxState > molecule.Elements[1].property.OxState)
                {
                    molecule.Elements[0].property.priority = 1;
                }
                else if (molecule.Elements[0].property.OxState < molecule.Elements[1].property.OxState)
                {
                    molecule.Elements[1].property.priority = 1;
                }

            }

            formule = molecule.ShowMolecule();

        }
    }
    /*
    public class DecompositionReaction : AlchemyReaction
    {
        public DecompositionReaction(Molecule molecule1, Molecule molecule2) : base(molecule1, molecule2)
        {
            Molecule1 = molecule1;
            Molecule2 = molecule2;
        }
        public override void StartReaction()
        {

        }
    }
    public class SubstitutionReaction : AlchemyReaction
    {
        public SubstitutionReaction(Molecule molecule1, Molecule molecule2) : base(molecule1, molecule2)
        {
            Molecule1 = molecule1;
            Molecule2 = molecule2;
        }
        public override void StartReaction()
        {

        }
    }
    public class ExchangeReaction : AlchemyReaction
    {
        public ExchangeReaction(Molecule molecule1, Molecule molecule2) : base(molecule1, molecule2)
        {
            Molecule1 = molecule1;
            Molecule2 = molecule2;
        }
        public override void StartReaction()
        {

        }
    }*/
}
