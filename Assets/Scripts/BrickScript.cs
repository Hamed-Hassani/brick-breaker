using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BrickScript : MonoBehaviour
{
    public UiManager ui;
    void Start()
    {
        ui = GameObject.FindWithTag("ui").GetComponent<UiManager>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ball")
        {
            ui.IncrementScore();
            Destroy(gameObject);
        }
    }


}
