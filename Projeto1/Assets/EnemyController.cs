using System;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public EnemySO enemyData;

    public string EnemyName => enemyData.EnemyName;
    public int HP => enemyData.HP;
    public int Damage => enemyData.Damage;
    public int Speed => enemyData.Speed;
    public Sprite Enemysprite => enemyData.Enemysprite;
    
    private void OnValidate()
    {
        if (!enemyData) return;
        GetComponent<SpriteRenderer>().sprite = Enemysprite;
    }
}
