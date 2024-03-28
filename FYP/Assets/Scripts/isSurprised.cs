using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MoodMe
{
    public class isSurprised : MonoBehaviour
    {

        public GameObject SuccessPanel;
        public float SurprisedMax = 0.2f;
        private float surpisedValue = 0;
        // Start is called before the first frame update
        void Start()
        {
            surpisedValue = EmotionsManager.Emotions.scared;
        }

        // Update is called once per frame
        void Update()
        {
            surpisedValue = EmotionsManager.Emotions.surprised;

            if (surpisedValue >= SurprisedMax)
            {
                SuccessPanel.SetActive(true);
            }
        }
    }
}

