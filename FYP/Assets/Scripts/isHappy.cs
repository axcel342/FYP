using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MoodMe
{
    public class isHappy : MonoBehaviour
    {

        public GameObject SuccessPanel;
        public float HappyMax = 0.2f;
        private float happyValue = 0;
        // Start is called before the first frame update
        void Start()
        {
            happyValue = EmotionsManager.Emotions.scared;
        }

        // Update is called once per frame
        void Update()
        {
            happyValue = EmotionsManager.Emotions.surprised;

            if (happyValue >= HappyMax)
            {
                SuccessPanel.SetActive(true);
            }
        }
    }
}

