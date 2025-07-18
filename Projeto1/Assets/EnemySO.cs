using UnityEngine;

[CreateAssetMenu(fileName = "EnemySO", menuName = "Scriptable Objects/EnemySO")]
public class EnemySO : ScriptableObject
{
    public string EnemyName;
    public int HP;
    public int Damage;
    public int Speed;
    public Sprite Enemysprite;
}
