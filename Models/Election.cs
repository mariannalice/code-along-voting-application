class Election 
{
  public Guid id;
  public  List<ElectionOption> options;
  public  List<Vote> castVotes;

  public Election(List<ElectionOption> electionOptions)
  {
    if (electionOptions.Count <= 1)
    {
      throw new ArgumentException("An election needs at least two options");
    }
    options = electionOptions;
    castVotes = new List<Vote>();
    id = Guid.NewGuid();
  }
}

