using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 72, ctr: 72)]
    public class hkbFootIkDriverInfo : hkReferencedObject
    {
        public override uint Hash => 0x4bc775e1;

        [FieldAttr(nst: 16, ctr: 16)] public hkMemory<hkbFootIkDriverInfoLeg> _legs;
        [FieldAttr(nst: 32, ctr: 32)] public float _raycastDistanceUp;
        [FieldAttr(nst: 36, ctr: 36)] public float _raycastDistanceDown;
        [FieldAttr(nst: 40, ctr: 40)] public float _originalGroundHeightMS;
        [FieldAttr(nst: 44, ctr: 44)] public float _verticalOffset;
        [FieldAttr(nst: 48, ctr: 48)] public uint _collisionFilterInfo;
        [FieldAttr(nst: 52, ctr: 52)] public float _forwardAlignFraction;
        [FieldAttr(nst: 56, ctr: 56)] public float _sidewaysAlignFraction;
        [FieldAttr(nst: 60, ctr: 60)] public float _sidewaysSampleWidth;
        [FieldAttr(nst: 64, ctr: 64)] public bool _lockFeetWhenPlanted;
        [FieldAttr(nst: 65, ctr: 65)] public bool _useCharacterUpVector;
        [FieldAttr(nst: 66, ctr: 66)] public bool _isQuadrupedNarrow;
        [FieldAttr(nst: 67, ctr: 67)] public bool _keepSourceFootEndAboveGround;
    }
}