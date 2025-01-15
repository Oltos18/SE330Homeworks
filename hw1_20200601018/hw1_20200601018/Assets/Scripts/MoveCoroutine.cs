using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveCoroutine : MonoBehaviour
{
    public float _duration = 1f;
    public float _speed = 2f;
    void Start() {
        StartCoroutine(MainLoop());
    }

    private IEnumerator MainLoop()
    {
        StartCoroutine(GoToCenter());
        yield return new WaitForSeconds(1f);
        
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Rotate(0,90f,0);
        }
        
        StartCoroutine(GoFromCenter());
        yield return new WaitForSeconds(1f);
        
        StartCoroutine(MainLoop());
    }

    private IEnumerator GoToCenter()
    {
        for (float i = 0; i <= _duration; i += Time.deltaTime)
        {
            transform.Translate(0,0,_speed/_duration*Time.deltaTime);
            yield return null;
        }
        //transform.Translate(0,0,Mathf.Round(transform.position.z));
        //transform.position=new Vector3(0, 0, Mathf.Floor(transform.position.z)); makes the box jumpy
                                                                                 //when the box moves a little less than expected
        yield break;
    }

    private IEnumerator GoFromCenter()
    {
        for (float i = 0; i <= _duration; i += Time.deltaTime)
        {
            transform.Translate(0,0,-(_speed/_duration*Time.deltaTime));
            yield return null;
        }
        //transform.Translate(0,0,Mathf.Round(transform.position.z));
        //transform.position=new Vector3(0, 0, Mathf.Ceil(transform.position.z)); makes the box jumpy
                                                                                //when the box moves a little more than expected
        yield break;
    }
}
