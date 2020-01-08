package com.maven.lab.submodule_2;

import com.zhglab.service.ScreenFinder;
/**
 * Hello world!
 *
 */
public class LookupWorker
{
    public int findScreen( int modelId )
    {
        ScreenFinder sf = new ScreenFinder();

        // This depend on find-scree-service version 1.1
//        int distId = sf.findADistrict(modelId, 99);

        // This depends on find-screen-service version 1.0
        // String distId = sf.findLocationFromModel(modelId);

        return Integer.valueOf(sf.findLocationFromModel(modelId));
    }
}
