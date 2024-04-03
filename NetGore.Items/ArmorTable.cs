using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Base;

namespace NetGore.Items;

public class ArmorTable : BaseObject
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public ArmorTable()
    {
    }

    /// <summary>
    /// Armor Table
    /// </summary>
    public List<ArmorEntry> Armor { get; set; } =
    [
        #region Light - Padded
        //Padded 5	gp 11	+	Dex modifier — Disadvantage 8	lb.
        new ArmorEntry
        {
            ArmorProficiencyEnum = ArmorProficiencyEnum.LightArmor,
            Name = nameof(ArmorEnum.Padded),
            Description = "Padded",
            Cost = 5,
            AC = 11,
            MaxDexterity = null,
            Stealth = false,
            Strength = null,
            Weight = 8,
        },
        #endregion

        #region Light - Leather
        //Leather 10 gp 11+Dex modifier — — 10	lb.
        new ArmorEntry
        {
            ArmorProficiencyEnum = ArmorProficiencyEnum.LightArmor,
            Name = nameof(ArmorEnum.Leather),
            Description = "Leather",
            Cost = 10,
            AC = 11,
            MaxDexterity = null,
            Stealth = true,
            Strength = null,
            Weight = 10,
        },
        #endregion

        #region Light - Studded leather
        // Studded leather 45 gp 12+Dex modifier — — 13	lb.
        new ArmorEntry
        {
            ArmorProficiencyEnum = ArmorProficiencyEnum.LightArmor,
            Name = nameof(ArmorEnum.StuddedLeather),
            Description = "Studded leather",
            Cost = 45,
            AC = 12,
            MaxDexterity = null,
            Stealth = true,
            Strength = null,
            Weight = 13,
        },
        #endregion

        #region Medium - Hide
        //Hide 10gp 12+Dex modifier(max 2) — — 12	lb.
        new ArmorEntry
        {
            ArmorProficiencyEnum = ArmorProficiencyEnum.MediumArmor,
            Name = nameof(ArmorEnum.Hide),
            Description = "Hide",
            Cost = 10,
            AC = 12,
            MaxDexterity = 2,
            Stealth = true,
            Strength = null,
            Weight = 12,
        },
        #endregion

        #region Medium - Chain shirt
        //Chain shirt 50gp 13+Dex modifier(max 2) — — 20lb.
        new ArmorEntry
        {
            ArmorProficiencyEnum = ArmorProficiencyEnum.MediumArmor,
            Name = nameof(ArmorEnum.ChainShirt),
            Description = "Chain shirt",
            Cost = 50,
            AC = 13,
            MaxDexterity = 2,
            Stealth = true,
            Strength = null,
            Weight = 20,
        },
        #endregion

        #region Medium - Scale mail
        //Scale mail 50	gp 14+Dex modifier(max 2) — Disadvantage 45	lb.
        new ArmorEntry
        {
            ArmorProficiencyEnum = ArmorProficiencyEnum.MediumArmor,
            Name = nameof(ArmorEnum.ScaleMail),
            Description = "Scale mail",
            Cost = 50,
            AC = 14,
            MaxDexterity = 2,
            Stealth = false,
            Strength = null,
            Weight = 45,
        },
        #endregion

        #region Medium - Breastplate
        //Breastplate 400gp 14+Dex modifier(max 2) — — 20	lb.
        new ArmorEntry
        {
            ArmorProficiencyEnum = ArmorProficiencyEnum.MediumArmor,
            Name = nameof(ArmorEnum.Breastplate),
            Description = "Breastplate",
            Cost = 400,
            AC = 14,
            MaxDexterity = 2,
            Stealth = false,
            Strength = null,
            Weight = 20,
        },
        #endregion

        #region Medium - Half plate
        //Half plate 750gp 15+Dex modifier(max 2) — Disadvantage 40	lb.
        new ArmorEntry
        {
            ArmorProficiencyEnum = ArmorProficiencyEnum.MediumArmor,
            Name = nameof(ArmorEnum.Halfplate),
            Description = "Half plate",
            Cost = 750,
            AC = 15,
            MaxDexterity = 2,
            Stealth = false,
            Strength = null,
            Weight = 40,
        },
        #endregion

        #region Heavy Armor - Ring mail
        //Ring mail 30gp 14 — Disadvantage 40	lb.
        new ArmorEntry
        {
            ArmorProficiencyEnum = ArmorProficiencyEnum.HeavyArmor,
            Name = nameof(ArmorEnum.Ringmail),
            Description = "Ring mail",
            Cost = 30,
            AC = 14,
            MaxDexterity = null,
            Stealth = false,
            Strength = null,
            Weight = 40,
        },
        #endregion

        #region Heavy Armor - Chain mail
        //Chain mail 75gp 16 Str 13 Disadvantage 55lb.
        new ArmorEntry
        {
            ArmorProficiencyEnum = ArmorProficiencyEnum.HeavyArmor,
            Name = nameof(ArmorEnum.Chainmail),
            Description = "Chain mail",
            Cost = 75,
            AC = 16,
            MaxDexterity = null,
            Stealth = false,
            Strength = 13,
            Weight = 55,
        },
        #endregion

        #region Heavy Armor - Splint
        //Splint 200gp 17 Str 15 Disadvantage 60lb.
        new ArmorEntry
        {
            ArmorProficiencyEnum = ArmorProficiencyEnum.HeavyArmor,
            Name = nameof(ArmorEnum.Splint),
            Description = "Splint",
            Cost = 200,
            AC = 17,
            MaxDexterity = null,
            Stealth = false,
            Strength = 15,
            Weight = 60,
        },
        #endregion

        #region Heavy Armor - Plate
        //Plate 1,500gp 18 Str 15 Disadvantage 65lb.
        new ArmorEntry
        {
            ArmorProficiencyEnum = ArmorProficiencyEnum.HeavyArmor,
            Name = nameof(ArmorEnum.Plate),
            Description = "Plate",
            Cost = 1500,
            AC = 18,
            MaxDexterity = null,
            Stealth = false,
            Strength = 15,
            Weight = 65,
        },
        #endregion

        #region Shield
        //Shield 10	gp +2 — — 6	lb.
        new ArmorEntry
        {
            ArmorProficiencyEnum = ArmorProficiencyEnum.Shields,
            Name = nameof(ArmorEnum.Shield),
            Description = "Scale mail",
            Cost = 10,
            AC = 2,
            MaxDexterity = null,
            Stealth = false,
            Strength = null,
            Weight = 6,
        },
        #endregion
    ];
}
