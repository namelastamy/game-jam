using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody rig;
    public SpriteRenderer sprite;

    public float speed;

    public Vector2 velocity;

        // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        velocity = (new Vector2(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical")).normalized) * speed;
        sprite.flipX = Input.GetAxis("Horizontal") < 0;
    }

    private void FixedUpdate() {
        rig.velocity = velocity;
    }
}