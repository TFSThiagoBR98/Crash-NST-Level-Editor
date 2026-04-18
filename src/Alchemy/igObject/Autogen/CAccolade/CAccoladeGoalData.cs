namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 16, align: 8)]
    public class CAccoladeGoalData : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public uint _numberOfCompletions = 1;
        [FieldAttr(nst: 24)] public string? _steamStatId = "";
    }
}
