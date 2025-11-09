using System;
using UnityEngine;

[Serializable]
public class Stat_DefenseGroup
{
    //物理防御
    public Stat armor; //护甲
    public Stat evasion; //闪避

    //魔法防御
    public Stat fireRes; //火焰抗性
    public Stat iceRes; //冰霜抗性
    public Stat lightningRes; //闪电抗性
}
