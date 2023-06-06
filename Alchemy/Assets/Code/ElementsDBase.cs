using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    public class ElementsDBase : MonoBehaviour
    {

        public Dictionary<int, Elements> Table = new Dictionary<int, Elements>();

        public Dictionary<int, Molecule> Substances = new Dictionary<int, Molecule>();


        public ElementsDBase()
        {

            Elements H = new Elements(1, "H", 1, 1);
        H.property.Mass = 1.008f;
        H.property.PP = "Бесцветный, легкий (в 14,5 раз легче воздуха), трудно сжимаемый газ";
        H.property.Temp = -259.2f;
        H.property.Speed = 999f;
        H.property.Activity = "при комнатной температуре мало активен и реагирует толькос фтором, на свету - с хлором.";
            Elements He = new Elements(2, "He", 5, 0);
        He.property.Mass = 1f;
        He.property.PP = "газ";
        He.property.Temp = -259.2f;
        He.property.Speed = 1f;
        He.property.Activity = "малоактивен";
            Elements Li = new Elements(3, "Li", 3, 1);
        Li.property.Mass = 1f;
        Li.property.PP = "мягкий металл серебристо-белого цвета";
        Li.property.Temp = 180f;
        Li.property.Speed = 1f;
        Li.property.Activity = " Очень активный ";

            Elements Be = new Elements(4, "Be", 4, 2);
        Be.property.Mass = 1f;
        Be.property.PP = "серебристо-белый, твердый, хрупкий";
        Be.property.Temp = 1287f;
        Be.property.Speed = 1847.7f; //поменять скорость на плотность
        Be.property.Activity = "Активен";
        
            Elements B = new Elements(5, "B", 1, 3);
        B.property.Mass = 10.811f;
        B.property.PP = "бесцветный, серый или краный кристалличкий, либо темный амфотерный полуметалл";
        B.property.Temp = 2075f;
        B.property.Speed = 100000f;
        Be.property.Activity = "малоактивен";
            Elements C = new Elements(6, "C", 2, 4);
        C.property.Mass = 1f;
        C.property.PP = "существует во множестве модфикаций с разнообразными физическими свойствами";
        C.property.Temp = 1860f;
        C.property.Speed = 2.25f;
        C.property.Activity = "Активен";
            Elements N = new Elements(7, "N", 2, 3);
        N.property.Mass = 14.00643f;
        N.property.PP = "бесцветный газ, не имеет запаха";
        N.property.Temp = -209f;
        N.property.Speed = 0.808f;
        N.property.Activity = "Очень активен";
            Elements O = new Elements(8, "O", 2, 2);
        O.property.Mass = 1f;
        O.property.PP = "бесцветный газ без вкуса и запаха";
        O.property.Temp = -183f;
        O.property.Speed = 0.00142897f;
        O.property.Activity = "активен";
            Elements F = new Elements(9, "F", 2, 1);
        F.property.Mass = 1f;
        F.property.PP = "бледно-желтый газ";
        F.property.Temp = -88.12f;
        F.property.Speed = -1.696f;
        F.property.Activity = "Очень активен";
            Elements Ne = new Elements(10, "Ne", 5, 0);
        Ne.property.Mass = 20.179f;
        Ne.property.PP = "легкий газ";
        Ne.property.Temp = -245.98f;
        Ne.property.Speed = 1.444f;
        Ne.property.Activity = "Неактивен";
            Elements Na = new Elements(11, "Na", 3, 1);
        Na.property.Mass = -1f;
        Na.property.PP = "Серебристо-белый металл, в тонких слоях с фиолетовым оттенком, пластичен";
        Na.property.Temp = 98.86f;
        Na.property.Speed = 0.96842f;
        Na.property.Activity = "Очень активен";
            Elements Mg = new Elements(12, "Mg", 4, 2);
        Mg.property.Mass = 24.304f;
        Mg.property.PP = "Серебристо-белый щелочной металл";
        Mg.property.Temp = 650f;
        Mg.property.Speed = 1.738f;
        Mg.property.Activity = "Очень активен";
            Elements Al = new Elements(13, "Al", 1, 3);
        Al.property.Mass = -1f;
        Al.property.PP = "металл серебристо-белого цвета, легкий";
        Al.property.Temp = 390f;
        Al.property.Speed = 2712f;
        Al.property.Activity = "Очень активен";
            Elements Si = new Elements(14, "Si", 2, 4);
        Si.property.Mass = 28.085f;
        Si.property.PP = "тёмно-серое твёрдое хрупкое кристалличское вещество с металлическим блеском";
        Si.property.Temp = 1410f;
        Si.property.Speed = 2.33f;
        Si.property.Activity = "Малоактивен";
            Elements P = new Elements(15, "P", 2, 3);
        P.property.Mass = 3.973f;
        P.property.PP = "может быть белым, чёрнм и красым";
        P.property.Temp = 44.15f;
        P.property.Speed = 1.82f;
        P.property.Activity = "Активен";
            Elements S = new Elements(16, "S", 2, 2);
        S.property.Mass = 32.065f;
        S.property.PP = "хрупкое вещество желтого цвета";
        S.property.Temp = 119f;
        S.property.Speed = 2.070f;
        S.property.Activity = "Очень активен";
            Elements Cl = new Elements(17, "Cl", 2, 1);
        Cl.property.Mass = 35.446f;
        Cl.property.PP = "ядовитый удущающий двухатомный газ желтовато-зеленоо цвета";
        Cl.property.Temp = -100.95f;
        Cl.property.Speed = 3.21f;
        Cl.property.Activity = "Очень активен";
            Elements Ar = new Elements(18, "Ar", 5, 0);
        Ar.property.Mass = 39.948f;
        Ar.property.PP = "одноатомный газ";
        Ar.property.Temp = -185.9f;
        Ar.property.Speed = 1.784f;
        Ar.property.Activity = "Неактивен";
            Elements K = new Elements(19, "K", 3, 1);
        K.property.Mass = -1f;
        K.property.PP = "Серебристый цвет, легкоплавкий";
        K.property.Temp = 63.65f;
        K.property.Speed = 0.856f;
        K.property.Activity = "Очень активен";
            Elements Ca = new Elements(20, "Ca", 4, 2);
        Ca.property.Mass = 40.078f;
        Ca.property.PP = "металл серебристо-белого цвета";
        Ca.property.Temp = -850f;
        Ca.property.Speed = 1.55f;
        Ca.property.Activity = "";
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
