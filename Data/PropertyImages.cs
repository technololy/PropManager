namespace PropManager.Data
{
    public class PropertyImages
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public int PropertyId { get; set; }

        // Navigation property to represent the relationship
        public Property Property { get; set; }
    }
}
