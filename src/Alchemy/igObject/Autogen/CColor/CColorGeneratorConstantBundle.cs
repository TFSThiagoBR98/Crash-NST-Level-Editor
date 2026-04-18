namespace Alchemy
{
    [ObjectAttr(nst: 992, ctr: 992, align: 16)]
    public class CColorGeneratorConstantBundle : igShaderConstantBundle
    {
        [FieldAttr(nst: 32, ctr: 32)] public igVec4fMetaField[] _boxInfluence = new igVec4fMetaField[3];
        [FieldAttr(nst: 80, ctr: 80)] public igVec4fMetaField _externalInfluence = new();
        [FieldAttr(nst: 96, ctr: 96)] public igVec4fMetaField[] _scale = new igVec4fMetaField[8];
        [FieldAttr(nst: 224, ctr: 224)] public igVec4fMetaField[] _bias = new igVec4fMetaField[8];
        [FieldAttr(nst: 352, ctr: 352)] public igVec4fMetaField[] _keys = new igVec4fMetaField[40];
    }
}
