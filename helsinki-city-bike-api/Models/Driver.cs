namespace BikeApp.Drivers;
public class Driver {
    public int Id {get;set;}
    public string Departure {get;set;} = null!;
    public string Return {get;set;} = null!;
    public int DepartureStationId {get;set;}
    public string DepartureStationName {get;set;} = null!;
    public int ReturnStationId {get;set;}
    public string ReturnStationName {get;set;} = null!;
    public int CoveredDistance {get;set;}
    public int Duration {get;set;}
}