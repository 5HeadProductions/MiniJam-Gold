using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   
    public GameObject player;
    public GameObject rightAnchor;
    public GameObject leftAnchor;

    private HingeJoint2D _leftJoint;
    private HingeJoint2D _rightJoint;
    public float rotationSpeed;
     
    private float _coinHitTimer = 0;
    public float handTimeOut;

    
    void Start(){
        _leftJoint = leftAnchor.GetComponent<HingeJoint2D>();
        _rightJoint = rightAnchor.GetComponent<HingeJoint2D>();
    }

    void Update()
    {
        _coinHitTimer -= Time.deltaTime;
        if(Input.GetKey(KeyCode.A) && _coinHitTimer <= 0){
            _rightJoint.enabled = true;
            var impulse = (rotationSpeed * Mathf.Deg2Rad) * player.GetComponent<Rigidbody2D>().inertia;

        player.GetComponent<Rigidbody2D>().AddTorque(impulse, ForceMode2D.Impulse);
            
        }
        if(Input.GetKeyUp(KeyCode.A))
        _rightJoint.enabled = false;
        
        if(Input.GetKey(KeyCode.D) && _coinHitTimer <= 0){
            _leftJoint.enabled = true;
            var impulse = -(rotationSpeed * Mathf.Deg2Rad) * player.GetComponent<Rigidbody2D>().inertia;

        player.GetComponent<Rigidbody2D>().AddTorque(impulse, ForceMode2D.Impulse);
            
        }
        if(Input.GetKeyUp(KeyCode.D))
        _leftJoint.enabled = false;
    }

    public void handRelease(){
        if(_leftJoint.isActiveAndEnabled)
        _leftJoint.enabled = false;
        else if(_rightJoint.isActiveAndEnabled)
        _rightJoint.enabled = false;
       
        _coinHitTimer = handTimeOut;

    }

    
}
