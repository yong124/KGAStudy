using Packages.Rider.Editor.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;



public class Sutdy_01 : MonoBehaviour
{
    public float speed;
    public Transform[] backgrounds;

    float leftPosX = 0f;
    float rightPosX = 0f;
    float xScreenHalfSize;
    float yScreenHalfSize;
    string yongwon = "¤±¤¤¤·¤©";
    Vector2 startPoint = new Vector2(3, 5);
    int plus = 5 + 5;
    string test;
    // Start is called before the first frame update

    private void Awake()
    {
        Debug.Log(test);

    }
    void Start()
    {
        Debug.Log("Update");


    }
    // Update is called once per frame
    void Update()
    {

    }
    private void OnDisable()
    {
        Debug.Log("²¨Áü");
    }
    private void OnEnable()
    {
        Debug.Log("ÄÑÁü ¤»");
    }

    private void OnApplicationPause(bool pause)
    {
        
    }
    private void OnApplicationQuit()
    {
        
    }
    private void OnApplicationFocus(bool focus)
    {
        
    }

    IEnumerator Couroutine()
    {
        yield return new WaitForEndOfFrame();
    }
}
