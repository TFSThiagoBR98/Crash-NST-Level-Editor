namespace Alchemy
{
    [ObjectAttr(nst: 192, ctr: 192, align: 16)]
    public class CIridescentParametersBundle : igShaderConstantBundle
    {
        [FieldAttr(nst: 32, ctr: 32)] public igVec4fMetaField _oneDivKeyRange = new();
        [FieldAttr(nst: 48, ctr: 48)] public igVec4fMetaField _startDivKeyRange = new();
        [FieldAttr(nst: 64, ctr: 64)] public float _metalness = 1.0f;
        [FieldAttr(nst: 68, ctr: 68)] public float _gloss = 0.8f;
        [FieldAttr(nst: 72, ctr: 72)] public float _emissive;
        [FieldAttr(nst: 76, ctr: 76)] public float _distance;
        [FieldAttr(nst: 80, ctr: 80)] public igVec4fMetaField[] _keyFrameColors = new igVec4fMetaField[5];
        [FieldAttr(nst: 160, ctr: 160)] public float _falloffScale = 1.0f;
        [FieldAttr(nst: 164, ctr: 164)] public float _falloffBias;
        [FieldAttr(nst: 168, ctr: 168)] public float _falloff;
        [FieldAttr(nst: 172, ctr: 172)] public float _overallContribution;
        [FieldAttr(nst: 176, ctr: 176)] public bool _useNormalMap = true;
        [FieldAttr(nst: 177, ctr: 177)] public bool _useHalfAngle = true;
        [FieldAttr(nst: 178, ctr: 178)] public bool _useFixedHalfAngle = true;
    }
}
