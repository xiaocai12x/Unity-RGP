using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Stat
{
    [SerializeField] private float baseValue;
    [SerializeField] private List<StatModifier> modifiers = new List<StatModifier>();

    private bool needToCalcualte = true;
    private float finalValue;

    public float GetValue()
    {
        if (needToCalcualte)
        {
            finalValue = GetFinalValue();
            needToCalcualte = false;
        }


        return finalValue;
    }

    // buff或者特殊效果道具等可以调用这个方法来修改基础属性值
     
    public void AddModifier(float value, string source)
    {
        StatModifier modToAdd = new StatModifier(value, source);
        modifiers.Add(modToAdd);
        needToCalcualte = true;
    }

    public void RemoveModifier(string source)
    {
        modifiers.RemoveAll(modifier => modifier.Source == source);
        needToCalcualte = true;
    }

    private float GetFinalValue()
    {
        float finalValue = baseValue;

        foreach(var modifier in modifiers)
        {
            finalValue += modifier.Value;

        }

        return finalValue;
    }

    public void SetBaseValue(float value) => baseValue = value;

}


[Serializable]
public class StatModifier
{
    public float Value;
    public string Source;
    public StatModifier(float value, string source)
    {
        Value = value;
        Source = source;
    }
}
