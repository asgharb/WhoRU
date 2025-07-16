using WhoRU.Domain.Enums;

namespace WhoRU.Domain.Entities.DynamicForms;

public class FormField
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public Guid FormId { get; set; }
    public string Label { get; set; } = null!;
    public string Name { get; set; } = null!; // »—«Ì ò·«Ì‰  Ì« „œ· œ«œÂ
    public FormFieldType FieldType { get; set; }

    public bool IsRequired { get; set; } = false;
    public int? MaxLength { get; set; }
    public int? MinLength { get; set; }
    public string? Placeholder { get; set; }
    public string? DefaultValue { get; set; }

    public Form? Form { get; set; }

    public ICollection<FormFieldOption> Options { get; set; } = new List<FormFieldOption>();
}
