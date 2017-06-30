using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))] public class Attacker : MonoBehaviour {
	private float currentSpeed; // C# annotation
	private GameObject currentTarget;
	
	// Use this for initialization
	void Start () {
		Rigidbody2D myRigidbody = gameObject.AddComponent<Rigidbody2D>();
		myRigidbody.isKinematic = true;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D col){
		Debug.Log(name + "trigger enter");
	}

	public void SetSpeed(float speed){
		currentSpeed = speed;
	}

	public void StrikeCurrentTarget(float damage){
		if(currentTarget) {
			Health health = currentTarget.GetComponent<Health>();
			if(health) {
				health.DealDamage(damage);
			}
		}
	}

	public void Attack(GameObject obj){
		currentTarget = obj;

	}
}