namespace Alchemy
{
    [ObjectAttr(nst: 1696, ctr: 1696, align: 16)]
    public class CLightRigConstantBundle : igShaderConstantBundle
    {
        [FieldAttr(nst: 32, ctr: 32)] public igVec4fMetaField[] _pointLightPositions = new igVec4fMetaField[16];
        [FieldAttr(nst: 288, ctr: 288)] public igVec4fMetaField[] _pointLightColors = new igVec4fMetaField[16];
        [FieldAttr(nst: 544, ctr: 544)] public igMatrix44fMetaField[] _boxLightMatrices = new igMatrix44fMetaField[8];
        [FieldAttr(nst: 1056, ctr: 1056)] public igVec4fMetaField[] _boxLightDirections = new igVec4fMetaField[8];
        [FieldAttr(nst: 1184, ctr: 1184)] public igVec4fMetaField[] _boxLightColors = new igVec4fMetaField[8];
        [FieldAttr(nst: 1312, ctr: 1312)] public igVec4fMetaField[] _boxLightParameters = new igVec4fMetaField[24];
    }
}
