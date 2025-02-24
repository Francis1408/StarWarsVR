using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI promptText;

    [SerializeField]
    private TextMeshProUGUI buttonText;
    public GameObject canvas;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void UpdatePromptText(string promptMessage) {
        promptText.text = promptMessage;
    }

    public void UpdateButtonText(string buttonMessage) {
        buttonText.text = buttonMessage;
    }
}
