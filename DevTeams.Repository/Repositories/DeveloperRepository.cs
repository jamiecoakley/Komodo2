public class DeveloperRepository
{
    private readonly List<Developer> _devsDb = new List<Developer>();
    private readonly List<Teams> _teamsDb = new List<Teams>();
    private int _count;


//CREATE
    public bool AddDeveloper (Developer developer)
    {
        int startingCount = _devsDb.Count;
        _devsDb.Add(developer);

        if (_devsDb.Count > startingCount)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool CreateDeveloperTeam(Teams team)
    {
        int startingCount = _teamsDb.Count;
        _teamsDb.Add(team);
        if(_teamsDb.Count > startingCount)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

//READ
    public List<Developer> GetAllDevelopers()
    {
        return _devsDb;
    }

    public Developer GetDeveloperByID(int id)
    {
        foreach (var dev in _devsDb)
        {
            if (dev.Id == id)
            {
                return dev;
            }
        }
        return null;
    }
    public Developer GetDeveloperByNoLicense(bool hasPluralsight)
    {   
        foreach (var dev in _devsDb)
        {
            if (hasPluralsight == false)
            {
                return dev;
            }
        }
        return null;
    }

    public List<Teams> GetAllTeams()
    {
        return _teamsDb;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                
    }

//UPDATE
    public void AddToTeam(Developer id)
    {

        if (id != null)
        {
            List<Developer>.Add(id);
        }
    }
}
