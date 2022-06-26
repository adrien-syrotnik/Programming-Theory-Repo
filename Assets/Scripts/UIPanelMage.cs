using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIPanelMage : MonoBehaviour
{
    [SerializeField]
    private Mage mage;
    
    // Start is called before the first frame update
    void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(OnChoose);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnChoose()
    {
        MainManager.Instance.mageSelected = mage;
        TextMeshProUGUI mageChoicedText = GameObject.Find("Mage Selected Text").GetComponent<TextMeshProUGUI>();
        mageChoicedText.text = "Mage selected : " + mage.name;

        Button button = GameObject.Find("Start Button").GetComponent<Button>();
        button.interactable = true;
    }
}
