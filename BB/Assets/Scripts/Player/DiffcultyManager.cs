using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DifficultyManager 
{
   
    
        public static float speed = 8f;
        public static void Easy()
        {
            speed = 16f;
        }
        public static void Moderate()
        {
            speed = 12f;
        }
        public static void Hard()
        {
            speed = 8f;
        }

    }

