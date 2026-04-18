namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 8)]
    public class CGuiBehaviorVoiceChatHud : igGuiBehavior
    {
        [FieldAttr(nst: 16)] public int _talkerIndex;
        [FieldAttr(nst: 24, refCount: false)] public igGuiPlaceable? _speakerIconPlaceable;
        [FieldAttr(nst: 32, refCount: false)] public igGuiPlaceable? _gamertagPlaceable;
        [FieldAttr(nst: 40)] public float _opacity;
        [FieldAttr(nst: 44)] public float _targetOpacity;
    }
}
