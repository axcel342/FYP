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
