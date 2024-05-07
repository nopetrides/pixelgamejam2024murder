using Bang.Components;
using Murder.Attributes;

namespace PixelGameJam2024.Components
{
    [Unique]
    [DoNotPersistEntityOnSave]
    public readonly struct PlayerComponent : IComponent
    {
        public PlayerComponent()
        {
        }
    }
}

