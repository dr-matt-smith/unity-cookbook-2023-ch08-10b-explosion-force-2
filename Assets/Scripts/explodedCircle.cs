using UnityEngine;

public class ExplodeTagged : MonoBehaviour {
    public string tagName = "Bug";
    public float force = 800f;
    public float radius = 3f;

    private GameObject[] _gameObjects; 

    private void Awake(){
        _gameObjects = GameObject.FindGameObjectsWithTag(tagName);
    }

    void Update(){
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Explode();
        }
    }
  
    private void Explode(){
        foreach(var gameObject in _gameObjects){
            Rigidbody2D rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
            rigidbody2D.AddExplosionForce(force, transform.position, radius);
        }
    }
}

