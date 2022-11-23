//task 4
abstract class GeograficObj
{
    int _xCoord;
    int _yCoord;
    string _name;
    string _description;

    int _spead;
    int _riverLong;
    int _highestPoint;

    string res;

    public virtual void GetInfo(int xCoord, int yCoord, string name, string description, int spead, int riverLong)
    {
        _xCoord = xCoord;
        _yCoord = yCoord;
        _name = name;
        _description = description;
        _spead = spead;
        _riverLong = riverLong;

        res = "x coord: " + xCoord.ToString() + " - y cood: " + yCoord.ToString() + " - name: " +
           name + " - description: " + description + " - spead(sm/sec): " + spead.ToString() + " - river long: " + riverLong.ToString();
    }
    public virtual void GetInfo(int xCoord, int yCoord, string name, string description, int highestPoint)
    {

        _xCoord = xCoord;
        _yCoord = yCoord;
        _name = name;
        _description = description;
        _highestPoint = highestPoint;

        res = "x coord: " + xCoord.ToString() + " - y cood: " + yCoord.ToString() + " - name: " +
            name + " - description: " + description + " - highest point: " + highestPoint.ToString() + "\n";
    }
   
    public void ShowInfo()
    {
        Console.WriteLine(res);
    }

}

class River : GeograficObj
{
}

class Mountain : GeograficObj
{
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
        River r = new River();
        Mountain m = new Mountain();
        while (true)
        {
            try
            {
                Console.WriteLine("Enter river params: ");


                Console.WriteLine("Enter name: ");
                name = Console.ReadLine();
                bool flag = char.IsDigit(name[0]);
                if (flag)
                {
                    Console.WriteLine("Invalid name, try later after mountain");
                }
                else if (name[0] == '+')
                {
                    Console.WriteLine("Invalid name, try later after mountain");
                }
                else if (name[0] == '-')
                {
                    Console.WriteLine("Invalid name, try later after mountain");
                }
                else
                {
                    Console.WriteLine("Enter x coord: ");
                    xCoord = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter y coord: ");
                    yCoord = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter description: ");
                    description = Console.ReadLine();
                    Console.WriteLine("Enter speed: ");
                    spead = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter river long: ");
                    riverLong = Convert.ToInt32(Console.ReadLine());
                    r.GetInfo(xCoord, yCoord, name, description, spead, riverLong);
                    r.ShowInfo();
                }


                Console.WriteLine("\nEnter mountain params: ");

                Console.WriteLine("Enter name: ");
                name = Console.ReadLine();
                flag = char.IsDigit(name[0]);
                if (flag)
                {
                    Console.WriteLine("Invalid name, try later after river");
                }
                else if (name[0] == '+')
                {
                    Console.WriteLine("Invalid name, try later after river");
                }
                else if (name[0] == '-')
                {
                    Console.WriteLine("Invalid name, try later after river");
                }
                else
                {
                    Console.WriteLine("Enter x coord: ");
                    xCoord = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter y coord: ");
                    yCoord = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter description: ");
                    description = Console.ReadLine();
                    Console.WriteLine("Enter highest point of mountain: ");
                    highestPoint = Convert.ToInt32(Console.ReadLine());
                    m.GetInfo(xCoord, yCoord, name, description, highestPoint);
                    m.ShowInfo();
                }         
                
                Console.WriteLine("If you want close program enter 1");
                int close = Convert.ToInt32(Console.ReadLine());
                if(close == 1)
                {
                    Console.WriteLine("Program was closing");
                    break;
                }
                else
                {
                    Console.WriteLine("We continue\n");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("You enter wrong param");
            }
        }

        Console.ReadLine();
    }
}