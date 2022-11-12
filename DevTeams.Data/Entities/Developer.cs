
public class Developer
{
        public Developer(){}

    public Developer
    (
        int id,
        string firstName,
        string lastName,
        bool hasPluralSight
    ) 
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        HasPluralsight = hasPluralSight;
    }
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName 
    { get
        {
            return $"{FirstName} {LastName}";
        }
    }
    public bool HasPluralsight { get; set; }
}
