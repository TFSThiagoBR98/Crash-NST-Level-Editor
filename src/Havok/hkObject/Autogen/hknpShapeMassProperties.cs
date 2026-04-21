using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 48, ctr: 48)]
    public class hknpShapeMassProperties : hkReferencedObject
    {
        public override uint Hash => 0xe9191728;

        [FieldAttr(nst: 16, ctr: 16)] public i16 _centerOfMass_0;
        [FieldAttr(nst: 18, ctr: 18)] public i16 _centerOfMass_1;
        [FieldAttr(nst: 20, ctr: 20)] public i16 _centerOfMass_2;
        [FieldAttr(nst: 22, ctr: 22)] public i16 _centerOfMass_3;
        [FieldAttr(nst: 24, ctr: 24)] public i16 _inertia_0;
        [FieldAttr(nst: 26, ctr: 26)] public i16 _inertia_1;
        [FieldAttr(nst: 28, ctr: 28)] public i16 _inertia_2;
        [FieldAttr(nst: 30, ctr: 30)] public i16 _inertia_3;
        [FieldAttr(nst: 32, ctr: 32)] public u16 _majorAxisSpace_0;
        [FieldAttr(nst: 34, ctr: 34)] public u16 _majorAxisSpace_1;
        [FieldAttr(nst: 36, ctr: 36)] public u16 _majorAxisSpace_2;
        [FieldAttr(nst: 38, ctr: 38)] public u16 _majorAxisSpace_3;
        [FieldAttr(nst: 40, ctr: 40)] public float _mass;
        [FieldAttr(nst: 44, ctr: 44)] public float _volume;
    }
}