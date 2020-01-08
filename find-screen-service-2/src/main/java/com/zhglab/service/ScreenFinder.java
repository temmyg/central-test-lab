package com.zhglab.service;

/**
 * Hello world!
 *
 */
public class ScreenFinder {
    public int findLocationFromModel(int modelId, int inches){
        return modelId * 100 + inches * 1;
    }

//    public String findLocationFromModel(int modelId){
//        return String.valueOf(modelId * 100 + 88 * 1);
//    }

    public int findLocationFromModel(int modelId){
        return modelId * 100 + 77 * 1;
    }
}
