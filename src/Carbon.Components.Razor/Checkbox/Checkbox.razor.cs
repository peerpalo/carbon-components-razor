namespace Carbon.Components.Razor;

public partial class Checkbox : ComponentBase
{
    [Parameter]
    public string? LabelText { get; set; }

    [Parameter]
    public bool HideLabel { get; set; }
}