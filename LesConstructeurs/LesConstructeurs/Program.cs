namespace LesConstructeurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building(8, 17.5);

            Console.WriteLine("La taille du batiment : " + building.Getsize()+"\n");
            Console.WriteLine("Le nombre detage du batiment : "+building.GetFloorCount()+"\n");
            Console.WriteLine("La taille maximal de letage : " +building.GetFloorMaxSize()+"\n");
           
        }
    }
}
