using System;
using System.Data;

namespace DesktopCRUD.Models;

public class Flight
{
    public string FlightNumber { get; set; }
    public string DepartureAirport { get; set; }
    public string ArrivalAirport { get; set; }
    public DateTime DateDeparture { get; set; }
    public DateTime DateArrival { get; set; }
    public double Price { get; set; }
}