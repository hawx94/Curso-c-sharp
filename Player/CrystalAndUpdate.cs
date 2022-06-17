using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalAndUpdate : MonoBehaviour
{
    public static CrystalAndUpdate instance;
    public enum CrystalType
    {
        red,
        yellow,
        blue,
        purple,
        empty

    }

    public CrystalType type;

    public void Awake()
    {
        instance = this;
    }

    public void LevelUp()
    {

    }
        
}
