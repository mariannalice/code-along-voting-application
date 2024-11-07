internal class Program
{
  private static void Main(string[] args)
  {
    var builder = WebApplication.CreateBuilder(args);
    var app = builder.Build();

    VotingService votingService = new VotingService();

    app.MapGet("/health", () => "Healthy");
    app.MapPost("/valg", () =>              
    {
      Election newElection = votingService.CreateNewElection();

      return Results.Ok(new{ id = $"/valg{newElection.id}"});
    });

    app.Run();
  }

}
