using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MoodMe
{
    public class isScared : MonoBehaviour
    {

        public GameObject SuccessPanel;
        public float ScaredMax = 0.2f;
        private float scaredValue = 0;
        // Start is called before the first frame update
        void Start()
        {
            scaredValue = EmotionsManager.Emotions.scared;
        }

        // Update is called once per frame
        void Update()
        {
            scaredValue = EmotionsManager.Emotions.sad;

            if (scaredValue >= ScaredMax)
            {
                SuccessPanel.SetActive(true);
            }
        }
    }
}

