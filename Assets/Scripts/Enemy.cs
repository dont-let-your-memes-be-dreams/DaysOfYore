using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	GameObject pathOn;

	Transform targetPathNode;
	int pathNodeIndex = 0;

	float speed = 5f;

	public float health = 100f;

	public int moneyValue = 1;

	// Use this for initialization
	void Start () {
		pathOn = GameObject.Find("Path");
	}

	void GetNextPathNode() {
		if(pathNodeIndex < pathOn.transform.childCount) 
		{
			targetPathNode = pathOn.transform.GetChild(pathNodeIndex);
			pathNodeIndex++;
		}
		else 
		{
			targetPathNode = null;
			ReachedGoal();
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(targetPathNode == null) 
		{
			GetNextPathNode();
			if(targetPathNode == null) 
			{
				// run out of path!
				ReachedGoal();
				return;
			}
		}

		Vector3 direction = targetPathNode.position - this.transform.localPosition;

		float distThisFrame = speed * Time.deltaTime;

		if(direction.magnitude <= distThisFrame) 
		{
			// We reached the node
			targetPathNode = null;
		}
		else 
		{
			// TODO: Consider ways to smooth this motion.

			// Move towards node
			transform.Translate( direction.normalized * distThisFrame, Space.World );
			Quaternion targetRotation = Quaternion.LookRotation( direction );
			this.transform.rotation = Quaternion.Lerp(this.transform.rotation, targetRotation, Time.deltaTime*5);
		}

	}

	void ReachedGoal() 
	{
		GameObject.FindObjectOfType<ScoreManager>().LoseLife();
		Destroy(gameObject);
	}

	public void TakeDamage(float damage) 
	{
		health -= damage;
		if(health <= 0) 
		{
			Die();
		}
	}

	public void Die() 
	{
		GameObject.FindObjectOfType<ScoreManager>().money += moneyValue;
		Destroy(gameObject);
	}
}
