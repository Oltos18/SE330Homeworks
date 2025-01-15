using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpdate : MonoBehaviour
{
    public float _speed = 2f / 1f;
    public float _timeFromStart;
    public int _timeFromStart_int;
    public int _timeFromStart_previous;
    public int _count = 0;
    public Boolean _canRotate;
    
    //float temp_time = 0f;
    void Update()
    {
        //Debug.Log("previous " + _timeFromStart_int);
        //Debug.Log(_canRotate);
        //Debug.Log(_count);
        
        //Debug.Log(_timeFromStart);
        //_timeFromStart_int=Mathf.FloorToInt(_timeFromStart);
        //Debug.Log("int " + _timeFromStart_int);
        
        _timeFromStart_int=Mathf.FloorToInt(_timeFromStart);
        
        if (_timeFromStart_int - _timeFromStart_previous == 1)
        {
            _canRotate = true;
            _count += 1;
            Debug.Log("count value in update script " +  _count);
        }
        else
        {
            _canRotate = false;
        }
        
        if (Input.GetKey(KeyCode.Space) && _canRotate && _count%2!=0) 
        {
            transform.Rotate(new Vector3(0,90,0));
        }
        
        //Debug.Log(temp_time);
        /*if (temp_time > 1)
        {
            temp_time = 0;
        }*/
        if (_timeFromStart_int % 2 == 0)
        {
            transform.Translate(new Vector3(0,0,_speed*Time.deltaTime));
            //transform.Translate(Vector3.forward*_speed*Time.deltaTime);
            //Mathf.Lerp(_speed,2f,1f);
            //transform.position = new Vector3(transform.position.x,transform.position.y,Mathf.Lerp(0f,_speed,temp_time));
            //temp_time += Time.deltaTime;
            _timeFromStart_previous = _timeFromStart_int;
            _timeFromStart += Time.deltaTime;
        }
        else
        {
            transform.Translate(new Vector3(0,0,-(_speed*Time.deltaTime)));
            //transform.Translate(Vector3.back*_speed*Time.deltaTime);
            //Mathf.Lerp(-(_speed),2f,1f);
            //transform.position = new Vector3(transform.position.x,transform.position.y,Mathf.Lerp(0f,-(_speed),temp_time));
            //temp_time += Time.deltaTime;
            _timeFromStart_previous = _timeFromStart_int;
            _timeFromStart += Time.deltaTime;
        }
        
    }
}
