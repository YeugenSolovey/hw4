//task 4
public interface GeograficObj
{
    public virtual void GetInfo(int xCoord, int yCoord, string name, string description, int spead, int riverLong)
    { }
    public virtual void GetInfo(int xCoord, int yCoord, string name, string description, int highestPoint)
    { }
}


class River : GeograficObj
{
    string res;
    public void GetInfo(int xCoord, int yCoord, string name, string description, int spead, int riverLong)
    {
        res = "x coord: " + xCoord.ToString() + " - y cood: " + yCoord.ToString() + " - name: " +
           name + " - description: " + description + " - spead(sm/sec): " + spead.ToString() + " - river long: " + riverLong.ToString();
    }
    public void ShowInfo()
    {
        Console.WriteLine(res);
    }
}

class Mountain : GeograficObj
{
    string res;
    public void GetInfo(int xCoord, int yCoord, string name, string description, int highestPoint)
    {
        res = "x coord: " + xCoord.ToString() + " - y cood: " + yCoord.ToString() + " - name: " +
            name + " - description: " + description + " - highest point: " + highestPoint.ToString();
    }
    public void ShowInfo()
    {
        Console.WriteLine(res);
    }
}



internal class Program
{
    private static void Main(string[] args)
    {
        int xCoord;
        int yCoord;
        string name;
        string description;

        int spead;
        int riverLong;
        int highestPoint;
        try
        {
            Console.WriteLine("Enter river params: \n");

            Console.WriteLine("Enter x coord: ");
            xCoord = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y coord: ");
            yCoord = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter description: ");
            description = Console.ReadLine();
            Console.WriteLine("Enter speed: ");
            spead = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter river long: ");
            riverLong = Convert.ToInt32(Console.ReadLine());

            River r = new River();
            r.GetInfo(xCoord, yCoord, name, description, spead, riverLong);
            r.ShowInfo();


            Console.WriteLine("Enter mountain params: \n");

            Console.WriteLine("Enter x coord: ");
            xCoord = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y coord: ");
            yCoord = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter description: ");
            description = Console.ReadLine();
            Console.WriteLine("Enter highest point of mountain: ");
            highestPoint = Convert.ToInt32(Console.ReadLine());

            Mountain m = new Mountain();
            m.GetInfo(xCoord, yCoord, name, description, highestPoint);
            m.ShowInfo();
        }
        catch (FormatException)
        {
            Console.WriteLine("You enter wrong param");
        }

        Console.ReadLine();
    }
}