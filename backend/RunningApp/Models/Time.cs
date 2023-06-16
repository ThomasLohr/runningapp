using System.Text.Json.Serialization;

namespace RunningApp.Models;

public partial class Time
{

    public int Id { get; set; } 

    public decimal? Rundistance { get; set; }

    public string TotalTime { get; set; }

    public int UserId { get; set; }

    public Time()
    {

    }

}
