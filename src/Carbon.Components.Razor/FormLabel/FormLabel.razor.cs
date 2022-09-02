namespace Carbon.Components.Razor;

public partial class FormLabel : ComponentBase
{
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}
