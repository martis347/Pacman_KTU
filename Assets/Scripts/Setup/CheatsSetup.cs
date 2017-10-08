using Assets.Scripts.Patterns.Adapter;
using Assets.Scripts.Patterns.Singleton;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Setup
{
    public class CheatsSetup : MonoBehaviour
    {
        private GameObject cheatField;

        public void Start()
        {
            cheatField = GameObject.Find("CheatField");
            cheatField.GetComponent<InputField>().Select();
            cheatField.SetActive(false);
        }

        public void FixedUpdate()
        {
            if (Input.GetKeyDown(KeyCode.BackQuote))
            {
                cheatField.SetActive(!cheatField.activeSelf);
                if (cheatField.activeSelf)
                {
                    cheatField.GetComponent<InputField>().Select();
                }
            }

        }
    }
}