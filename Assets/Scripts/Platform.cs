﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Width { Short, Medium, Long }
public enum Height { Low, Middle, High }

public class Platform {
    
    private Width width;
    private Height height; 

    public Platform(Width width, Height height) {
        this.width = width;
        this.height = height;
    }

    public Width getWidth() {
        return this.width;
    }

    public Height getHeight() {
        return this.height;
    }

    public int getNumCoins() {
        switch (this.width) {
            case Width.Short:
                return 3;
            case Width.Medium:
                return 5;
            case Width.Long:
                return 7; 
            default:
                return -1;
        }
    }
}
