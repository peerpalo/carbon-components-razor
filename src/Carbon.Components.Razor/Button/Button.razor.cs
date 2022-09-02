namespace Carbon.Components.Razor;

public partial class Button : ComponentBase
{

    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    [Parameter]
    public ButtonKind Kind { get; set; } = ButtonKind.Primary;
}