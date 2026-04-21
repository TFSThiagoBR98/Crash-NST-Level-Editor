using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 40, ctr: 40)]
    public class hknpPhysicsSceneData : hkReferencedObject
    {
        public override uint Hash => 0x701ce72c;

        [FieldAttr(nst: 16, ctr: 16)] public hkMemory<hknpPhysicsSystemData> _systemDatas;
        [FieldAttr(nst: 32, ctr: 32)] public hknpRefWorldCinfo? _worldCinfo;
    }
}