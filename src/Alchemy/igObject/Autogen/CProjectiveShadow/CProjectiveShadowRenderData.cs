namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 48, align: 8)]
    public class CProjectiveShadowRenderData : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public float _range = 1000.0f;
        [FieldAttr(nst: 20, ctr: 16)] public float _edgeFadeAmount = 0.1f;
        [FieldAttr(nst: 24, ctr: 20)] public float _heightOffset = 1000.0f;
        [FieldAttr(nst: 28, ctr: 24)] public float _farPlane = 2000.0f;
        [FieldAttr(nst: 32, ctr: 28)] public float _fade = 1.0f;
        [FieldAttr(nst: 36, ctr: 32)] public igVec3fMetaField _upVector = new();
        [FieldAttr(nst: 48, ctr: 44)] public bool _enable = true;
        [FieldAttr(nst: 49, ctr: 45)] public bool _forceVerticalShadows;
    }
}
