using UnityEngine;

[CreateAssetMenu(fileName = "EnemyDataSO", menuName = "Scriptable Objects/EnemyDataSO")]
public class EnemyDataSO : ScriptableObject
{
    public string EntityName;
    public ulong ID;

    public int Health;
    public int Damage;
    public float Speed;

    public Sprite sprite;

}
