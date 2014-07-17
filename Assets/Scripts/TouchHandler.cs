using UnityEngine;
using System.Collections;
using System.Net.Sockets;

public class TouchHandler : MonoBehaviour {
	public GameObject player;
	private Animator animator;
	public GameObject ball;
	public bool isFirst = true;
	// Use this for initialization
	void Start () {
		animator = player.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update (){
		if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) || Input.GetAxis("Vertical") != 0) {
			Debug.Log("Drag ended!");
			animator.SetBool("bShoot", true);

		}
		if (isFirst) {
			if(animator.GetCurrentAnimatorStateInfo(0).IsName("shooting") && animator.GetCurrentAnimatorStateInfo(0).normalizedTime > (float)0.50){
				isFirst = false;
				ball.transform.GetComponent<NormalScript>().runAnimation(2, 0);
			}
		}
		Debug.Log ("time " + animator.GetCurrentAnimatorStateInfo (0).normalizedTime);

		if(animator.GetCurrentAnimatorStateInfo(0).IsName("shooting") && animator.GetCurrentAnimatorStateInfo(0).normalizedTime > (float)0.95){
			animator.SetBool("bShoot", false);
		}
	}
}