using System;

namespace DesktopCRUD.Models;

public class ClientFlight
{
    public int UserId { get; set; }
    public string UserName { get; set; }
    public string UserSurname { get; set; }
    public DateTime UserBirthDay { get; set; }
    public string UserPassport { get; set; }
    public string UserPhone { get; set; }
    public string FlightNumber { get; set; }
    public string DepartureAirport { get; set; }
    public string ArrivalAirport { get; set; }
    public DateTime DateDeparture { get; set; }
    public DateTime DateArrival { get; set; }
    public double Price { get; set; }
}