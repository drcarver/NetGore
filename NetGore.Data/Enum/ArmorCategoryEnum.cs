namespace NetGore.Data.Enum;

/// <summary>
/// Anyone can put on a suit of armor or strap a shield 
/// to an arm. Only those proficient  in the armor’s 
/// use know how to wear it effectively, however.
/// Your class gives you proficiency with certain 
/// types of  armor.If you wear armor that you lack 
/// proficiency with, you have disadvantage on any 
/// ability check, saving throw, or attack roll that
/// involves Strength or Dexterity, and you can’t cast
/// spells.
/// </summary>
public enum ArmorCategoryEnum
{
    /// <summary>
    /// Heavier armor interferes with the
    /// wearer’s ability to move quickly, stealthily, 
    /// and freely.	If the Armor table shows “Str 13”
    /// or  “Str 15” in the Strength column for	an 
    /// armor type, the armor reduces the wearer’s 
    /// speed by 10	feet unless the wearer has a
    /// Strength score equal to or higher than
    /// the listed score
    /// </summary>
    HeavyArmor,

    /// <summary>
    /// Medium armor offers more protection than light
    /// armor, but it also impairs movement more.If you
    /// wear medium  armor,	you add your Dexterity
    /// modifier, to a maximum of +2, to the base	
    /// number from your armor type to determine your
    /// Armor Class.
    /// </summary>
    MediumArmor,

    /// <summary>
    /// Made from supple and thin materials, light 
    /// armor favors agile adventurers since it 
    /// offers some protection without sacrificing 
    /// mobility.If you wear light armor, you add 
    /// your Dexterity modifier to the base number 
    /// from your armor type to determine your
    /// Armor Class.
    /// </summary>
    LightArmor,

    /// <summary>
    /// A shield is made from wood or metal and
    /// is carried in	one hand.Wielding a shield increases
    /// your Armor Class by 2. You can benefit from only
    /// one shield at a time
    /// </summary>
    Shields
}
