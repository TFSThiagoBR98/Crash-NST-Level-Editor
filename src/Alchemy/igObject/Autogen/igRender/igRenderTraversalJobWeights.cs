namespace Alchemy
{
    [ObjectAttr(nst: 24, ctr: 24, align: 4)]
    public class igRenderTraversalJobWeights : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public int _minWeight = 100;
        [FieldAttr(nst: 20, ctr: 16)] public int _maxWeight = 200;
    }
}
