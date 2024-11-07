class VotingService
{
  private List<Election> activeElections;

  public VotingService()
  {
    activeElections = new List<Election>();
  }
  public Election CreateNewElection()
  {
    var hardcodedOptions = new List<ElectionOption>
    {
      new ElectionOption("Høyre"),
      new ElectionOption("Arbeiderpartiet"),
    };

    Election newElection = new Election(hardcodedOptions);

    activeElections.Add(newElection);

    return newElection;
  }
}