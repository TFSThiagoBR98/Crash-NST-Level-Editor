namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 8)]
    public class igTimeTransform2 : igObject
    {
        public enum ERepeatMode
        {
            kRepeatNone = 0,
            kRepeatClamp = 1,
            kRepeatLoop = 2,
        }

        [FieldAttr(nst: 16, ctr: 12)] public float _scale = 1.0f;
        [FieldAttr(nst: 20, ctr: 16)] public float _bias;
        [FieldAttr(nst: 24, ctr: 20)] public igTimeMetaField _cutoff = new();
        [FieldAttr(nst: 28, ctr: 24)] public ERepeatMode _repeatMode;
        [FieldAttr(nst: 32, ctr: 28)] public igTimeMetaField _initialTime = new();
    }
}
