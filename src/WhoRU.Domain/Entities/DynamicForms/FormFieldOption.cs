namespace WhoRU.Domain.Entities.DynamicForms;

public class FormFieldOption
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public Guid FormFieldId { get; set; }
    public string Value { get; set; } = null!;
    public string? DisplayText { get; set; }

    public FormField? FormField { get; set; }
}
