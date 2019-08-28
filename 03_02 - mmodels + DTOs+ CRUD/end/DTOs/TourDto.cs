namespace ExploreCalifornia.DTOs
{
    public class TourDto //different from Tour to hide Note field
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}