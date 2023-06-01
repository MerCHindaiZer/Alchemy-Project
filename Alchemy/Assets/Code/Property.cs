using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class Property : MonoBehaviour
    {
        public int SN; // Serial Number

        public int OxState; // Oxide State

        public int group;

        public int priority;

        public string name;
    }

    public class Metall : Property
    {
        public int ActiveMetallID; // 1 - активные металлы 2 - средней активности 3 - Неактиные металлы
        public Metall()
        {
            name = "Metall";
            priority = 1;

            if (group == 1 || SN == 20)
            {
                ActiveMetallID = 1;
            }
            else if (SN == 12 || SN == 13)
            {
                ActiveMetallID = 2;
            }
            else
            {
                ActiveMetallID = 3;
            }
        }
    }

    public class hydroxide : Property
    {
        public hydroxide()
        {
            name = "hydroxide";
            priority = 2;
            group = 50;
            OxState = -1;

        }
    }
    public class Alkaline : Property
    {
        public Alkaline()
        {
            name = "Alkaline";
            priority = 1;
            group = 1;
            OxState = 1;
        }
    }
    public class AlkalineEarth : Property
    {
        public AlkalineEarth()
        {
            name = "AlkalineEarth";
            group = 2;
            OxState = 2;
        }
    }
    public class NobleGas : Property
    {
        public NobleGas()
        {
            name = "NobleGas";
            group = 8;
            OxState = 0;

        }
    }
    public class NonMetall : Property
    {
        public NonMetall()
        {
            name = "NonMetall";
            priority = 2;
            OxState = -OxState;
        
        }
    }

