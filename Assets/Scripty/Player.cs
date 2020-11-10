using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed;
    private Animator animacao;

    // Start is called before the first frame update
    void Start()
    {
        animacao = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move(){
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);
        transform.position += movement * Time.deltaTime * Speed;
        if (Input.GetAxis("Horizontal") > 0f || Input.GetAxis("Vertical") > 0f){
            animacao.SetBool("Parado", false);
            transform.eulerAngles = new Vector3(0f,0f,0f);
        } else if (Input.GetAxis("Horizontal") < 0f){
            animacao.SetBool("Parado", false);
            transform.eulerAngles = new Vector3(0f,180f,0f);

        } else if (Input.GetAxis("Horizontal") == 0f || Input.GetAxis("Vertical") == 0f){
            animacao.SetBool("Parado", true);
        }
        if (Input.GetAxis("Vertical") < 0f){
            animacao.SetBool("Parado", false);
        }
    }

    void CapturarKiwi(){
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);
    }
}
