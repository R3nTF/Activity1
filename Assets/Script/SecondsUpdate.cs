using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondsUpdate : MonoBehaviour
{
    void Update()
    {
        this.transform.Translate(0, 0, 0.02f);
    }
}
