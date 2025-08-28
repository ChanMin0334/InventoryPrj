using UnityEngine;

public enum StatType
{
    Attack,
    Defense,
    Health,
    Critical,
    Test,
    None
}
public class Stats : MonoBehaviour
{
    StatItem[] statItems;
    void Awake()
    {
        statItems = GetComponentsInChildren<StatItem>();
    }

    public void UpdateStatus(Character player)
    {
        var playerData = player.playerData;

        foreach (var item in statItems)
        {
            switch (item.statType)
            {
                case StatType.Attack:
                    item.statValue.text = playerData.attackPower.ToString();
                    break;
                case StatType.Defense:
                    item.statValue.text = playerData.defensePower.ToString();
                    break;
                case StatType.Health:
                    item.statValue.text = playerData.health.ToString();
                    break;
                case StatType.Critical:
                    item.statValue.text = playerData.criticalChance.ToString();
                    break;
                case StatType.Test:
                    item.statValue.text = "Test";
                    break;
                case StatType.None:
                default:
                    item.statValue.text = "None";
                    break;
            }
        }
    }
}
