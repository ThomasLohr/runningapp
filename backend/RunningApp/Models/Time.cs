using System.Text.Json.Serialization;

namespace RunningApp.Models;

public partial class Time
{

    public int Id { get; set; } 

    public decimal? Rundistance { get; set; }

    public decimal AveragePace  { get; set; }

    public string TotalTime { get; set; }

    public int UserId { get; set; }
   
    public User User { get; set; }


    public Time(string totalTime, decimal runDistance, decimal averagePace, int userId, User user)
    {
        TotalTime = totalTime;
        Rundistance = runDistance;
        AveragePace = averagePace;
        UserId = userId;
        User = user;
    }

    public Time()
    {

    }

}
