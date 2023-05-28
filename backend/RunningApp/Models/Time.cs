using System.Text.Json.Serialization;

namespace RunningApp.Models;

public partial class Time
{

    public int Id { get; set; } 

    public decimal? Rundistance { get; set; }  

    public string TotalTime { get; set; }

    public int UserId { get; set; }
   
    public User User { get; set; }


    public Time(string totalTime, decimal runDistance, int userId, User user)
    {
        TotalTime = totalTime;
        Rundistance = runDistance;
        UserId = userId;
        User = user;
    }

    public Time()
    {

    }

}
