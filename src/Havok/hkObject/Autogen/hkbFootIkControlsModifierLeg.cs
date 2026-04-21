using Alchemy;
using System.Numerics;

namespace Havok
{
    [ObjectAttr(nst: 48, ctr: 48)]
    public class hkbFootIkControlsModifierLeg : hkObject
    {
        public override uint Hash => 0xb68b350a;

        [FieldAttr(nst: 0, ctr: 0)] public Vector4 _groundPosition;
        [FieldAttr(nst: 16, ctr: 16)] public hkbEventProperty? _ungroundedEvent;
        [FieldAttr(nst: 32, ctr: 32)] public float _verticalError;
        [FieldAttr(nst: 36, ctr: 36)] public bool _hitSomething;
        [FieldAttr(nst: 37, ctr: 37)] public bool _isPlantedMS;
        [FieldAttr(nst: 38, ctr: 38)] public bool _enabled;
    }
}