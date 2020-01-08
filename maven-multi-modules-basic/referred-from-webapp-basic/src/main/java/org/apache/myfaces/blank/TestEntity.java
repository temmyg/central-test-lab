package org.apache.myfaces.blank;

import com.zhglab.service.ScreenFinder;
import org.slf4j.LoggerFactory;
import org.slf4j.Logger;

public class TestEntity {
    private static final Logger logger = LoggerFactory.getLogger(TestEntity.class);
    public int getPlayer(int id){
        logger.info("getPlayer 67...");
        logger.info("getPlayer 3...");
        return id*1000000;
    }

    public int findScreen(int modelId){
        ScreenFinder sf = new ScreenFinder();
        int districtId = sf.findLocationFromModel(modelId);
        return districtId;
    }
}
