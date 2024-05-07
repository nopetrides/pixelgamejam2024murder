using Murder;
using Murder.Serialization;
using System.Text.Json;

namespace PixelGameJam2024;

/// <summary>
/// <inheritdoc cref="IMurderGame"/>
/// </summary>
public class PixelGameJam2024Game : IMurderGame
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Name => "PixelGameJam2024";

    public JsonSerializerOptions Options => PixelGameJam2024SerializerOptionsExtensions.Options;
}
