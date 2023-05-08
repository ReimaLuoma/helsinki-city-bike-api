namespace BikeApp.Drivers;

public class Driver {
    public string Departure {get;set;}
    public string Return {get;set;}
    public string DepartureStationId {get;set;}
    public string DepartureStationName {get;set;}
    public string ReturnStationId {get;set;}
    public string ReturnStationName {get;set;}
    public int CoveredDistance {get;set;}
    public int Duration {get;set;}
}