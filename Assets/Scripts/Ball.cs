using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public float speed;
    public AudioSource bolaudio;
    public AudioSource bolaudio2;

    public AudioClip bolaclip;
    public AudioClip bolaclip2;

    private Rigidbody2D rb;
    private bool ballInPlay;


    // Use this for initialization
    //void Start () {
    //	GetComponent<Rigidbody2D> ().velocity = Vector2.down * speed;
    //}

    void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }

    void Start() {
        bolaudio.clip = bolaclip;
        bolaudio2.clip = bolaclip2;
    }


    void Update(){
        if (Input.GetButtonDown("Fire1") && ballInPlay == false){
            transform.parent = null;
            ballInPlay = true;
            rb.bodyType = RigidbodyType2D.Dynamic;
            rb.velocity = new Vector2(0.1f,0.6f).normalized * speed;
        }

        if ((rb.velocity.magnitude > speed) || (rb.velocity.magnitude < speed)){
            rb.velocity = rb.velocity.normalized * speed;
        }
        if (rb.velocity.normalized == new Vector2(1, 0).normalized) {
            print("aaaaaaaaa");
            rb.velocity = new Vector2(1f, 0.1f).normalized * speed;
        }
        if (rb.velocity.normalized == new Vector2(-1, 0).normalized) {
            print("aaaaaaaaa");
            rb.velocity = new Vector2(-1f, 0.1f).normalized * speed;
        }


        
    }


    float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketWidth) {
        return (ballPos.x - racketPos.x) / racketWidth;
	}
	
	void OnCollisionEnter2D(Collision2D col) {
        // Hit the Racket?
        if (col.gameObject.name == "pad1(Clone)") {
            bolaudio.Play();
            // Calculate hit Factor
            float x = hitFactor(transform.position,
                col.transform.position,
                col.collider.bounds.size.x);

            // Calculate direction, set length to 1
            Vector2 dir = new Vector2(x, 0.5f).normalized;

            // Set Velocity with dir * speed
            rb.velocity = dir * speed;
        }
        else {
            bolaudio2.Play();
        }
    }
}
