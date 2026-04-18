namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 8)]
    public class CVisemePlayerComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24, ctr: 16)] public bool _startActive = true;
    }
}
