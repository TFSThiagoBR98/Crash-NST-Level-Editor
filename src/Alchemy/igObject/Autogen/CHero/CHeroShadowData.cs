namespace Alchemy
{
    [ObjectAttr(nst: 24, ctr: 24, align: 4)]
    public class CHeroShadowData : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public float _blendDistance = 96.0f;
        [FieldAttr(nst: 20, ctr: 16)] public float _volumeSlack = 6.0f;
        [FieldAttr(ctr: 20)] public bool _enableHeroShadows;
        [FieldAttr(ctr: 21)] public bool _useModelBounds;
    }
}
