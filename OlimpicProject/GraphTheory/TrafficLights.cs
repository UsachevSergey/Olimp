using System; 
 
class TrafficLights
{
    public static void X()
    { 
        string[] inputstr = Console.ReadLine().Split(' ');
        int CountRoad = int.Parse(inputstr[1]);
        int CountCrossRoad = int.Parse(inputstr[0]);
        int[] CrosRoad = new int[CountCrossRoad]; 
        for (int i = 0; i < CountRoad; i++)
        { 
            string[] currentRoads = Console.ReadLine().Split(' ');
            int roadA = int.Parse(currentRoads[0]); int roadB = int.Parse(currentRoads[1]);
            CrosRoad[roadA - 1]++;
            CrosRoad[roadB - 1]++;
        }
        string result = "";
        foreach (var item in CrosRoad)
        {
            result += item + " ";
        }
        result.Trim();
        Console.WriteLine(result); 
    } 
}