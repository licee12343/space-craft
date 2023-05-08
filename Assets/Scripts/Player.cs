using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float veloc;
    public float entradaHorizontal;
    public float entradaVertical;
    public GameObject pfLaser;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0,0,0);
        veloc = 5.0f;
    }

    // Update is called once per frame
    void Update(){   
        Movimento();

        if ( Input.GetKeyDown(KeyCode.Space)    ||  Input.GetMouseButtonDown(0)){

            Instantiate(pfLaser,transform.position + new Vector3(0,1.1f,0),Quaternion.identity );
        }



    }

    private void Movimento(){
        entradaHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*Time.deltaTime*veloc*entradaHorizontal);
        if ( transform.position.x > 9.68f){
            transform.position = new Vector3(-9.68f,transform.position.y,0);
        } else if ( transform.position.x < -9.68f) {
            transform.position = new Vector3(9.68f,transform.position.y,0);
        }
        entradaVertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up*Time.deltaTime*veloc*entradaVertical);
        if ( transform.position.y > 0f){
            transform.position = new Vector3(transform.position.x,0,0);
        } else if ( transform.position.y < -3.68f) {
            transform.position = new Vector3(transform.position.x,-3.68f,0);
        }
    }
}
