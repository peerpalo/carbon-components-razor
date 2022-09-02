namespace Carbon.Components.Razor;

public abstract class ComponentBase : Microsoft.AspNetCore.Components.ComponentBase
{
    // +17 to avoid any numbers and be in conflict with HTML id
    [Parameter]
    public string Id { get; set; } = string.Concat(Guid.NewGuid().ToString("N").Select(c => (char)(c + 17)));

    [Parameter]
    public string Prefix { get; set; } = "cds";

    [Parameter]
    public bool Disabled { get; set; }

    [Parameter(CaptureUnmatchedValues = true)]
    public IDictionary<string, object>? AdditionalAttributes { get; set; }

    protected string GetCssClass(string component, string? additionalClass = null, bool? condition = null) 
        => condition ?? true ? $"{Prefix}--{component}{additionalClass}" : string.Empty;

}
