using Alchemy;
using System.Numerics;

namespace Havok
{
    [ObjectAttr(nst: 80, ctr: 80)]
    public class hkbFootIkDriverInfoLeg : hkObject
    {
        public override uint Hash => 0xfcb4eea5;

        [FieldAttr(nst: 0, ctr: 0)] public Vector4 _kneeAxisLS;
        [FieldAttr(nst: 16, ctr: 16)] public Vector4 _footEndLS;
        [FieldAttr(nst: 32, ctr: 32)] public float _footPlantedAnkleHeightMS;
        [FieldAttr(nst: 36, ctr: 36)] public float _footRaisedAnkleHeightMS;
        [FieldAttr(nst: 40, ctr: 40)] public float _maxAnkleHeightMS;
        [FieldAttr(nst: 44, ctr: 44)] public float _minAnkleHeightMS;
        [FieldAttr(nst: 48, ctr: 48)] public float _maxKneeAngleDegrees;
        [FieldAttr(nst: 52, ctr: 52)] public float _minKneeAngleDegrees;
        [FieldAttr(nst: 56, ctr: 56)] public i16 _hipIndex;
        [FieldAttr(nst: 58, ctr: 58)] public i16 _hipSiblingIndex;
        [FieldAttr(nst: 60, ctr: 60)] public i16 _kneeIndex;
        [FieldAttr(nst: 62, ctr: 62)] public i16 _kneeSiblingIndex;
        [FieldAttr(nst: 64, ctr: 64)] public i16 _ankleIndex;
        [FieldAttr(nst: 66, ctr: 66)] public bool _ForceFootGround;
    }
}