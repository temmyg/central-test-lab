package com.maven.lab.webapp_basic;

import com.maven.lab.submodule_2.LookupWorker;
import org.slf4j.LoggerFactory;
import org.slf4j.Logger;
import org.springframework.stereotype.Controller;
import org.springframework.ui.ModelMap;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.apache.myfaces.blank.TestEntity;
//import com.maven.lab.submodule_2.LookupWorker;

@RequestMapping("")
@Controller
public class HelloController {
    @RequestMapping(value="/", method = RequestMethod.GET)
    public String printHello(ModelMap model){
        TestEntity te = new TestEntity();
        int modelId = 113;
        int distId1 = te.findScreen(modelId);
        int score = te.getPlayer(123);

        LookupWorker lworker = new LookupWorker();
        int distId2 = lworker.findScreen(modelId);

//        ScreenFinder screenFinder = new ScreenFinder();
//        int districtId = screenFinder.findADistrict(113);

        Logger logger = LoggerFactory.getLogger(HelloController.class);
        logger.info("some info....player score:{}", score);
        model.addAttribute("message", "Hello Ge Zhou!");
        model.addAttribute("score", score);
//        model.addAttribute("districtId", districtId);
        model.addAttribute("distId1", distId1);
        model.addAttribute("distId2", distId2);
        return "hello";
    }
}