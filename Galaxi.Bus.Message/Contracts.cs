namespace Galaxi.Bus.Message
{
    public record TickedCreated
    {
        public int FunctionId { get; init; }
        public int NumSeat { get; init; }
        public string Email { get; init; }
    }
    public record MovieDetails
    {
        public int FunctionId { get; init; }
        public int NumSeat { get; init; }
        public string Email { get; init; }
    }

    public record CheckAvailableMovie
    {
        public Guid MovieId { get; init; }
    }

    public record MovieStatus
    {
        public bool Exist { get; init; }
    }
}
