namespace WebAPI.DTO
{
    public class RouteDto
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string ArrivalTime { get; set; }
        public string DepartureTime { get; set; }
        public string DepartureCode { get; set; }
        public string ArrivalCode { get; set; }
        public string Hours { get; set; }
        public string Minutes { get; set; }
    }
}
