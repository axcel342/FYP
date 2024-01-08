Data Source for the FER Model:
https://github.com/Microsoft/FERPlus
Input: (64 *64)
// Emotion labels
Dictionary<int, string> emotionDict = new Dictionary<int, string>
{
    { 0, "neutral" },
    { 1, "happiness" },
    { 2, "surprise" },
    { 3, "sadness" },
    { 4, "anger" },
    { 5, "disgust" },
    { 6, "fear" }
};

Emotion Fer Plus Model:
https://github.com/modelhub-ai/emotion-fer-plus
"model": {
    "description": "emotion-fer-plus is a deep convolutional neural network for emotion recognition in faces. It is trained on the FER+ dataset. The FER+ annotations provide a set of new labels for the standard Emotion FER dataset. In FER+, each image has been labeled by 10 crowd-sourced taggers, which provide better quality ground truth for still image emotion than the original FER labels. Having 10 taggers for each image enables researchers to estimate an emotion probability distribution per face. This allows constructing algorithms that produce statistical distributions or multi-label outputs instead of the conventional single-label output.",
    "provenance": "https://github.com/onnx/models/tree/master/emotion_ferplus",
    "architecture": "Convolutional Neural Network (CNN)",
    "learning_type": "Supervised learning",
    "format": ".onnx",
    "io": {
        "input": {
        "format": ["image/png", "image/jpg", "image/jpeg"],
        "dim_limits": [
            {
            "min": 1,
            "max": 4
            },
            {
            "min": 32
            },
            {
            "min": 32
            }
        ]
        },
        "output": [
        {
            "name": "emotion probabilities",
            "type": "label_list",
            "description": "Probabilities of the 8 facial expression classes."
        }
        ]
    }
}
{
  "0": "neutral",
  "1": "happiness",
  "2": "surprise",
  "3": "sadness",
  "4": "anger",
  "5": "disgust",
  "6": "fear",
  "7": "contempt"
}
