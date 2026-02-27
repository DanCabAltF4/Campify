package org.example;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

@SpringBootApplication
public class JavaAppApplication {

    public static void main(String[] args) {

//        System.out.println(new BCryptPasswordEncoder().encode("1234"));
        SpringApplication.run(JavaAppApplication.class, args);
    }

}
