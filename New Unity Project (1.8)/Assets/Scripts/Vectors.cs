using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vectors : MonoBehaviour
{
    public Vector3 rangeStartToObject;
    public Vector3 rangeEndToObject;

    //Два объекта для вычисления вектора между объекта
    public GameObject startObjectForRange;
    public GameObject endObjectForRange;

    public int randomNubmer;

    private float rangeTwoObjects;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 add = new Vector3(UnityEngine.Random.Range(0, 20), UnityEngine.Random.Range(0, 20), UnityEngine.Random.Range(0, 20));
        Vector3 add1 = new Vector3(UnityEngine.Random.Range(0, 20), UnityEngine.Random.Range(0, 20), UnityEngine.Random.Range(0, 20));
        Vector3 add2 = add + add1;
        Debug.Log("Вектор 1 " + add + " и вектор 2 " + add1 + ". Сложим два вектора и выходит: " + add2);

        Vector3 ded = new Vector3(UnityEngine.Random.Range(0, 20), UnityEngine.Random.Range(0, 20), UnityEngine.Random.Range(0, 20));
        Vector3 ded1 = new Vector3(UnityEngine.Random.Range(0, 20), UnityEngine.Random.Range(0, 20), UnityEngine.Random.Range(0, 20));
        Vector3 ded2 = ded - ded1;
        Debug.Log("Вектор 3 " + ded + " и вектор 4 " + ded1 + ". Вычитаем с вектора 3 вектор 4 и выходит: " + ded2);

        Vector3 mult = new Vector3(UnityEngine.Random.Range(0, 20), UnityEngine.Random.Range(0, 20), UnityEngine.Random.Range(0, 20));
        randomNubmer = UnityEngine.Random.Range(2, 10);
        Vector3 mult1 = new Vector3(mult.x * randomNubmer, mult.y * randomNubmer, mult.z * randomNubmer);
        Debug.Log("Вектор 5 " + mult + ". Умножаем вектор 5 на число " + randomNubmer + " и выходит: " + mult1);
    }

    // Update is called once per frame
    void Update()
    {
        if((startObjectForRange == null) || (endObjectForRange == null))
        {
            return;
        }
        else
        {
            Debug.Log("Точка первого шара: " + startObjectForRange.transform.position);
            Debug.Log("Точка второго шара: " + endObjectForRange.transform.position);
            rangeBetweenTwoObjects();
        }
    }

    public void rangeBetweenTwoObjects()
    {
        Vector3 sp = startObjectForRange.transform.position;
        Vector3 ep = endObjectForRange.transform.position;
        float spep = (float)Math.Pow(ep.x - sp.x, 2) + (float)Math.Pow(ep.y - sp.y, 2) + (float)Math.Pow(ep.z - sp.z, 2);
        rangeTwoObjects = (float)Math.Sqrt(spep);
        Debug.Log("Расстояние между первого и второго шара: " + rangeTwoObjects);
    }
}
