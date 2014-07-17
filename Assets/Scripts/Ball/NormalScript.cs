using UnityEngine;
using System.Collections;

public class NormalScript : MonoBehaviour {
	private int currentAnimation = 1;
	// Use this for initialization
	private Animator animator;
	void Start () {
		animator = gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(animator.GetCurrentAnimatorStateInfo(0).IsName("nameAnimation" + currentAnimation.ToString()) && animator.GetCurrentAnimatorStateInfo(0).normalizedTime > (float)0.8){
			animator.SetBool ("bAnimation" + currentAnimation.ToString (), false);
			GameObject.Find("GameManagement").transform.GetComponent<TouchHandler>().isFirst = true;
		}
	}

	public void runAnimation(int indexAniamtion, int posBall){
		switch (posBall) {
			case 1:
				break;
			case 2:
				break;
			default: 
				break;
		}
		animator.SetBool ("bAnimation" + indexAniamtion.ToString (), true);
		currentAnimation = indexAniamtion;
	}
}
