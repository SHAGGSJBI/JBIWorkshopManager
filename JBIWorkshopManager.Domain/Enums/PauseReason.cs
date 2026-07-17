namespace JBIWorkshopManager.Domain.Enums;

public enum PauseReason
{
    None,

    WaitingOnSteel,

    WaitingOnPlate,

    WaitingOnMachinedParts,

    MissingParts,

    HigherPriorityWork,

    MachineBreakdown,

    EmployeeAway
}