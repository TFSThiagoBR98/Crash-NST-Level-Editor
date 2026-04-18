namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 4)]
    public class CFilterByTeam : CFilterMethod
    {
        [FieldAttr(nst: 24, ctr: 16)] public CEntityData.EEntityTeam _team;
    }
}
