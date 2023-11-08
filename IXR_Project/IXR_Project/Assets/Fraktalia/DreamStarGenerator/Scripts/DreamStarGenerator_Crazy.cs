using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Fraktalia.DreamStarGen
{
    // public float angleSpeed = 1.0f; 
    // private float currentAngle = 0.0f;
    public class DreamStarGenerator_Crazy : DreamStarGenerator
    {



        public override Vector3 StarAlgorithm(float Angle)
        { 
         
        // currentAngle += angleSpeed * Time.deltaTime; 
        // currentAngle = currentAngle % 360;
        // Vector3 starPosition = StarAlgorithm(currentAngle);

            float r = 0;

            float radiant = Angle * a;
            float alternator = Mathf.Cos(radiant / (b / 1000));


            float value1 = 1 * alternator;


            r = Radius * (value1);

            float x = r * Mathf.Cos(Angle);
            float y = r * Mathf.Sin(Angle);
            return new Vector3(x, y, 0);
        }
    }
}