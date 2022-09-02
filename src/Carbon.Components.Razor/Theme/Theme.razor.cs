namespace Carbon.Components.Razor;

public partial class Theme : ComponentBase
{
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}