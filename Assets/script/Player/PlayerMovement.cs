using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PlayerMovement : MonoBehaviour {   //ใช้งานที่ object Player 
    Rigidbody playerRigidbody;                  //สร้าง object Rigidbody 
    Vector3 movement;                           // เซตการเคลื่อนที่ 
    public float speed = 2;                     // คความเร็วการเคลื่อนที่
    Animator anim;                              // เซตอนิเมชั่น
    int floorMask;                              //ใช้งานร่วมกับ camRay 
    float camRayLength = 100f;
    private char Alphabet;                          //ตัวแปรที่รู้ว่าเก็บไอเทมแล้ว
    public string[] word = new string[] {"BAT", "BIRD", "CAT", "COW", "DOG", "DUCK", "FISH", "HOESE", "RAT", "SNAKE"} ;
    //public GameObject test;
    /*เซตใน Unity*/
    /*เซต Layout สร้าง layout floor ขึ้นมา และ ใช้ layout floor */
    /*เซต tag ที่ player ให้เป็น player */

    void Start () {
   // test.gameObject.CompareTag("box_tester");           //*** reference 
    playerRigidbody = GetComponent<Rigidbody>();         //เอาค่ามาจาก CompnentRigidbody ใน unity 
    anim = GetComponent<Animator>();                    //เอาค่ามาจาก CompnentAnimator ใน unity 
    floorMask = LayerMask.GetMask("floor");
    }

void FixedUpdate () {                                   //Fixed ทำงานตลอดเวลารอรับ Input จากผู้เล่น 
    float h = Input.GetAxis("Horizontal");              //เคลื่อนไหวในแนวนอน
    float v = Input.GetAxis("Vertical");                //เคลื่อนไหวในแนวตั้ง
    Move(h, v);
    animating(h, v);
    Turning();

}
void Move(float h, float v){
    movement.Set(h, 0, v);                     
    movement = movement.normalized * speed * Time.deltaTime;
    playerRigidbody.MovePosition(transform.position + movement);
}
void animating(float h, float v){
    bool walk = h != 0 || v != 0;                                           //เช็คเงื่อนไขว่ามีการเคลื่อนที่รึไหม และไปปรับใน Unity ใน animator และเอา Has Exit Time ออก 
    anim.SetBool("isWalking",walk);

}

void Turning(){
    Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);         //สร้าง Ray จาก camera แล้วกระทบกับ object ของเมาส์
    RaycastHit floorHit;
    if (Physics.Raycast(camRay, out floorHit, camRayLength, floorMask)){    //ยิง Ray จากกล้องตกกระทบที่ player และให้ player ทำตามเงือ่นไข
        Vector3 playerToMouse = floorHit.point - transform.position;
        playerToMouse.y = 0;
        Quaternion newrotation = Quaternion.LookRotation(playerToMouse);
        playerRigidbody.MoveRotation(newrotation);
        }

    }
   void OnTriggerEnter(Collider other){       //ชนแล้ววัตถุหายไป 

        if (other.gameObject.CompareTag("Untagged")){
                
        }
        else{

            other.gameObject.SetActive(false);
            if (other.gameObject.CompareTag("Box1"))
            {
                Alphabet = 'A';
            }
            else if (other.gameObject.CompareTag("Box2"))
            {
                Alphabet = 'B';
            }
            else if (other.gameObject.CompareTag("Box3"))
            {
                Alphabet = 'C';
            }
            else if (other.gameObject.CompareTag("Box4"))
            {
                Alphabet = 'D';
            }
            else if (other.gameObject.CompareTag("Box5"))
            {
                Alphabet = 'E';
            }
            else if (other.gameObject.CompareTag("Box6"))
            {
                Alphabet = 'F';
            }
            else if (other.gameObject.CompareTag("Box7"))
            {
                Alphabet = 'G';
            }
            else if (other.gameObject.CompareTag("Box8"))
            {
                Alphabet = 'H';
            }
            else if (other.gameObject.CompareTag("Box9"))
            {
                Alphabet = 'I';
            }
            else if (other.gameObject.CompareTag("Box10"))
            {
                Alphabet = 'J';
            }
            else if (other.gameObject.CompareTag("Box11"))
            {
                Alphabet = 'K';
            }
            else if (other.gameObject.CompareTag("Box2"))
            {
                Alphabet = 'L';
            }
            else if (other.gameObject.CompareTag("Box13"))
            {
                Alphabet = 'M';
            }
            else if (other.gameObject.CompareTag("Box14"))
            {
                Alphabet = 'N';
            }
            else if (other.gameObject.CompareTag("Box15"))
            {
                Alphabet = 'O';
            }
            else if (other.gameObject.CompareTag("Box16"))
            {
                Alphabet = 'P';
            }
            else if (other.gameObject.CompareTag("Box17"))
            {
                Alphabet = 'Q';
            }
            else if (other.gameObject.CompareTag("Box18"))
            {
                Alphabet = 'R';
            }
            else if (other.gameObject.CompareTag("Box19"))
            {
                Alphabet = 'S';
            }
            else if (other.gameObject.CompareTag("Box20"))
            {
                Alphabet = 'T';
            }
            else if (other.gameObject.CompareTag("Box21"))
            {
                Alphabet = 'U';
            }
            else if (other.gameObject.CompareTag("Box22"))
            {
                Alphabet = 'V';
            }
            else if (other.gameObject.CompareTag("Box23"))
            {
                Alphabet = 'W';
            }
            else if (other.gameObject.CompareTag("Box24"))
            {
                Alphabet = 'X'; 
            }
            else if (other.gameObject.CompareTag("Box25"))
            {
                Alphabet = 'Y';
            }
            else if (other.gameObject.CompareTag("Box26"))
            {
                Alphabet = 'Z';   
            }
            SetText(Alphabet);
        }

   }
    public String value = "";

    void SetText(char Alphabet)
    {
        value += Alphabet;
        //Debug.Log(value);
        for(int i= 0; i>10; i++)
        {
            Debug.Log(word[i]);
        }

    }

}
