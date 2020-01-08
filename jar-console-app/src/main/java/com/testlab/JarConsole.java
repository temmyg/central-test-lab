package com.testlab;

import com.zhglab.service.ScreenFinder;

/**
 * Hello world!
 *
 */
public class JarConsole
{
    public static void main( String[] args )
    {
        ScreenFinder sf = new ScreenFinder();
        int distId = sf.findLocationFromModel(113);
        System.out.println( "Screen find in District: " + distId );
    }
}
