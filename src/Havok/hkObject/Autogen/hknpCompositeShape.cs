using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 96, ctr: 96)]
    public class hknpCompositeShape : hknpShape
    {
        public override uint Hash => 0x12bb3bef;

        [FieldAttr(nst: 48, ctr: 40)] public hknpSparseCompactMapunsignedshort? _edgeWeldingMap;
        [FieldAttr(nst: 88, ctr: 80)] public uint _shapeTagCodecInfo;
    }
}