using UnityEngine;

/// <summary>
/// 怪物屬性值
/// </summary>
public class Enemy : MonoBehaviour
{
    /// <summary>
    /// 怪物血量
    /// </summary>
    [Header("血量"), Tooltip("怪物的血量"), Range(50, 500)]
    public int HP ;

    /// <summary>
    /// 怪物魔力
    /// </summary>
    [Header("魔力"), Tooltip("怪物的魔力"), Range(1, 100)]
    public int MP = 100;

    /// <summary>
    /// 怪物移動速度
    /// </summary>
    [Header("移動速度"), Tooltip("怪物的移動速度"), Range(1, 50.5f)]
    public float MoveSpead = 10.5f;

    /// <summary>
    /// 怪物攻擊力
    /// </summary>
    [Header("攻擊力"), Tooltip("怪物的攻擊力"), Range(20, 200)]
    public int ATK = 50;

    /// <summary>
    /// 怪物防禦力
    /// </summary>
    [Header("防禦力"), Tooltip("怪物的防禦力"), Range(0, 100)]
    public int DEF ;

    /// <summary>
    /// 怪物的武器名稱
    /// </summary>
    [Header("武器名稱"), Tooltip("武器名稱")]
    public string WeaponName = "";

    /// <summary>
    /// 怪物的裝備名稱
    /// </summary>
    [Header("裝備名稱"), Tooltip("裝備名稱")]
    public string EquipmentName = "皮衣";

    /// <summary>
    /// 怪物是否帶有鑰匙
    /// </summary>
    [Header("是否帶有鑰匙"), Tooltip("怪物是否帶有鑰匙")]
    public bool Key = false;

    /// <summary>
    /// 怪物是否掉落寶物
    /// </summary>
    [Header("是否掉落寶物"), Tooltip("怪物是否掉落寶物")]
    public bool Treasure = false;
}
