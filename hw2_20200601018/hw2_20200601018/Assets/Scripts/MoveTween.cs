using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveTween : MonoBehaviour
{
    /*
    //public float _duration = 1f;
    //public float _speed = 2f;
    
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
    private Sequence currentSequence;
    public List<Sequence> Sequences = new List<Sequence>();
    */
    public List<IEnumerator> coroutines = new List<IEnumerator>();
    
    //private List<Tween> _tweens = new List<Tween>();
    
    int number = 0;
    private bool first = true;
    
    void Start()
    {
        coroutines.Add(seq_1());
        coroutines.Add(seq_2());
        coroutines.Add(seq_3());
        coroutines.Add(seq_4());
        StartCoroutine(MainLoop());
        //StartCoroutine(coroutines[1]); denedim
    }

    
    private IEnumerator MainLoop()
    {
        if (first = true)
        {
            transform.DOMove(new Vector3(0, 2, 2), 1);
            yield return new WaitForSeconds(1f);
            first = false;
        }
        
        if (number > 3)
        {
            number = 0;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Rotate(0,90f,0);
            number++;
            if (number >= 3)
            {
                number = 0;
            }
        }

        
        yield return StartCoroutine(coroutines[number]);
        //new WaitForSeconds(2f);
        number++;
        StartCoroutine(MainLoop());
    }

    private IEnumerator seq_1()
    {
        transform.DOLocalMove(new Vector3(0, 2, 0), 1).SetAutoKill(false);
        yield return new WaitForSeconds(1f);
        transform.DOLocalMove(new Vector3(0, 2, 2), 1).SetAutoKill(false);
    }
    private IEnumerator seq_2()
    {
        
        transform.DOLocalMove(new Vector3(-2, 2, 2), 1).SetAutoKill(false);
        yield return new WaitForSeconds(1f);
        transform.DOLocalMove(new Vector3(0, 2, 2), 1).SetAutoKill(false);
    }
    private IEnumerator seq_3()
    {
        transform.DOLocalMove(new Vector3(0, 2, 4), 1).SetAutoKill(false);
        yield return new WaitForSeconds(1f);
        transform.DOLocalMove(new Vector3(0, 2, 2), 1).SetAutoKill(false);
    }
    private IEnumerator seq_4()
    {
        transform.DOLocalMove(new Vector3(2, 2, 2), 1).SetAutoKill(false);
        yield return new WaitForSeconds(1f);
        transform.DOLocalMove(new Vector3(0, 2, 2), 1).SetAutoKill(false);
    }

    /*
    void setCorotines()
    {

        _tween1_1 = transform.DOLocalMove(new Vector3(0, 2, 0), 1).SetAutoKill(false);
        _tween1_2 = transform.DOLocalMove(new Vector3(0, 2, 2), 1).SetAutoKill(false);
        _tween2_1 = transform.DOLocalMove(new Vector3(-2, 2, 2), 1).SetAutoKill(false);
        _tween2_2 = transform.DOLocalMove(new Vector3(0, 2, 2), 1).SetAutoKill(false);
        _tween3_1 = transform.DOLocalMove(new Vector3(0, 2, 4), 1).SetAutoKill(false);
        _tween3_2 = transform.DOLocalMove(new Vector3(0, 2, 2), 1).SetAutoKill(false);
        _tween4_1 = transform.DOLocalMove(new Vector3(2, 2, 2), 1).SetAutoKill(false);
        _tween4_2 = transform.DOLocalMove(new Vector3(0, 2, 2), 1).SetAutoKill(false);

        sequence_1 = DOTween.Sequence();
        sequence_2 = DOTween.Sequence();
        sequence_3 = DOTween.Sequence();
        sequence_4 = DOTween.Sequence();

        sequence_1
            .Append(_tween1_1)
            .Append(_tween1_2)
            .SetAutoKill(true).Pause();

        sequence_2
            .Append(_tween2_1)
            .Append(_tween2_2)
            .SetAutoKill(false).Pause();

        sequence_3
            .Append(_tween3_1)
            .Append(_tween3_2)
            .SetAutoKill(false).Pause();

        sequence_4
            .Append(_tween4_1)
            .Append(_tween4_2)
            .SetAutoKill(false).Pause();

        Sequences.Add(sequence_1);
        Sequences.Add(sequence_2);
        Sequences.Add(sequence_3);
        Sequences.Add(sequence_4);

    }
    */
    /*
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
    }*/
}

