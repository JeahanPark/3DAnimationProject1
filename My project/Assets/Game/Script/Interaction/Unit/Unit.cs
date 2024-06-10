using System;
using UnityEditor.Animations;
using UnityEngine;

public class Unit : Interaction
{
    [SerializeField] protected Animator animator;

    private bool _move;
    private Vector3 _moveDir;
    private float _speed = 5f;

    
    public void Move(Vector2 dir)
    {
        if (dir == Vector2.zero)
        {
            // 이동안함
            _move = false;
        }
        else
            _move = true;

        animator.SetBool("Move", _move);

        if (_move)
        {
            _moveDir = new Vector3(dir.x, 0, dir.y);
            Debug.Log(_moveDir);
        }
            
    }

    private void Update()
    {
        if (_move)
        {
            float angle = Mathf.Atan2(_moveDir.x, _moveDir.z) * Mathf.Rad2Deg;
            
            Quaternion rotation = Quaternion.Euler(0, angle, 0);
            
            Vector3 rotatedVector = rotation * transform.forward;
            
            CachedTransform.position += Time.deltaTime * _speed * rotatedVector.normalized;
        }
    }
}
