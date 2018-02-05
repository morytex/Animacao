using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimaScript : MonoBehaviour {

	public float velocidade;

	Animator animator;

	SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		spriteRenderer = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		float mover_x = Input.GetAxisRaw ("Horizontal") * velocidade * Time.deltaTime;
		transform.Translate (mover_x, 0.0f, 0.0f);

		if (mover_x > 0.0f) {
			spriteRenderer.flipX = false;
		} else if (mover_x < 0.0f) {
			spriteRenderer.flipX = true;
		}

		animator.SetFloat ("pMover", Mathf.Abs (Input.GetAxisRaw ("Horizontal")));
	}
}
