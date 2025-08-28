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
        // 예시 값으로 초기화
        playerData = new PlayerData
            ("이찬민",  // 이름
            35,  // 공격력
            40, // 방어력
            100, // 체력
            25, // 크리티컬 확률
            13, // 레벨
            20, // 필요 경험치
            8, // 현재 경험치
            "안녕하세요. 유니티 챕터 6과제인 인벤토리 구현을 만들고 있는 이찬민입니다. 챌린지반 수업 너무 어렵습니다. 전 아무것도 아닌 존재입니다.",
            210000); // 정보
    }

    void Update()
    {

    }
}
