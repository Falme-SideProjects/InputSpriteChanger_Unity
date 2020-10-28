using UnityEngine;
using UnityEngine.UI;

namespace ChangeInputIcon
{

    public class ChangeInputIcon : MonoBehaviour
    {
        [SerializeField]
        private TypeInput typeInput;
        [SerializeField]
        private InputButtonSpriteContainer inputButtonSpriteContainer;
        [SerializeField]
        private bool overridePCInput = false;
        [SerializeField]
        private Sprite pcOverrideSpriteButton;

        private Image image;

        private void Awake() {
            image = GetComponent<Image>();
        }

        private void Start()
        {
            UpdateInputVisual();
        }

        private void UpdateInputVisual()
        {
            UpdateInputVisual(this.typeInput);
        }

        private void UpdateInputVisual(TypeInput inputType)
        {
            if(image == null)
                Debug.LogError("Image Was Not Defined");

            InputButtonSpriteList _target = null;

            #if UNITY_XBOXONE
                _target = inputButtonSpriteContainer.xone;
            #elif UNITY_PS4 
                _target = inputButtonSpriteContainer.ps4;
            #elif UNITY_STANDALONE 
                _target = inputButtonSpriteContainer.pc;

                if(overridePCInput)
                {
                    image.sprite = pcOverrideSpriteButton;
                    return;
                }
            #else
                _target = inputButtonSpriteContainer.nintendoSwitch;
            #endif

            for(int a=0; a<_target.inputButtonSprites.Length; a++)
                if(_target.inputButtonSprites[a].typeInput == inputType)
                {
                    image.sprite = _target.inputButtonSprites[a].sprite;
                    return;
                }
        }
    }

}