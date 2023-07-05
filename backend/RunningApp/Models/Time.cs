using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace RunningApp.Models;

public partial class Time
{

    public int Id { get; set; }

    [Column(TypeName = "decimal(18,4)")]
    public decimal? Rundistance { get; set; }

    public string TotalTime { get; set; }

    public int UserId { get; set; }

    public Time()
    {

    }

}
