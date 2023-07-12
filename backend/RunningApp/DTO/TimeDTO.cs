
namespace RunningApp.Dto
{
    public class TimeDto
    {
        public int UserId { get; set; }

        public decimal? Rundistance { get; set; }

        public decimal? AveragePace { get; set; }

        public string TotalTime { get; set; } = null!;

    }
}
