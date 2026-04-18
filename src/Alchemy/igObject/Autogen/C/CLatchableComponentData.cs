namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 8)]
    public class CLatchableComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public CBoltPointList? _latchPoints;
    }
}
