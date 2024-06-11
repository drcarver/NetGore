using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace GoDungeon.Spells.Interfaces;

public interface ISpellComponent
{
    /// <summary>
    /// Most spells require the chanting of mystic words.The words themselves aren’t 
    /// the source of the spell’s power; rather, the particular combination of sounds, 
    /// with specific pitch and resonance, sets the threads of magic in motion.Thus, 
    /// a character who is gagged or in an area of silence, such as one created by 
    /// the silence spell, can’t cast a spell with a verbal component.
    /// </summary>
    bool Verbal { get; set; }

    /// <summary>
    /// Spell casting gestures might include a forceful gesticulation or an intricate 
    /// set of gestures.If a spell requires a somatic component, the caster must have 
    /// free use of at least one hand to perform these gestures.
    /// </summary>
    bool Somatic { get; set; }

    /// <summary>
    /// Casting some spells requires particular objects, specified in parentheses in 
    /// the component entry.A character can use a component pouch or a spell casting 
    /// focus(found in “Equipment”) in place of the components specified for a spell.
    /// But if a cost is indicated for a component, a character must have that specific 
    /// component before he or she can cast the spell.
    /// <para>
    /// If a spell states that a material component is consumed by the spell, the 
    /// caster must provide this component for each casting of the spell.
    /// </para>
    /// <para>
    /// A spell caster must have a hand free to access a spell’s material components—or 
    /// to hold a spell casting focus—but it can be the same hand that he or she uses to 
    /// perform somatic components.
    /// </para>
    /// </summary>
    bool Material { get; set; }

    /// <summary>
    /// The material components of the spell
    /// </summary>
    ObservableCollection<string> Materials { get; set; }
}