using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public Transform target;                        //ตำแหน่งของplayer 
    public float smoothing = 5f;                    //เวลาในการเลื่อนกล้องจากตำแหน่งหนึ่งสู่อีกตำแหน่งหนึ่ง
    Vector3 offset;                                 //ระยะห่างรหว่าง player และ กล้อง
	
	void Start () {
        offset = transform.position - target.position;              //หาระยะห่างรหว่าง player และ กล้อง

    }
	

	void FixedUpdate () {
        Vector3 targetCampos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position,targetCampos,smoothing*Time.deltaTime);   //ให้กล้องเลื่อนไปทางไหน ตำแหน่งผู้เล่นอยู่ไหน โดยใช้เวลาเท่าไหร่(ความเร็วเท่าไหร่)
		
	}
}
