using Alchemy;
using System.Numerics;

namespace Havok
{
    [ObjectAttr(nst: 128, ctr: 128)]
    public class hkbMoveCharacterModifier : hkbModifier
    {
        public override uint Hash => 0x8a40ba00;

        [FieldAttr(nst: 96, ctr: 96)] public Vector4 _offsetPerSecondMS;
        [FieldAttr(ctr: 112)] public bool _useStartOfFrameRotation;
        [FieldAttr(nst: 112, ctr: 116)] public float _timeSinceLastModify;
    }
}