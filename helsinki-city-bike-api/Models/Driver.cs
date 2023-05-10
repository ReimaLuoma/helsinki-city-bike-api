namespace BikeApp.Drivers;

[Microsoft.EntityFrameworkCore.Keyless]
public class Driver {
    public string Departure {get;set;} = null!;
    public string Return {get;set;} = null!;
    public string DepartureStationId {get;set;} = null!;
    public string DepartureStationName {get;set;} = null!;
    public string ReturnStationId {get;set;} = null!;
    public string ReturnStationName {get;set;} = null!;
    public int CoveredDistance {get;set;}
    public int Duration {get;set;}
}