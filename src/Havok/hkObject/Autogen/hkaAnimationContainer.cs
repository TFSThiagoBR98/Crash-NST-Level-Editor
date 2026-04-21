using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 96, ctr: 96)]
    public class hkaAnimationContainer : hkReferencedObject
    {
        public override uint Hash => 0x26859f4c;

        [FieldAttr(nst: 16, ctr: 16)] public hkMemory<hkaSkeleton> _skeletons;
        [FieldAttr(nst: 32, ctr: 32)] public hkMemory<hkaAnimation> _animations;
        [FieldAttr(nst: 48, ctr: 48)] public hkMemory<hkaAnimationBinding> _bindings;
        [FieldAttr(nst: 64, ctr: 64)] public hkMemory<hkaBoneAttachment> _attachments;
        [FieldAttr(nst: 80, ctr: 80)] public hkMemory<hkaMeshBinding> _skins;
    }
}