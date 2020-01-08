package com.maven.lab.webapp_basic;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

public class DoorsInn {
    private static final Logger logger = LoggerFactory.getLogger(DoorsInn.class);
    public DoorsInn(){

    }

    public int findDoors(){
        logger.info("findDoors(..)");
        return 5;
    }
}