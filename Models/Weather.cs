using System.ComponentModel.DataAnnotations;

namespace WeatherApp.Models;

public class Weather
{
    public int Id {get; set;}
    public string? Location { get; set; }
    [DataType(DataType.Date)]
    public DateTime Date { get; set; }
    public int Temperature { get; set; }
    public int Precipitation { get; set; }
    public int Wind { get; set; }
    public int Humidity { get; set; }


}