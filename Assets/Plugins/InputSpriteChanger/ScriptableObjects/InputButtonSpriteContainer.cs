using UnityEngine;

namespace ChangeInputIcon
{

    [CreateAssetMenu(fileName = "InputSpriteContainer", menuName = "ScriptableObject/InputSpriteContainer", order = 1)]
    public class InputButtonSpriteContainer : ScriptableObject
    {
        public InputButtonSpriteList
            pc,
            xone,
            ps4,
            nintendoSwitch
            ;
    }

}