package org.example;

import org.example.persistence.ConexionDB;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

@SpringBootApplication
public class JavaAppApplication {

    public static void main(String[] args) {

        ConexionDB.crearBaseDatos();
        SpringApplication.run(JavaAppApplication.class, args);
    }

}
