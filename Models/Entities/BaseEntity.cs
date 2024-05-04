namespace TodoAppMvc.Models.Entities
{
    public class BaseEntity
    {
        public string Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
