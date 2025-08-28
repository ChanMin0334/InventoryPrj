using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.UI;

public class UILevel : MonoBehaviour
{
    [SerializeField]
    Text LevelText; 
    [SerializeField]
    Image ExpBar;
    [SerializeField]
    TextMeshProUGUI ExpText;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void UpdateLevel(PlayerData data)
    {
        LevelText.text = data.level.ToString();
        ExpBar.fillAmount = (float)data.currentExp / data.requiredExp;
        ExpText.text = data.currentExp + " / " + data.requiredExp;
    }
}
