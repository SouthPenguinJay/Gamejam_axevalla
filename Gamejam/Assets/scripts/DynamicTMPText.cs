using System.Collections;
using UnityEngine;
using TMPro;

public class DynamicTMPText : MonoBehaviour
{
    public TextMeshProUGUI myTMPText;

    void Start()
    {
        if (myTMPText == null)
        {
            myTMPText = GetComponent<TextMeshProUGUI>();
        }
    }

    void Update()
    {
        // Example: display a countdown
        float countdown = 10f - Time.timeSinceLevelLoad;
        myTMPText.text = "Countdown: " + Mathf.Max(countdown, 0).ToString("F2");
    }
}
