using System;
using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class BaseController : MonoBehaviour
{
    private void Awake()
    {
        Managers.Scene.SetController(this);
    }
}
