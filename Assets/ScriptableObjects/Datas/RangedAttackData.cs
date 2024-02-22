using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "RangedAttackData", menuName = "TopDownController/Attacks/Ranged", order = 1)]

public class RangedAttackData : AttackSO
{
    // Start is called before the first frame update
    [Header("Ranged Attack Data")]
    public string bulletNameTag;
    public float duration;
    public float spread;
    public int numberofProjectilesPerShot;
    public float multipleProjectilesAngel;
    public Color projectileColor;
}
