namespace ConsoleApp1
{
    public class Elements 
    {

        public Property property;

        public int count;

        public String simbol;
        public Elements(int sn, String sim, int propertyID, int oxstate)
        {

           if(propertyID == 1)
                property = new Metall();
           if(propertyID == 2)
                property = new NonMetall();
           if(propertyID == 3)
                property = new Alkaline();
           if(propertyID == 4)
                property = new AlkalineEarth();
           if(propertyID == 5)
                property = new NobleGas();
           if(propertyID == 6)
                property = new hydroxide();

           property.OxState = oxstate;

           property.SN = sn;

           simbol = sim;

           count = 1;

        }
    }
}

