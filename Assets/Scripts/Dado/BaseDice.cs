using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RAYEDPS
{
<<<<<<< HEAD
    public struct DiceType
    {
        enum TYPE { BOOL_TYPE,  NUM_TYPE};

    }

    [Serializable]
    public class DiceBase : ScriptableObject
    {
        
        DiceType diceType;
        

        public void SetFaces(bool[] faces)
        {
          
        }

        public bool getSide(int face)
        {
         
        }
 
=======


    [Serializable]
    public class BaseDice<T> : ScriptableObject
    {
        
        DiceType diceType;

        T[] faces = new T[5];

       public T GetFace(int side)
        {
            return faces[side];
        }
>>>>>>> Try

    }
  
}