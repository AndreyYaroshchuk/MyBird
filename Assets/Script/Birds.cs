using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birds : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed = 1f;

    public float Speed { get => speed; set => speed = value; }
    public Rigidbody2D Rb { get => rb; set => rb = value; }


    private void Update()
    {
        Vector2 newVelositi = Rb.velocity;
        newVelositi.x = Speed * transform.lossyScale.x * 1;
        Rb.velocity = newVelositi;

        //rb.velocity = new Vector3(transform.position.x + 1f, transform.position.y, transform.position.z);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector2 newVelositi_ = Rb.velocity;
            newVelositi_.y = Speed * transform.lossyScale.y * 1;
            Rb.velocity = newVelositi_;
        }
            //transform.position = new Vector3(transform.position.x, transform.position.y + 0.01f, transform.position.z);
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("+");
    }
}
