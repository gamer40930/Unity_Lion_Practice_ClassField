using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    /// <summary>
    /// 怪物一號
    /// </summary>
    [Header ("怪物一號")]
    public Enemy Enemy01;

    /// <summary>
    /// 怪物二號
    /// </summary>
    [Header("怪物二號")]
    public Enemy Enemy02;

    private void Start()
    {

        //取得欄位練習//
        print(Enemy01.MP);            //輸出怪物一號的魔力值
        print(Enemy02.EquipmentName); //輸出怪物二號的裝備名稱

        //設定欄位練習//

        Enemy01.HP = 100;              //修改怪物一號的血量為 100
        Enemy02.HP = 300;              //修改怪物二號的血量為 300
        Enemy01.DEF = 50;              //修改怪物一號的防禦力為 50
        Enemy01.WeaponName = "木棍";   //修改怪物一號的武器名稱為 ”木棍”
        Enemy02.WeaponName = "短刀";   //修改怪物二號的武器名稱為 ”短刀”
        Enemy01.Key = true;            //修改怪物一號的是否帶有鑰匙為 是
        Enemy02.Treasure = true;       //修改怪物二號的是否帶有寶物為 是


    }
}
