public class Program_UI
{
    private readonly DeveloperRepository _repo = new DeveloperRepository();

    public void Run()
    {
        RunApplication();
        SeedDeveloperList();
    }

    public void RunApplication()
    {
        bool isRunning = true;
        while(isRunning)
        {
            Console.Clear();
            System.Console.WriteLine("Menu:\n" +
                                    "________\n\n" +
                                    "1. Developer Directory\n" +
                                    "2. Developer Team Directory\n" +
                                    "3. Run Pluralsight License Report\n" +
                                    "0. Exit Application"
                                    );
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    SeeAllDevs();
                    break;
                case "2":
                    //
                    break;
                case "3":
                    //GetDevsWithoutLicense();
                    break;
                case "0":
                    isRunning = false;
                    System.Console.WriteLine("Press any key to exit application.");
                    Console.ReadKey();
                    break;
                default:
                    System.Console.WriteLine("Invalid selection. Please try again!");
                    break;
            }
        }
    }

    // private void GetDevsWithoutLicense()
    // {
    //     Console.Clear();
    //     List<Developer> listOfDevs = _repo.GetDeveloperByNoLicense();   
    //     if (hasPluralsight == false)
    //     {
    //         foreach (var dev in listOfDevs)
    //         {
    //             SeeDevsDetails(dev);
    //          }
    //      }
    //      return null;
    // }

    private void SeeAllDevs()
    {
        Console.Clear();
        List<Developer> listOfDevs = _repo.GetAllDevelopers();

        if (listOfDevs.Count>0)
        {
            foreach(var dev in listOfDevs)
            {
                SeeDevsDetails(dev);
            }
        }
        else
        {
            System.Console.WriteLine("Can't find the developers; please try again.");
        }
        Console.ReadKey();
    }

    private void SeeDevsDetails(Developer dev)
    {
        System.Console.WriteLine($"Developer ID: {dev.Id}\n" +
                                $" Name: {dev.FullName}\n" +
                                $"Has Pluralslight License: {dev.HasPluralsight}\n");
    }

    private void CreateTeam(Developer)
    _devsDb.Add(<List>Developer)

    private void SeedDeveloperList()
    {
        Developer dev1 = new Developer(1, "Stan", "Marsh", true);   
        Developer dev2 = new Developer(2, "Kyle", "Broflovski", true);
        Developer dev3 = new Developer(3, "Eric", "Cartman", true);
        Developer dev4 = new Developer(4, "Kenny", "McCormick", true);
        Developer dev5 = new Developer(5, "Tina", "Belcher", false);
        Developer dev6 = new Developer(6, "Jimmy Jr.", "Pesto", false);
        Developer dev7 = new Developer(7, "Calvin", "Fischoder", false);
        Developer dev8 = new Developer(8, "Linda", "Belcher", false);

        _repo.AddDeveloper(dev1);
        _repo.AddDeveloper(dev2);
        _repo.AddDeveloper(dev3);
        _repo.AddDeveloper(dev4);
        _repo.AddDeveloper(dev5);
        _repo.AddDeveloper(dev6);
        _repo.AddDeveloper(dev7);
        _repo.AddDeveloper(dev8);
    }
}