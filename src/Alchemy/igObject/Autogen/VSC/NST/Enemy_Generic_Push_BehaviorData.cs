namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class Enemy_Generic_Push_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _PushOnCollide;
        [FieldAttr(nst: 41)] public bool _PushOnSpin;
        [FieldAttr(nst: 44)] public float _PushOffset;
        [FieldAttr(nst: 48)] public float _LaunchHeight;
        [FieldAttr(nst: 52)] public float _LaunchSpeed;
        [FieldAttr(nst: 56)] public string? _SpinDeath = null;
    }
}
