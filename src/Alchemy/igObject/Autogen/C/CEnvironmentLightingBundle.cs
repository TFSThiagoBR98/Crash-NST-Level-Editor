namespace Alchemy
{
    [ObjectAttr(nst: 288, ctr: 288, align: 16)]
    public class CEnvironmentLightingBundle : igShaderConstantBundle
    {
        [FieldAttr(nst: 32, ctr: 32)] public igVec4fMetaField _iridescentFixedOffsetDirection = new();
        [FieldAttr(nst: 48, ctr: 48)] public igVec4fMetaField _averageEnvironmentColor = new();
        [FieldAttr(nst: 64, ctr: 64)] public igVec4fMetaField _averageEnvironmentColorLinear = new();
        [FieldAttr(nst: 80, ctr: 80)] public igVec4fMetaField _sunColor = new();
        [FieldAttr(nst: 96, ctr: 96)] public igVec4fMetaField _combinedEnvironmentColor = new();
        [FieldAttr(nst: 112, ctr: 112)] public igVec4fMetaField _grassInteractionOne = new();
        [FieldAttr(nst: 128, ctr: 128)] public igVec4fMetaField _grassInteractionTwo = new();
        [FieldAttr(nst: 144, ctr: 144)] public igVec4fMetaField _playerFadeOne = new();
        [FieldAttr(nst: 160, ctr: 160)] public igVec4fMetaField _playerFadeOneScaled = new();
        [FieldAttr(nst: 176, ctr: 176)] public igVec4fMetaField _playerFadeTwo = new();
        [FieldAttr(nst: 192, ctr: 192)] public igVec4fMetaField _playerFadeTwoScaled = new();
        [FieldAttr(nst: 208, ctr: 208)] public igVec4fMetaField _playerFadeOneFar = new();
        [FieldAttr(nst: 224, ctr: 224)] public igVec4fMetaField _playerFadeOneScaledFar = new();
        [FieldAttr(nst: 240, ctr: 240)] public igVec4fMetaField _playerFadeTwoFar = new();
        [FieldAttr(nst: 256, ctr: 256)] public igVec4fMetaField _playerFadeTwoScaledFar = new();
        [FieldAttr(nst: 272, ctr: 272)] public igVec4fMetaField _waterEnvironmentLighting = new();
    }
}
