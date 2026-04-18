namespace Alchemy
{
    [ObjectAttr(nst: 240, ctr: 224, align: 8)]
    public class CGuiBehaviorBaseNumberOption : CGuiBehavior
    {
        public enum EIncrementDirection
        {
            eID_Horizontal = 0,
            eID_Vertical = 1,
        }

        [FieldAttr(nst: 144, ctr: 144, refCount: false)] public igGuiAnimationTag? _animChangeValue;
        [FieldAttr(nst: 152, ctr: 152, refCount: false)] public igGuiAnimationTag? _animFailChangeValue;
        [FieldAttr(nst: 160, ctr: 160, refCount: false)] public igGuiPlaceable? _textPlaceable;
        [FieldAttr(nst: 168, ctr: 168)] public int _width = 2;
        [FieldAttr(nst: 172, ctr: 172)] public int _decimalPlaces;
        [FieldAttr(nst: 176, ctr: 176)] public float _interval = 1.0f;
        [FieldAttr(nst: 180, ctr: 180)] public float _minimumValue;
        [FieldAttr(nst: 184, ctr: 184)] public float _maximumValue = 10.0f;
        [FieldAttr(nst: 192, refCount: false)] public igGuiPlaceable? _decrementPlaceable;
        [FieldAttr(nst: 200, refCount: false)] public igGuiPlaceable? _incrementPlaceable;
        [FieldAttr(nst: 208, ctr: 188)] public EIncrementDirection _incrementDirection;
        [FieldAttr(nst: 212, ctr: 192)] public bool _wrapValues;
        [FieldAttr(nst: 216, ctr: 196)] public EGuiMenuSound _onChangeValueSound = EGuiMenuSound.eGMS_Confirm;
        [FieldAttr(nst: 220, ctr: 200)] public EGuiMenuSound _onChangeValueFailSound;
        [FieldAttr(nst: 224, ctr: 208)] public igGuiAnimationCategory? _animationCategory;
        [FieldAttr(nst: 232, ctr: 216)] public float _currentValue;
        [FieldAttr(nst: 236, ctr: 220)] public float _lastSavedValue;
    }
}
