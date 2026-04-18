namespace Alchemy
{
    [ObjectAttr(nst: 336, ctr: 336, align: 16)]
    public class CWindShaderConstantBundle : igShaderConstantBundle
    {
        [FieldAttr(nst: 32, ctr: 32)] public igVec4fMetaField _windVector = new();
        [FieldAttr(nst: 48, ctr: 48)] public igVec4fMetaField _windGlobal = new();
        [FieldAttr(nst: 64, ctr: 64)] public igVec4fMetaField _windBranch = new();
        [FieldAttr(nst: 80, ctr: 80)] public igVec4fMetaField _windBranchTwitch = new();
        [FieldAttr(nst: 96, ctr: 96)] public igVec4fMetaField _windBranchWhip = new();
        [FieldAttr(nst: 112, ctr: 112)] public igVec4fMetaField _windBranchAnchor = new();
        [FieldAttr(nst: 128, ctr: 128)] public igVec4fMetaField _windBranchAdherences = new();
        [FieldAttr(nst: 144, ctr: 144)] public igVec4fMetaField _windTurbulences = new();
        [FieldAttr(nst: 160, ctr: 160)] public igVec4fMetaField _windRollingBranches = new();
        [FieldAttr(nst: 176, ctr: 176)] public igVec4fMetaField _windLeaf1Ripple = new();
        [FieldAttr(nst: 192, ctr: 192)] public igVec4fMetaField _windLeaf1Tumble = new();
        [FieldAttr(nst: 208, ctr: 208)] public igVec4fMetaField _windLeaf1Twitch = new();
        [FieldAttr(nst: 224, ctr: 224)] public igVec4fMetaField _windLeaf1Roll = new();
        [FieldAttr(nst: 240, ctr: 240)] public igVec4fMetaField _windLeaf2Ripple = new();
        [FieldAttr(nst: 256, ctr: 256)] public igVec4fMetaField _windLeaf2Tumble = new();
        [FieldAttr(nst: 272, ctr: 272)] public igVec4fMetaField _windLeaf2Twitch = new();
        [FieldAttr(nst: 288, ctr: 288)] public igVec4fMetaField _windLeaf2Roll = new();
        [FieldAttr(nst: 304, ctr: 304)] public igVec4fMetaField _windFrondRipple = new();
        [FieldAttr(nst: 320, ctr: 320)] public igVec4fMetaField _windAnimation = new();
    }
}
