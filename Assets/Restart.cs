﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void onClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 10);
    }
}
