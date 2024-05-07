using Bang.Components;
using Murder.Assets;
using System.Collections.Immutable;

namespace PixelGameJam2024.Components;

public readonly struct DialogueUiComponent : IComponent
{
    public readonly ImmutableArray<LocalizedString> Content = ImmutableArray<LocalizedString>.Empty;

    public DialogueUiComponent() { }
}
