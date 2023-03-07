using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace RunningApp.Models;

public partial class Time
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int? Id { get; set; }

    public string Firstname { get; set; }

    public string? Lastname { get; set; } 

    public int? Age { get; set; }

    public decimal? Rundistance { get; set; }

    public string TotalTime { get; set; }

    public Time(string firstName, string lastName, int age, string totalTime, decimal runDistance)
    {
        Firstname = firstName;
        Lastname = lastName;
        Age = age;
        TotalTime = totalTime;
        Rundistance = runDistance;
    }

    public Time()
    {

    }

}
