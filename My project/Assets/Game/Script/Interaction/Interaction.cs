using System;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    private Transform _cachedTransform;

    public Transform CachedTransform => _cachedTransform;

    private void Awake()
    {
        _cachedTransform = transform;
    }
}
