
namespace RunningApp.DTO
{
    public class TimeDTO
    {
        public int UserId { get; set; }

        public decimal? Rundistance { get; set; }

        public decimal? AveragePace { get; set; }

        public string TotalTime { get; set; } = null!;

    }
}
