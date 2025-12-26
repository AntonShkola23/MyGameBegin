using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Unit2 : MonoBehaviour
{
    void Start()
    {
        short s = 0;
        int i = 0;
        long l = 0;
        float f = 0;
        double d = 0;

        var c = 0f;

        object o = d; //boxing
        double d2 = (double)o; //unboxing

        Debug.Log(s);
        Debug.Log(f);
        Debug.Log(c);

        i = (int)l;
        l = i;

        ushort a = 6781;
        byte v = (byte)a;

        TestFunc(ref i);

        if (o!=null)
        {
            //int i2 = (int)o;
        }

        int[] array = new int[10000];

        List<int> list = new List<int>(80);
    }

    public void Exp()
    {
        int i = 1;
        object o = i;
        int j = (int)o;
    }

    public void TestFunc(ref int i)
    {
        i = 10;
        Debug.Log(i);
    }
}
