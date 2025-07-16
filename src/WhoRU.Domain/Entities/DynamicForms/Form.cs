namespace WhoRU.Domain.Entities.DynamicForms;

public class Form
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public ICollection<FormField> Fields { get; set; } = new List<FormField>();
}
