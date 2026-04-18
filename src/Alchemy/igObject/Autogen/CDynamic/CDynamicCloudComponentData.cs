namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class CDynamicCloudComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public igVec2fMetaField _playerFadeRadii = new();
        [FieldAttr(ctr: 24)] public bool _dissipateOnEnter;
        [FieldAttr(ctr: 28)] public float _dissipateDuration;
        [FieldAttr(ctr: 32)] public float _dissipateEaseInDuration;
        [FieldAttr(ctr: 36)] public float _dissipateEaseOutDuration;
        [FieldAttr(ctr: 40)] public bool _isMultiFade;
        [FieldAttr(ctr: 41)] public bool _useFarPlayerOffset;
        [FieldAttr(ctr: 42)] public bool _wholeFade;
    }
}
