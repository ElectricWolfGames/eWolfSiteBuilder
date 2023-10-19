using System;
using UnityEngine;

public class ShowInspector : MonoBehaviour
{
    [Range(1, 10)]
    public float Price = 5;

    public ExtraData ExtraData = new ExtraData();
    public UsableItems UsableItems = UsableItems.None;

    public void ResetValues()
    {
        UsableItems = UsableItems.None;
        Price = 5;
    }
}

[Serializable]
public class ExtraData
{
    public bool ShowIcon = true;

    [Range(32.0f, 256)]
    public float IconSize = 96;

}
