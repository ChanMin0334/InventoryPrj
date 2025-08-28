using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct PlayerData
{
    public string playerName;
    public int attackPower;
    public int defensePower;
    public int health;
    public int criticalChance;
    public int level;
    public int requiredExp;
    public int currentExp;
    public string info;
    public int gold;

    public PlayerData(string playerName, int attackPower, int defensePower, int health, int criticalChance, int level, int requiredExp, int currentExp, string info, int gold)
    {
        this.playerName = playerName;
        this.attackPower = attackPower;
        this.defensePower = defensePower;
        this.health = health;
        this.criticalChance = criticalChance;
        this.level = level;
        this.requiredExp = requiredExp;
        this.currentExp = currentExp;
        this.info = info;
        this.gold = gold;
    }
}

public class Character : MonoBehaviour
{
    public PlayerData playerData;

    void Start()
    {
        // ���� ������ �ʱ�ȭ
        playerData = new PlayerData
            ("������",  // �̸�
            35,  // ���ݷ�
            40, // ����
            100, // ü��
            25, // ũ��Ƽ�� Ȯ��
            13, // ����
            20, // �ʿ� ����ġ
            8, // ���� ����ġ
            "�ȳ��ϼ���. ����Ƽ é�� 6������ �κ��丮 ������ ����� �ִ� �������Դϴ�. ç������ ���� �ʹ� ��ƽ��ϴ�. �� �ƹ��͵� �ƴ� �����Դϴ�.",
            210000); // ����
    }

    void Update()
    {

    }
}
