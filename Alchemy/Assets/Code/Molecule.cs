using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class Molecule : MonoBehaviour
    {
        public List<Elements> Elements = new List<Elements>();

        public string formule;

        public string ShowMolecule()
        {
            CreateMolecule();

            for (int i = 0; i < Elements.Count; i++)
            {
                if (Elements[i].property.priority == 1)
                {
                    if (Elements[i].count > 1)
                        formule += Elements[i].simbol.ToString() + Elements[i].count.ToString();
                    else
                        formule += Elements[i].simbol.ToString();

                }
            }
            for (int i = 0; i < Elements.Count; i++)
            {
                if (Elements[i].property.priority > 1)
                {
                    if (Elements[i].count > 1)
                        formule += Elements[i].simbol.ToString() + Elements[i].count.ToString();
                    else
                        formule += Elements[i].simbol.ToString();

                }
            }
            return formule;
        }
        void CreateMolecule()
        {

            for (int i = 0; i != Elements.Count; i++)
            {
                for (int e = 0; e != Elements.Count;)
                {
                    if (e == i) { e++; }

                    else
                    {
                        if (Elements[i].property.SN == Elements[e].property.SN && Elements[i].count >= Elements[e].count)
                        {
                            Elements[i].count++;

                            Elements.RemoveAt(e);
                        }
                        else
                        {
                            e++;
                        }
                    }
                }
            }


        }
    }


