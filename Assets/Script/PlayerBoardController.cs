using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBoardController : MonoBehaviour{
    Rigidbody2D rb2d;
    Vector2 CurrentMovement = new Vector2(5, 0);
    [SerializeField] float velocityadd = 5;

    [SerializeField] Vector2 BallLauncher = new Vector2(50, 50);

    [SerializeField] GameObject PlayerBall = null;

    [SerializeField] GameObject PlayerCapsule = null;

    bool isBallLauncher = false;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        isBallLauncher = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        //如果按下A
        if(  Input.GetKey(KeyCode.D)){
            // 執行向右這裡的內容
            rb2d.AddForce( CurrentMovement * velocityadd );

        }//如果按下D
        else if( Input.GetKey(KeyCode.A)) {
            // 執行向左這裡的內容
             rb2d.AddForce( CurrentMovement * -1 * velocityadd  );
        }
        else{
            rb2d.velocity = Vector2.zero;
        }

        if(isBallLauncher == false) {
            Vector3 Boradpos = transform.position;
            Boradpos.y += 1;
            PlayerBall.transform.position = Boradpos;

            if( Input.GetKeyDown( KeyCode.Space) ){
                Rigidbody2D PlayerRb = PlayerBall.GetComponent<Rigidbody2D>();
                PlayerRb.AddForce(BallLauncher);

                Rigidbody2D CapsuleRb = PlayerCapsule.GetComponent<Rigidbody2D>();
                CapsuleRb.AddForce(BallLauncher);
                isBallLauncher = true;
                Debug.Log("Ball already shot.");
            }
        }
    }
}

    