namespace GoDungeon.Spells.Enum;

/// <summary>
/// A spell’s description specifies its area of effect, which typically has one 
/// of five different shapes: cone, cube, cylinder, line, or sphere. Every area 
/// of effect has a point of origin, a location from which the spell’s energy erupts. 
/// The rules for each shape specify how you position its point of origin. Typically, 
/// a point of origin is a point in space, but some spells have an area whose origin 
/// is a creature or an object.
/// </summary>
public enum SpellEffectTypeEnum
{
    /// <summary>
    /// A cylinder’s point of origin is the center of a circle of a particular radius, 
    /// as given in the spell description. The circle must either be on the ground or 
    /// at the height of the spell effect. The energy in a cylinder expands in straight 
    /// lines from the point of origin to the perimeter of the circle, forming the base 
    /// of the cylinder. The spell’s effect then shoots up from the base or down from 
    /// the top, to a distance equal to the height of the cylinder.
    /// </summary>
    Radius,
    Touch,
    Creature,

    /// <summary>
    /// You select a sphere’s point of origin, and the sphere extends outward from that 
    /// point. The sphere’s size is expressed as a radius in feet that extends from the 
    /// point.
    /// </summary>
    Sphere,
    Location,

    /// <summary>
    /// A cone extends in a direction you choose from its point of origin. A cone’s 
    /// width at a given point along its length is equal to that point’s distance 
    /// from the point of origin. A cone’s area of effect specifies its maximum length
    /// </summary>
    Cone,
    Special,

    /// <summary>
    /// A line extends from its point of origin in a straight path up to its length 
    /// and covers an area defined by its width.
    /// </summary>
    Line,
    Sight,
    Unlimited,

    /// <summary>
    /// You select a cube’s point of origin, which lies anywhere on a face of the cubic 
    /// effect. The cube’s size is expressed as the length of each side.
    /// </summary>
    Cube,

    Hemisphere
}
