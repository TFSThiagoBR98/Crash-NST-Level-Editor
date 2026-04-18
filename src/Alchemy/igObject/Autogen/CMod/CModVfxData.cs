namespace Alchemy
{
    [ObjectAttr(nst: 56, align: 8)]
    public class CModVfxData : igObject
    {
        public enum EVehicleModVfxType
        {
            eVMVT_Tread = 0,
            eVMVT_Ambient = 1,
        }

        [FieldAttr(nst: 16)] public CVfxEffectDotNetHandle? _effect;
        [FieldAttr(nst: 24)] public CBoltPoint? _bolt01;
        [FieldAttr(nst: 32)] public CBoltPoint? _bolt02;
        [FieldAttr(nst: 40)] public EVehicleModVfxType _modType;
        [FieldAttr(nst: 44)] public bool _playsWhileJumping;
        [FieldAttr(nst: 45)] public bool _hardKill;
        [FieldAttr(nst: 48)] public float _secondsToGoToFullThrottle = 0.5f;
        [FieldAttr(nst: 52)] public float _secondsDownFromFullThrottle = 0.25f;
    }
}
