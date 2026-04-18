namespace Alchemy
{
    [ObjectAttr(nst: 128, ctr: 128, align: 16)]
    public class igForwardLitRenderPassData : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public float _ambientSpecularScale = 1.0f;
        [FieldAttr(nst: 20, ctr: 16)] public float _ambientDiffuseScale = 1.0f;
        [FieldAttr(nst: 24, ctr: 20)] public bool _hazeState;
        [FieldAttr(nst: 28, ctr: 24)] public float _hazeStartDepth = 0.5f;
        [FieldAttr(nst: 32, ctr: 28)] public float _hazeSaturateDepth = 0.8f;
        [FieldAttr(nst: 36, ctr: 32)] public float _minHaze;
        [FieldAttr(nst: 40, ctr: 36)] public float _maxHaze = 0.8f;
        [FieldAttr(nst: 44, ctr: 40)] public float _hazeDensity = 1.7f;
        [FieldAttr(nst: 48, ctr: 44)] public float _fogStart;
        [FieldAttr(nst: 52, ctr: 48)] public float _fogDensity = 0.001f;
        [FieldAttr(nst: 64, ctr: 64)] public igVec4fMetaField _fogColor = new();
        [FieldAttr(nst: 80, ctr: 80)] public igVec4fMetaField _fogSunColor = new();
        [FieldAttr(nst: 96, ctr: 96)] public float _fogSunInfluence = 1.0f;
        [FieldAttr(nst: 100, ctr: 100)] public float _fogIntensity = 1.0f;
        [FieldAttr(nst: 104, ctr: 104)] public float _cloudCoverScale;
        [FieldAttr(nst: 108, ctr: 108)] public float _cloudCoverTileSize = 1.0f;
        [FieldAttr(nst: 112, ctr: 112)] public float _cloudCoverSpeed = 30.0f;
        [FieldAttr(nst: 116, ctr: 116)] public igVec2fMetaField _cloudCoverDirection = new();
    }
}
