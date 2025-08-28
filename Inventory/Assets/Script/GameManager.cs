// GameManager.cs
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static event System.Action<Character> OnPlayerDataChanged;

    public Character player;

    void Start()
    {
        if (player != null)
        {
            OnPlayerDataChanged?.Invoke(player);
        }
    }

    public void UpdatePlayerData(PlayerData newData)
    {
        if (player != null)
        {
            player.playerData = newData;
            OnPlayerDataChanged?.Invoke(player);
        }
    }
}
