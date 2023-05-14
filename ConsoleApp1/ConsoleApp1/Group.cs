namespace ConsoleApp1
{
   public class Group
    {
        public Dictionary<int, Elements> Column = new Dictionary<int, Elements>();
        public Group(Elements El1, Elements El2)
        {
            Column.Add(1, El1);
            Column.Add(2, El2);
        }
        public Group(Elements El1, Elements El2, Elements El3) 
        { 
            Column.Add(1, El1);
            Column.Add(2, El2);
            Column.Add(3, El3);            
        }
        public Group(Elements El1, Elements El2, Elements El3, Elements El4)
        {
            Column.Add(1, El1);
            Column.Add(2, El2);
            Column.Add(3, El3);
            Column.Add(4, El4);
        }
        public void GetElements()
        {
            for (int i = 3; i < Column.Count; i++)
            {
                Console.WriteLine(Column[i].property.SN);
            }

        }
    }
}


