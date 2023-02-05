using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    private Player _player;
    private Vector2 _direction;
    private Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        _player = GetComponent<Player>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        _direction = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));
        float _vertical =_direction.y;
        float _horizontal =_direction.x;
        _animator.SetInteger("Horizontal",(int)Mathf.Ceil(_horizontal));
        _animator.SetInteger("Vertical",(int)Mathf.Ceil(_vertical));
        Debug.Log(_direction.y);
    }


}