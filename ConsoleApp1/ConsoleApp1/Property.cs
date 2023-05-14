// See https://aka.ms/new-console-template for more information
namespace ConsoleApp1
{
    public class Property
    {
        public int SN; // Serial Number

        public int OxState; // Oxide State

        public int group;

        public int priority;
    }

    public class Metall : Property
    {
        public int ActiveMetallID; // 1 - активные металлы 2 - средней активности 3 - Неактиные металлы
        public Metall()
        {
            priority = 1;

            if(group == 1 || SN == 20)
            {
                ActiveMetallID = 1;
            }
            else if(SN == 12 || SN == 13)
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
            priority = 2;
            group = 50;
            OxState = -1;

        }
    }
    public class Alkaline : Property 
    {
        public Alkaline()
        {
            priority = 1;
            group = 1;
            OxState = 1;
        }
    }
    public class AlkalineEarth : Property
    {
        public AlkalineEarth()
        {
            group = 2;
            OxState = 2;
        }
    }
    public class NobleGas : Property
    {
        public NobleGas()
        {
            group = 8;
            OxState = 0;
            
        }
    }
    public class NonMetall : Property
    {
        public NonMetall()
        {
            priority = 2;
            OxState *= -1;
        }
    }
}
    




