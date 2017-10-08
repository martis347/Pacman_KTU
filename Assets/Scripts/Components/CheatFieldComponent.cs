using Assets.Scripts.Patterns.Adapter;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Assets.Scripts.Components
{
    public class CheatFieldComponent: MonoBehaviour
    {
        [Inject]
        private ScoreboardAdapter scoreboardAdapter;
        private InputField inputField;

        public void Start()
        {
            inputField = gameObject.GetComponent<InputField>();
        }

        public void FixedUpdate()
        {
            if (Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                if (inputField.text == "code1")
                {
                    scoreboardAdapter.AddFruitCollected();
                }
                else if (inputField.text == "code2")
                {
                    scoreboardAdapter.AddTenDotsCollected();
                } 
                else if (inputField.text == "code3")
                {
                    scoreboardAdapter.FakeADeath();
                }

                inputField.text = "";
                gameObject.SetActive(false);
            }
        }
    }
}