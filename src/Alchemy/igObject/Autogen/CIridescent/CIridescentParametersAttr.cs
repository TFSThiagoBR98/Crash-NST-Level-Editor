namespace Alchemy
{
    [ObjectAttr(nst: 192, align: 16)]
    public class CIridescentParametersAttr : igVisualAttribute
    {
        [FieldAttr(nst: 32)] public igVec4fMetaField _oneDivKeyRange = new();
        [FieldAttr(nst: 48)] public igVec4fMetaField _startDivKeyRange = new();
        [FieldAttr(nst: 64)] public float _metalness = 1.0f;
        [FieldAttr(nst: 68)] public float _gloss = 0.8f;
        [FieldAttr(nst: 72)] public float _emissive;
        [FieldAttr(nst: 76)] public float _distance;
        [FieldAttr(nst: 80)] public igVec4fMetaField[] _keyFrameColors = new igVec4fMetaField[5];
        [FieldAttr(nst: 160)] public float _falloffScale = 1.0f;
        [FieldAttr(nst: 164)] public float _falloffBias;
        [FieldAttr(nst: 168)] public float _falloff;
        [FieldAttr(nst: 172)] public float _overallContribution;
        [FieldAttr(nst: 176)] public bool _useNormalMap = true;
        [FieldAttr(nst: 177)] public bool _useHalfAngle = true;
        [FieldAttr(nst: 178)] public bool _useFixedHalfAngle = true;
    }
}
