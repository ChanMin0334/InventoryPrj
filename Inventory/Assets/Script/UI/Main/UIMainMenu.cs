using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField]
    UILevel uiLevel;
    [SerializeField]
    Text PlayerNameText;
    [SerializeField]
    Text PlayerInfoText;
    void OnEnable()
    {
        GameManager.OnPlayerDataChanged += SetPlayerData;
    }

    void OnDisable()
    {
        GameManager.OnPlayerDataChanged -= SetPlayerData;
    }

    public void SetPlayerData(Character player)
    {
        PlayerData data = player.playerData;
        uiLevel.UpdateLevel(data);
        PlayerNameText.text = data.playerName;
        PlayerInfoText.text = data.info;
    }
}
