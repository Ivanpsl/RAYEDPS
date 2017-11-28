using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RAYEDPS
{
    public class DiceResult<T,U> 
    {

        public T Dice { get; set; }
        public U Result { get; set; }

        public DiceResult (T dice, U result){
            this.Dice = dice;
            this.Result = result;
        }

    }
}