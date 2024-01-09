using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MoodMe
{
    public class CrrectEmotionPanel : MonoBehaviour
    {

        public GameObject SuccessPanel;
        public float SadMax = 0.2f;
        private float sadvalue = 0; 
        // Start is called before the first frame update
        void Start()
        {
            sadvalue = EmotionsManager.Emotions.sad;
        }

        // Update is called once per frame
        void Update()
        {
            sadvalue = EmotionsManager.Emotions.sad;

            if(sadvalue >= SadMax){
                SuccessPanel.SetActive(true);
            }
        }
    }
}

