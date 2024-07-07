using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.MAUI.Equipment.Interfaces;

namespace GoDungeon.MAUI.Equipment.ViewModels;

public partial class BetweenAdventuresViewModel : ObservableObject, IBetweenAdventuresViewModel
{
    [ObservableProperty]
    private string pageDescription;

    [ObservableProperty]
    private string betweenAdventuresHeader;

    [ObservableProperty]
    private string betweenAdventuresBody;

    [ObservableProperty]
    private string lifestyleExpensesHeading;

    [ObservableProperty]
    private FormattedString lifestyleExpensesBody = new FormattedString();

    [ObservableProperty]
    private FormattedString downtimeActivitiesHeading = new FormattedString();

    [ObservableProperty]
    private FormattedString downtimeActivitiesBody = new FormattedString();

    [ObservableProperty]
    private FormattedString craftingHeading = new FormattedString();

    [ObservableProperty]
    private FormattedString craftingBody = new FormattedString();

    [ObservableProperty]
    private FormattedString practicingAProfessionHeading = new FormattedString();

    [ObservableProperty]
    private FormattedString practicingAProfessionBody = new FormattedString();

    [ObservableProperty]
    private FormattedString recuperatingHeading = new FormattedString();

    [ObservableProperty]
    private FormattedString recuperatingBody = new FormattedString();

    [ObservableProperty]
    private FormattedString recuperatingHTML = new FormattedString();

    [ObservableProperty]
    private FormattedString researchingHeading = new FormattedString();

    [ObservableProperty]
    private FormattedString researchingBody = new FormattedString();

    [ObservableProperty]
    private FormattedString trainingHeading = new FormattedString();

    [ObservableProperty]
    private FormattedString trainingBody = new FormattedString();

    public BetweenAdventuresViewModel()
    {
        PageDescription = "<p><i>Rules and information governing player time between adventures (downtime).</i><br></p>";
        BetweenAdventuresHeader = "<h1>Between Adventures</h1>";
        BetweenAdventuresBody = "<p>Between trips to dungeons and battles against ancient evils, adventurers need time to rest, recuperate, and prepare for their next adventure. Many adventurers also use this time to perform other tasks, such as crafting arms and armor, performing research, or spending their hard-earned gold.<br><br></p>";
        BetweenAdventuresBody += "<p>In some cases, the passage of time is something that occurs with little fanfare or description. When starting a new adventure, the GM might simply declare that a certain amount of time has passed and allow you to describe in general terms what your character has been doing. At other times, the GM might want to keep track of just how much time is passing as events beyond your perception stay in motion.<br></p>";
        LifestyleExpensesHeading = "<h2>Lifestyle Expenses</h2>";

        LifestyleExpensesBody.Spans.Add(new Span
        {
            Text = "Between adventures, you choose a particular quality of life and pay the cost of maintaining that lifestyle.\n\n"
        });
        LifestyleExpensesBody.Spans.Add(new Span
        {
            Text = "Living a particular lifestyle doesn't have a huge effect on your character, but your lifestyle can affect the way other individuals and groups react to you. For example, when you lead an aristocratic lifestyle, it might be easier for you to influence the nobles of the city than if you live in poverty.\n"
        });
 
        #region Downtime Activities
        DowntimeActivitiesHeading.Spans.Add(new Span
        {
            Text = "Downtime Activities"
        });
        DowntimeActivitiesBody.Spans.Add(new Span
        {
            Text = "Between adventures, the GM might ask you what your character is doing during his or her downtime. Periods of downtime can vary in duration, but each downtime activity requires a certain number of days to complete before you gain any benefit, and at least 8 hours of each day must be spent on the downtime activity for the day to count. The days do not need to be consecutive. If you have more than the minimum amount of days to spend, you can keep doing the same thing for a longer period of time, or switch to a new downtime activity.\n\n"
        });
        DowntimeActivitiesBody.Spans.Add(new Span
        {
            Text = "Downtime activities other than the ones presented below are possible. If you want your character to spend his or her downtime performing an activity not covered here, discuss it with your GM.\n"
        });
        #endregion

        #region Crafting
        CraftingHeading.Spans.Add(new Span
        {
            Text = "Crafting"
        });
        CraftingBody.Spans.Add(new Span
        {
            Text = "You can craft nonmagical objects, including adventuring equipment and works of art. You must be proficient with tools related to the object you are trying to create (typically artisan's tools). You might also need access to special materials or locations necessary to create it. For example, someone proficient with smith's tools needs a forge in order to craft a sword or suit of armor.\n\n"
        });
        CraftingBody.Spans.Add(new Span
        {
            Text = "For every day of downtime you spend crafting, you can craft one or more items with a total market value not exceeding 5 gp, and you must expend raw materials worth half the total market value. If something you want to craft has a market value greater than 5 gp, you make progress every day in 5-gp increments until you reach the market value of the item. For example, a suit of plate armor (market value 1,500 gp) takes 300 days to craft by yourself.\n\n"
        });
        CraftingBody.Spans.Add(new Span
        {
            Text = "Multiple characters can combine their efforts toward the crafting of a single item, provided that the characters all have proficiency with the requisite tools and are working together in the same place. Each character contributes 5 gp worth of effort for every day spent helping to craft the item. For example, three characters with the requisite tool proficiency and the proper facilities can craft a suit of plate armor in 100 days, at a total cost of 750 gp.\n\n"
        });
        CraftingBody.Spans.Add(new Span
        {
            Text = "While crafting, you can maintain a modest lifestyle without having to pay 1 gp per day, or a comfortable lifestyle at half the normal cost.\n"
        });
        #endregion

        #region Practicing a Profession
        PracticingAProfessionHeading.Spans.Add(new Span
        {
            Text = "Practicing a Profession"
        });
        PracticingAProfessionBody.Spans.Add(new Span
        {
            Text = "You can work between adventures, allowing you to maintain a modest lifestyle without having to pay 1 gp per day. This benefit lasts as long you continue to practice your profession.\n\n"
        });
        PracticingAProfessionBody.Spans.Add(new Span
        {
            Text = "If you are a member of an organization that can provide gainful employment, such as a temple or a thieves' guild, you earn enough to support a comfortable lifestyle instead.\n\n"
        });
        PracticingAProfessionBody.Spans.Add(new Span
        {
            Text = "If you have proficiency in the Performance skill and put your performance skill to use during your downtime, you earn enough to support a wealthy lifestyle instead.\n"
        });
        #endregion

        #region Recuperating
        RecuperatingHeading.Spans.Add(new Span
        {
            Text = "Recuperating"
        });
        RecuperatingBody.Spans.Add(new Span
        {
            Text = "You can use downtime between adventures to recover from a debilitating injury, disease, or poison.\n\n"
        });
        RecuperatingBody.Spans.Add(new Span
        {
            Text = "After three days of downtime spent recuperating, you can make a DC 15 Constitution saving throw. On a successful save, you can choose one of the following results:"
        });
        RecuperatingHTML.Spans.Add(new Span
        {
            Text = "<UL>\n"
        });
        RecuperatingHTML.Spans.Add(new Span
        {
            Text = "<LI>End one effect on you that prevents you from regaining hit points.</LI>\n"
        });
        RecuperatingHTML.Spans.Add(new Span
        {
            Text = "<LI>For the next 24 hours, gain advantage on saving throws against one disease or poison currently affecting you.</LI>\n"
        });
        RecuperatingHTML.Spans.Add(new Span
        {
            Text = "</UL>\n"
        });
        #endregion

        #region Researching
        ResearchingHeading.Spans.Add(new Span
        {
            Text = "Researching"
        });
        ResearchingBody.Spans.Add(new Span
        {
            Text = "The time between adventures is a great chance to perform research, gaining insight into mysteries that have unfurled over the course of the campaign. Research can include poring over dusty tomes and crumbling scrolls in a library or buying drinks for the locals to pry rumors and gossip from their lips.\n\n"
        });
        ResearchingBody.Spans.Add(new Span
        {
            Text = "When you begin your research, the GM determines whether the information is available, how many days of downtime it will take to find it, and whether there are any restrictions on your research (such as needing to seek out a specific individual, tome, or location). The GM might also require you to make one or more ability checks, such as an Intelligence (Investigation) check to find clues pointing toward the information you seek, or a Charisma (Persuasion) check to secure someone's aid. Once those conditions are met, you learn the information if it is available.\n\n"
        });
        ResearchingBody.Spans.Add(new Span
        {
            Text = "For each day of research, you must spend 1 gp to cover your expenses. This cost is in addition to your normal lifestyle expenses.\n"
        });
        #endregion

        #region Training
        TrainingHeading.Spans.Add(new Span
        {
            Text = "Training"
        });
        TrainingBody.Spans.Add(new Span
        {
            Text = "You can spend time between adventures learning a new language or training with a set of tools. Your GM might allow additional training options.\n\n"
        });
        TrainingBody.Spans.Add(new Span
        {
            Text = "First, you must find an instructor willing to teach you. The GM determines how long it takes, and whether one or more ability checks are required.\n\n"
        });
        TrainingBody.Spans.Add(new Span
        {
            Text = "The training lasts for 250 days and costs 1 gp per day. After you spend the requisite amount of time and money, you learn the new language or gain proficiency with the new tool.\n"
        });
        #endregion
    }
}