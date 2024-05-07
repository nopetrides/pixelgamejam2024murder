using Bang.Components;

namespace PixelGameJam2024.Messages;

public readonly struct AgentReleaseInputMessage : IMessage
{
    public readonly int Button;
    public AgentReleaseInputMessage(int button)
    {
        this.Button = button;
    }
}
