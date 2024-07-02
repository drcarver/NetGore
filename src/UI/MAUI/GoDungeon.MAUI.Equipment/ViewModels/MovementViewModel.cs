using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.MAUI.Equipment.Interfaces;

namespace GoDungeon.MAUI.Equipment.ViewModels;

public partial class MovementViewModel : ObservableObject, IMovementViewModel
{
    [ObservableProperty]
    private FormattedString pageDescription = new FormattedString();

    [ObservableProperty]
    private FormattedString movementHeader = new FormattedString();

    [ObservableProperty]
    private FormattedString movementBody = new FormattedString();

    [ObservableProperty]
    private FormattedString speedHeader = new FormattedString();

    [ObservableProperty]
    private FormattedString speedBody = new FormattedString();

    [ObservableProperty]
    private FormattedString travelPaceHeader = new FormattedString();

    [ObservableProperty]
    private FormattedString travelPaceBody = new FormattedString();

    [ObservableProperty]
    private FormattedString forcedMarchBoldHeader = new FormattedString();

    [ObservableProperty]
    private FormattedString forcedMarchBoldBody = new FormattedString();

    [ObservableProperty]
    private FormattedString forcedMarchBody = new FormattedString();

    [ObservableProperty]
    private FormattedString mountsandVehiclesBoldHeader = new FormattedString();

    [ObservableProperty]
    private FormattedString mountsandVehiclesBoldBody = new FormattedString();

    [ObservableProperty]
    private FormattedString mountsandVehiclesBody = new FormattedString();

    [ObservableProperty]
    private FormattedString mountsandVehiclesItalicHeader = new FormattedString();

    [ObservableProperty]
    private FormattedString mountsandVehiclesItalic = new FormattedString();

    [ObservableProperty]
    private FormattedString mountsandVehiclesItalicBody = new FormattedString();

    public void Initialize()
    {
        PageDescription.Spans.Add(new Span
        {
            Text = "Rules for managing movement and travel from the 5th Edition (5e) SRD (System Reference Document).\n"
        });

        #region Movement
        MovementHeader.Spans.Add(new Span
        {
            Text = "Movement"
        });
        MovementBody.Spans.Add(new Span
        {
            Text = "Swimming across a rushing river, sneaking down a dungeon corridor, scaling a treacherous mountain slope--all sorts of movement play a key role in fantasy gaming adventures.\n\n"
        });
        MovementBody.Spans.Add(new Span
        {
            Text = "The GM can summarize the adventurers' movement without calculating exact distances or travel times: \"You travel through the forest and find the dungeon entrance late in the evening of the third day.\" Even in a dungeon, particularly a large dungeon or a cave network, the GM can summarize movement between encounters: \"After killing the guardian at the entrance to the ancient dwarven stronghold, you consult your map, which leads you through miles of echoing corridors to a chasm bridged by a narrow stone arch.\"\n\n"
        });
        MovementBody.Spans.Add(new Span
        {
            Text = "Sometimes it's important, though, to know how long it takes to get from one spot to another, whether the answer is in days, hours, or minutes. The rules for determining travel time depend on two factors: the speed and travel pace of the creatures moving and the terrain they're moving over.\n"
        });
        #endregion

        #region Speed
        SpeedHeader.Spans.Add(new Span
        {
            Text = "Speed"
        });
        SpeedBody.Spans.Add(new Span
        {
            Text = "Every character and monster has a speed, which is the distance in feet that the character or monster can walk in 1 round. This number assumes short bursts of energetic movement in the midst of a life-threatening situation. The following rules determine how far a character or monster can move in a minute, an hour, or a day.\n"
        });
        #endregion

        #region Travel Pace
        TravelPaceHeader.Spans.Add(new Span
        {
            Text = "Travel Pace"
        });
        TravelPaceBody.Spans.Add(new Span
        {
            Text = "While traveling, a group of adventurers can move at a normal, fast, or slow pace, as shown on the Travel Pace table. The table states how far the party can move in a period of time and whether the pace has any effect. A fast pace makes characters less perceptive, while a slow pace makes it possible to sneak around and to search an area more carefully.\n"
        });

        #region Forced March
        ForcedMarchBoldHeader.Spans.Add(new Span
        {
            Text = "Forced March"
        });
        ForcedMarchBoldBody.Spans.Add(new Span
        {
            Text = "The Travel Pace table assumes that characters travel for 8 hours in day.They can push on beyond that limit, at the risk of exhaustion.\n"
        });
        ForcedMarchBody.Spans.Add(new Span
        {
            Text = "For each additional hour of travel beyond 8 hours, the characters cover the distance shown in the Hour column for their pace, and each character must make a Constitution saving throw at the end of the hour. The DC is 10 + 1 for each hour past 8 hours. On a failed saving throw, a character suffers one level of exhaustion.\n"
        });
        #endregion

        #region Mounts and Vehicles
        MountsandVehiclesBoldHeader.Spans.Add(new Span
        {
            Text = "Mounts and Vehicles"
        });
        MountsandVehiclesBoldBody.Spans.Add(new Span
        {
            Text = "For short spans of time (up to an hour), many animals move much faster than humanoids. A mounted character can ride at a gallop for about an hour, covering twice the usual distance for a fast pace. If fresh mounts are available every 8 to 10 miles, characters can cover larger distances at this pace, but this is very rare except in densely populated areas.\n"
        });
        MountsandVehiclesBody.Spans.Add(new Span
        {
            Text = "Characters in wagons, carriages, or other land vehicles choose a pace as normal. Characters in a waterborne vessel are limited to the speed of the vessel, and they don't suffer penalties for a fast pace or gain benefits from a slow pace. Depending on the vessel and the size of the crew, ships might be able to travel for up to 24 hours per day.\n\n"
        });
        MountsandVehiclesItalicHeader.Spans.Add(new Span
        {
            Text = "Certain special mounts, such as a pegasus or griffon, or special vehicles, such as a"
        });
        MountsandVehiclesItalic.Spans.Add(new Span
        {
            Text = "carpet of flying"
        });
        MountsandVehiclesItalicBody.Spans.Add(new Span
        {
            Text = " allow you to travel more swiftly.\n"
        });
        #endregion

        #endregion
    }
}