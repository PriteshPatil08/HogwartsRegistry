namespace HogwartsRegistry.Core;

// The parent entity. Id starts at 0 — means "not yet saved to DB".
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string House { get; set; } = "";
}

// Child entity — StudentId is a FK to Student.Id.
// If StudentId == 0, we have a bug: parent wasn't saved first.
public class WandAllocation
{
    public int StudentId { get; set; }
    public string WandCore { get; set; } = "";
    public double LengthInches { get; set; }
}

// Second child entity — same FK dependency on Student.Id.
public class HousePoints
{
    public int StudentId { get; set; }
    public int Points { get; set; }
}