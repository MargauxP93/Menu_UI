using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsSwitchUI : MonoBehaviour
{
    [SerializeField] SwitchButton graphicsButton = null;
    [SerializeField] SwitchButton gameplayButton = null;
    [SerializeField] SwitchButton soundButton = null;
    [SerializeField] SwitchButton currentButtonDisplayed = null;
    [SerializeField] GameObject currentOptionDisplayed = null;

    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Init()
    {
        graphicsButton.Button.onClick.AddListener(() =>
        {
            UpdateCurrentOptionDisplayed(graphicsButton.ToShow);
            UpdateCurrentButtonDisplayed(graphicsButton);
        });
        gameplayButton.Button.onClick.AddListener(() =>
        {
            UpdateCurrentOptionDisplayed(gameplayButton.ToShow);
            UpdateCurrentButtonDisplayed(gameplayButton);
        });
        soundButton.Button.onClick.AddListener(() =>
        {
            UpdateCurrentOptionDisplayed(soundButton.ToShow);
            UpdateCurrentButtonDisplayed(soundButton);
        });



    }
    private void UpdateCurrentOptionDisplayed(GameObject _toShow)
    {
        if (currentOptionDisplayed != null)
        {
            currentOptionDisplayed.SetActive(false);
            Debug.Log("Hide");
        }
        currentOptionDisplayed = _toShow;
            Debug.Log("after");
    }
    
    void UpdateCurrentButtonDisplayed(SwitchButton _button)
    {
        if(currentButtonDisplayed != null) 
        {
            currentButtonDisplayed.ButtonText.color = Color.red;

        }
        currentButtonDisplayed = _button;
        if (!currentButtonDisplayed) return;
        currentButtonDisplayed.ButtonText.color = Color.white;
    }
    private void OnDisable()
    {
        if (!currentOptionDisplayed||!currentButtonDisplayed) return;
        currentOptionDisplayed.SetActive(false);
        currentOptionDisplayed = null;

        UpdateCurrentButtonDisplayed(null);
    }
}
