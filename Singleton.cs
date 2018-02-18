using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> where T: new(){

    protected static T instance
    {
        get
        {
            if (instance==null)
            {
                instance = new T();

            }
            return instance;
        }
    }
}
