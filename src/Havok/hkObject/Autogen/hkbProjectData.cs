using Alchemy;
using System.Numerics;

namespace Havok
{
    [ObjectAttr(nst: 48, ctr: 48)]
    public class hkbProjectData : hkReferencedObject
    {
        public override uint Hash => 0x363c1159;

        [FieldAttr(nst: 16, ctr: 16)] public Vector4 _worldUpWS;
        [FieldAttr(nst: 32, ctr: 32)] public hkbProjectStringData? _stringData;
        [FieldAttr(nst: 40, ctr: 40)] public EEventMode _defaultEventMode;
    }
}