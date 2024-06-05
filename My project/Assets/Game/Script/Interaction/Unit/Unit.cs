using System;
using UnityEditor.Animations;
using UnityEngine;

public class Unit : Interaction
{
    [SerializeField] protected Animator animator;

    private bool _move;
    protected Vector3 MoveDir;
    private float _speed;
    
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
            MoveDir = new Vector3(dir.x, 0, dir.y);
            Debug.Log(MoveDir);
        }
            
    }

    private void Update()
    {
        if(_move)
            CachedTransform.position += Time.deltaTime * _speed * MoveDir;
    }
}
