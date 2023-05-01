using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

public class Place : Object
{
    public Place() => Type = new List<string>() { "Place" };

    /// <summary>
    /// Indicates the accuracy of position coordinates on a Place objects. Expressed in properties of percentage. e.g. "94.0" means "94.0% accurate".
    /// </summary>
    [Range(0, 100, ErrorMessage = "Needs to be between 0 and 100 representing a percentage.")]
    [JsonPropertyName("accuracy")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public float? Accuracy { get; set; }

    /// <summary>
    /// Indicates the altitude of a place. The measurement units is indicated using the units property. If units is not specified, the default is assumed to be "m" indicating meters.
    /// </summary>
    [JsonPropertyName("altitude")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public float? Altitude { get; set; }

    /// <summary>
    /// The latitude of a place.
    /// </summary>
    [JsonPropertyName("latitude")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public float? Latitude { get; set; }

    /// <summary>
    /// The longitude of a place.
    /// </summary>
    [JsonPropertyName("longitude")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public float? Longitude { get; set; }

    /// <summary>
    /// The radius from the given latitude and longitude for a Place. The units is expressed by the units property. If units is not specified, the default is assumed to be "m" indicating "meters".
    /// </summary>
    [Range(0, float.MaxValue, ErrorMessage = "Needs to be larger than or equal to 0.")]
    [JsonPropertyName("radius")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public float? Radius { get; set; }

    /// <summary>
    /// Specifies the measurement units for the radius and altitude properties on a Place object. If not specified, the default is assumed to be "m" for "meters".
    /// </summary>
    [JsonPropertyName("units")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string? Units { get; set; }
}
