using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Dursun : MonoBehaviour
{
    private Tween _tween1_1;
    private Tween _tween1_2;
    private Tween _tween2_1;
    private Tween _tween2_2;
    private Tween _tween3_1;
    private Tween _tween3_2;
    private Tween _tween4_1;
    private Tween _tween4_2;
    private Sequence sequence_1;
    private Sequence sequence_2;
    private Sequence sequence_3;
    private Sequence sequence_4;
    private Sequence mainSequence;
    public List<Sequence> Sequences = new List<Sequence>();
    private Sequence currentSequence;

    private Tween deneme;
    private void Start()
    {
        setTweens();
        //mainSequence = DOTween.Sequence().SetAutoKill(false);
        //.SetLoops(-1)
        deneme.Play();
        //StartCoroutine(coroutine1());
    }

    void setTweens()
    {
        _tween1_1 = transform.DOLocalMove(new Vector3(0, 2, 0), 1).Pause().SetAutoKill(false);;
        _tween1_2 = transform.DOLocalMove(new Vector3(0, 2, 2), 1).Pause().SetAutoKill(false);;
        _tween2_1 = transform.DOLocalMove(new Vector3(-2, 2, 2), 1).Pause().SetAutoKill(false);;
        _tween2_2 = transform.DOLocalMove(new Vector3(0, 2, 2), 1).Pause().SetAutoKill(false);;
        _tween3_1 = transform.DOLocalMove(new Vector3(0, 2, 4), 1).Pause().SetAutoKill(false);;
        _tween3_2 = transform.DOLocalMove(new Vector3(0, 2, 2), 1).Pause().SetAutoKill(false);;
        _tween4_1 = transform.DOLocalMove(new Vector3(2, 2, 2), 1).Pause().SetAutoKill(false);;
        _tween4_2 = transform.DOLocalMove(new Vector3(0, 2, 2), 1).Pause().SetAutoKill(false);;

        sequence_1 = DOTween.Sequence();
        sequence_2 = DOTween.Sequence();
        sequence_3 = DOTween.Sequence();
        sequence_4 = DOTween.Sequence();
        Vector3[] arraycik = {new Vector3(0, 2, 0),new Vector3(0, 2, 2)};
        deneme = transform.DOPath(arraycik, 2);

        sequence_1
            .Append(_tween1_1)
            .Append(_tween1_2)
            .Pause()
            .SetAutoKill(false);

        sequence_2
            .Append(_tween2_1)
            .Append(_tween2_2)
            .Pause()
            .SetAutoKill(false);

        sequence_3
            .Append(_tween3_1)
            .Append(_tween3_2)
            .Pause()
            .SetAutoKill(false);

        sequence_4
            .Append(_tween4_1)
            .Append(_tween4_2)
            .Pause()
            .SetAutoKill(false);
        
        Sequences.Add(sequence_1);
        Sequences.Add(sequence_2);
        Sequences.Add(sequence_3);
        Sequences.Add(sequence_4);
    }
    
    /*
    public void MoveForward()
    {
        Vector3 pos = transform.position;
        pos.z += 2;
        Debug.Log(pos);
        Tween tween = transform.DOMove(pos,1);
    }

    public void MoveBackward()
    {
        Vector3 pos = transform.position;
        pos.z -= 2;
        Debug.Log(pos);
        transform.DOMove(pos, 1);
    }*/
    
    
    IEnumerator coroutine1()
    {
        //currentSequence = DOTween.Sequence().SetAutoKill(false);
        int number = 0;
        transform.DOMove(new Vector3(0, 2, 2), 1);
        yield return new WaitForSeconds(1f);
        //currentSequence = Sequences[number];
        //currentSequence.Play().SetAutoKill(false);
        
        while (true)
        {
            deneme.Play();
            Debug.Log("naber");
            yield return new WaitForSeconds(2f);
            deneme.Restart();
            
            //currentSequence = Sequences[number];
            //currentSequence.Play().SetAutoKill(false);
            /*if (Input.GetKey(KeyCode.F))
            {
                transform.DORotate(new Vector3(0, 90, 0), 0);
                number++;
                if (number >= 3)
                {
                    number = 0;
                }
                currentSequence = Sequences[number];
            }*/
            
        }
    }
}