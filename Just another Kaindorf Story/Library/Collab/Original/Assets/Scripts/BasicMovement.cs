using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public class BasicMovement : MonoBehaviour {

    public float playerSpeed = 4f;
    public Sprite imgDownwards;
    public Sprite imgSidewaysLeft;
    public Sprite imgBackwards;
    public Sprite imgSidewaysRight;

    private Image myImageComponent;
    // Use this for initialization
    void Start () {
        myImageComponent = GetComponent<Image>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 targetVelocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        GetComponent<Rigidbody2D>().velocity = targetVelocity * playerSpeed;

        if (Input.GetKeyDown(KeyCode.A))
        {
            this.GetComponent<SpriteRenderer>().sprite = imgSidewaysLeft;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            this.GetComponent<SpriteRenderer>().sprite = imgDownwards;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            //this.GetComponent<SpriteRenderer>().sprite = imgSidewaysRight;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            this.GetComponent<SpriteRenderer>().sprite = imgBackwards;
        }
    }
}
