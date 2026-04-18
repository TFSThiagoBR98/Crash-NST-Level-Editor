namespace Alchemy
{
    [ObjectAttr(nst: 112, ctr: 112, align: 16)]
    public class igCascadeShadowRenderData : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public bool _scaleZBias;
        [FieldAttr(nst: 32, ctr: 16)] public igVec4fMetaField _zBias = new();
        [FieldAttr(nst: 48, ctr: 32)] public float _blendDistance = 12.0f;
        [FieldAttr(nst: 52)] public bool _cullingEnabled;
        [FieldAttr(nst: 56, ctr: 36)] public EIG_GFX_CULL_FACE_MODE _cullingMode;
        [FieldAttr(nst: 60, ctr: 40)] public float _lastSplit = 1.0f;
        [FieldAttr(nst: 64, ctr: 44)] public float _fadeStart = 1.0f;
        [FieldAttr(nst: 68, ctr: 48)] public float _splitDistribution = 0.5f;
        [FieldAttr(nst: 72, ctr: 52)] public float _scaleQuantizer = 64.0f;
        [FieldAttr(nst: 76, ctr: 56)] public float _pancakeThickness = 32.0f;
        [FieldAttr(nst: 80, ctr: 64)] public igVec4fMetaField _smallObjectThreshold = new();
        [FieldAttr(nst: 96, ctr: 80)] public igVec3fMetaField _upVector = new();
        [FieldAttr(ctr: 92)] public float _shadowMapScale;
        [FieldAttr(ctr: 96)] public int _maxCascadesCount;
        [FieldAttr(nst: 108, ctr: 100)] public bool _enable = true;
        [FieldAttr(nst: 109, ctr: 101)] public bool _drawFrustums;
        [FieldAttr(nst: 110, ctr: 102)] public bool _drawRectangles;
    }
}
