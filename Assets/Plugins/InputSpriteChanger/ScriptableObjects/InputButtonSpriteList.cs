using System;
using UnityEngine;

namespace ChangeInputIcon
{

    [CreateAssetMenu(fileName = "InputSpriteList_", menuName = "ScriptableObject/InputSpriteList", order = 1)]
    public class InputButtonSpriteList : ScriptableObject
    {
        public InputButtonSprite[] inputButtonSprites;
    }

    [Serializable]
    public class InputButtonSprite
    {
        public TypeInput typeInput;
        public Sprite sprite;
    }

}