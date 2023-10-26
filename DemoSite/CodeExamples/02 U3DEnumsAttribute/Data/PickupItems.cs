using System.ComponentModel;

namespace eWolf.CodeExamples.EnumnAttributes
{
    public enum PickupItems
    {
        None,

        [Title("Power Board")]
        [Description("Board that can connect power in to or out of the system.")]
        PowerBoard,

        [Title("Grid Board")]
        [Description("Board that allow other boards to be connected")]
        GridBoard,

        [Title("Electric Battery %0")]
        [Description("An electric battery is a source of electric power consisting of one or more electrochemical cells with external connections for powering electrical devices.")]
        ElectricBattery_00,

        [Title("Electric Battery %25")]
        [Description("An electric battery is a source of electric power consisting of one or more electrochemical cells with external connections for powering electrical devices.")]
        ElectricBattery_25,

        [Title("Electric Battery %50")]
        [Description("An electric battery is a source of electric power consisting of one or more electrochemical cells with external connections for powering electrical devices.")]
        ElectricBattery_50,

        [Title("Electric Battery %75")]
        [Description("An electric battery is a source of electric power consisting of one or more electrochemical cells with external connections for powering electrical devices.")]
        ElectricBattery_75,

        [Title("Electric Battery %100")]
        [Description("An electric battery is a source of electric power consisting of one or more electrochemical cells with external connections for powering electrical devices.")]
        ElectricBattery_100,
    }
}