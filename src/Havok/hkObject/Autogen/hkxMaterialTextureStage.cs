using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 16, ctr: 16)]
    public class hkxMaterialTextureStage : hkObject
    {
        public override uint Hash => 0xdbda7fbb;

        [FieldAttr(nst: 0, ctr: 0)] public hkReferencedObject? _texture;
        [FieldAttr(nst: 8, ctr: 8)] public ETextureType _usageHint;
        [FieldAttr(nst: 12, ctr: 12)] public int _tcoordChannel;
    }
}